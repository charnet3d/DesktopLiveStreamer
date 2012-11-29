using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Security;
using Microsoft.Win32;

namespace DesktopLiveStreamer
{
    public partial class FrmStreams : Form
    {
        private ListStreams listFavoriteStreams;
        private ListStreams listLiveStreams;

        private Boolean playing;
        private Boolean updatingLiveStreams;
        private Boolean updatingQualities;
        private Boolean checkingFavoritesOnlineStatus;

        Process qualityCheckProcess;
        Process liveStreamerProcess;
        Process VLCStreamProcess;

        Thread updateLiveStreamsThread;
        Thread updateQualitiesThread;

        public FrmStreams()
        {
            InitializeComponent();

            listFavoriteStreams = new ListStreams();
            listLiveStreams = new ListStreams();

            XMLPersist.XMLFile = "streamlist.xml";
            XMLPersist.loadStreamListConfig(listFavoriteStreams);

            // Check if VLC executable is found
            if (!File.Exists(XMLPersist.VLCExecutable.Replace("\\\" --file-caching=5000", "").Replace("\\\"", "")))
            {
                // Try to get VLC directory from registry
                String path = ReadVLCExecutable();
                if (path != null && File.Exists(path))
                {
                    XMLPersist.VLCExecutable = "\\\"" + path + "\\\" --file-caching=5000"; ;
                    XMLPersist.saveStreamListConfig(listFavoriteStreams);
                }
                else
                {
                    DialogResult r = MessageBox.Show(this, 
                        "VLC player appears not to be installed or has been put in a different directory. Would you like to specify its path now ?", 
                        "VLC Player not found", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                        btnChangeVLC_Click(this, EventArgs.Empty);
                }
            }


            // Check if LiveStreamer executable is found
            if (!File.Exists(XMLPersist.LiveStreamerExecutable))
            {
                DialogResult r = MessageBox.Show(this, 
                    "LiveStreamer appears not to be installed or has been put in a different directory. Would you like to specify its path now ?", 
                    "LiveStreamer not found", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                    btnChangeStreamer_Click(this, EventArgs.Empty);
            }

            updateComboStreams();

            playing = false;
            btnStop.Enabled = false;
            btnPlay.Enabled = false;
            btnOpenBrowser.Enabled = false;

            radioList2.Checked = true;

            groupFavorites.Enabled = false;
            groupLive.Enabled = true;

            cmbQualities.Enabled = false;
            btnAddLiveStream.Enabled = false;

            imgCmbStreams_SelectedIndexChanged(this, EventArgs.Empty);

            updateLiveStreamsThread = new Thread(new ThreadStart(updateLiveStreams));
            updateLiveStreamsThread.Start();
        }

        public Boolean FileExists()
        {

            return false;
        }

        public string ReadVLCExecutable()
        {
            // Opening the registry key
            RegistryKey rk = Registry.LocalMachine;
            // Open a subKey as read-only
            RegistryKey sk1 = rk.OpenSubKey("SOFTWARE\\VideoLAN\\VLC");
            // If the RegistrySubKey doesn't exist -> (null)
            if (sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    // If the RegistryKey exists I get its value
                    // or null is returned.
                    return (string)sk1.GetValue("");
                }
                catch (Exception e)
                {
                    // AAAAAAAAAAARGH, an error!
                    Console.WriteLine("Error Reading VLC Executable path from registry");
                    return null;
                }
            }
        }


        private void btnChangeStreamer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            ofd.Filter = "Executable files|*.exe";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                XMLPersist.LiveStreamerExecutable = ofd.FileName;

                XMLPersist.saveStreamListConfig(listFavoriteStreams);
            }
        }

        private void btnAddStream_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd(listFavoriteStreams);

            if (frmAdd.ShowDialog() == DialogResult.OK)
                updateComboStreams();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playing = true;

            Thread playingThread = new Thread(new ThreadStart(playingLoop));
            playingThread.Start();
        }

        

        public void liveStreamerProcess_OuputDataReceived(object sendingProcess, DataReceivedEventArgs outLine)
        {
            
            //String streamerOutput = ((Process)sendingProcess).StandardError.ReadLine();


            Console.WriteLine(outLine.Data);
                
        }

        

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            FrmAdd frmAdd = new FrmAdd(listFavoriteStreams, imgCmbStreams.SelectedIndex, false);

            if (frmAdd.ShowDialog() == DialogResult.OK)
                updateComboStreams();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you really want to delete the stream '" + ((DropDownItem)imgCmbStreams.SelectedItem).Value + "' ?",
                                                "Delete Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button2);

            if (r == DialogResult.Yes)
            {
                listFavoriteStreams.remove(imgCmbStreams.SelectedIndex);
                listFavoriteStreams.sort();

                XMLPersist.saveStreamListConfig(listFavoriteStreams);

                updateComboStreams();
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd(listFavoriteStreams, imgCmbStreams.SelectedIndex, true);

            if (frmAdd.ShowDialog() == DialogResult.OK)
                updateComboStreams();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            playing = false;

            // close the vlc window
            if (VLCStreamProcess != null && !VLCStreamProcess.HasExited)
                VLCStreamProcess.Kill();

            // Close the livestreamer window
            if (liveStreamerProcess != null && !liveStreamerProcess.HasExited)
                liveStreamerProcess.Kill();
            

            btnPlay.Enabled = true;
            btnStop.Enabled = false;
        }

        private void radioList1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioList1.Checked)
            {
                groupFavorites.Enabled = true;
                groupLive.Enabled = false;

                btnPlay.Enabled = true;
                btnOpenBrowser.Enabled = true;
            }
            else if (radioList2.Checked)
            {
                groupFavorites.Enabled = false;
                groupLive.Enabled = true;

                if (imgCmbLiveStreams.Items.Count > 0)
                {
                    if (updatingQualities)
                        btnPlay.Enabled = false;
                    else
                        btnPlay.Enabled = true;

                    btnOpenBrowser.Enabled = true;
                }
                else
                {
                    btnPlay.Enabled = false;
                    btnOpenBrowser.Enabled = false;
                }
            }
        }

        private void FrmStreams_FormClosed(object sender, FormClosedEventArgs e)
        {
            playing = false;

            // close the vlc window
            if (VLCStreamProcess != null && !VLCStreamProcess.HasExited)
                VLCStreamProcess.Kill();

            // Close the livestreamer window
            if (liveStreamerProcess != null && !liveStreamerProcess.HasExited)
                liveStreamerProcess.Kill();

            if (qualityCheckProcess != null && !qualityCheckProcess.HasExited)
                qualityCheckProcess.Kill();

            if (updateQualitiesThread != null)
                updateQualitiesThread.Abort();

            if (updateLiveStreamsThread != null)
                updateLiveStreamsThread.Abort();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateLiveStreamsThread = new Thread(new ThreadStart(updateLiveStreams));
            updateLiveStreamsThread.Start();
        }

        private void btnChangeVLC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            ofd.Filter = "Executable files|*.exe";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                XMLPersist.VLCExecutable = "\\\"" + ofd.FileName + "\\\" --file-caching=5000";

                XMLPersist.saveStreamListConfig(listFavoriteStreams);
            }
        }

        public void updateComboStreams()
        {
            imgCmbStreams.Items.Clear();

            for (int i = 0; i < listFavoriteStreams.getSize(); i++)
            {
                imgCmbStreams.Items.Add(new DropDownItem(listFavoriteStreams[i].Caption + " - " + listFavoriteStreams[i].Quality));
            }
            if (listFavoriteStreams.getSize() > 0)
                imgCmbStreams.SelectedIndex = 0;
        }


        private Process getVLCStreamProcess()
        {
            Process p = null;

            // search for the vlc window
            Process[] allProcesses = Process.GetProcesses();
            for (int i = 0; i < allProcesses.Length; i++)
            {

                if (allProcesses[i].MainWindowTitle.Contains("fd://0"))
                {
                    p = allProcesses[i];
                    break;
                }
            }

            return p;
        }


        /// <summary>
        /// /////////////////////////////////// UPDATE LIVE STREAMS
        /// </summary>

        public void updateLiveStreams()
        {
            try
            {
                updatingLiveStreams = true;

                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Updating stream lists from Twitch.tv...";
                        statusLabel.ForeColor = Color.Brown;
                    }));

                if (progressLiveStreams.InvokeRequired)
                    progressLiveStreams.Invoke(new MethodInvoker(delegate
                    {
                        toolTip1.SetToolTip(progressLiveStreams, "Updating stream lists from Twitch.tv...");
                        progressLiveStreams.Visible = true;
                    }));

                if (btnUpdate.InvokeRequired)
                    btnUpdate.Invoke(new MethodInvoker(delegate { btnUpdate.Enabled = false; }));


                // Loading stream list from Twitch


                string url = "https://api.twitch.tv/kraken/streams?game=League+of+Legends";
                WebRequest request = WebRequest.Create(url);
                WebResponse ws = request.GetResponse();

                String responseString = "";
                using (System.IO.Stream stream = ws.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    responseString = reader.ReadToEnd();
                }

                JObject obj = JObject.Parse(responseString);

                JArray twitchStreams = (JArray)obj["streams"];

                listLiveStreams.clear();

                for (int i = 0; i < twitchStreams.Count; i++)
                {
                    listLiveStreams.add(new Stream((String)twitchStreams[i]["channel"]["status"],
                                                    (String)twitchStreams[i]["channel"]["url"],
                                                    long.Parse(twitchStreams[i]["viewers"].ToString()), "Twitch",
                                                    (String)twitchStreams[i]["channel"]["name"]));
                }

                // Loading stream list from Own3D

                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Updating stream lists from Own3D.tv...";
                        statusLabel.ForeColor = Color.Brown;

                        progressLiveStreams.Visible = true;
                    }));

                if (progressLiveStreams.InvokeRequired)
                    progressLiveStreams.Invoke(new MethodInvoker(delegate
                    {
                        toolTip1.SetToolTip(progressLiveStreams, "Updating stream lists from Own3D.tv...");
                        progressLiveStreams.Visible = true;
                    }));

                url = "http://api.own3d.tv/rest/live/list.json?gameid=163";
                request = WebRequest.Create(url);
                ws = request.GetResponse();

                responseString = "";
                using (System.IO.Stream stream = ws.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    responseString = reader.ReadToEnd();
                }

                JArray own3dStreams = JArray.Parse(responseString);

                for (int i = 0; i < own3dStreams.Count; i++)
                {
                    listLiveStreams.add(new Stream((String)own3dStreams[i]["live_name"],
                                                    ((String)own3dStreams[i]["link"]).Replace("\\/", "/"),
                                                    long.Parse(own3dStreams[i]["live_viewers"].ToString()), "Own3D",
                                                    (String)own3dStreams[i]["live_id"]));
                }

                listLiveStreams.sortByViewers();

                if (imgCmbLiveStreams.InvokeRequired)
                    imgCmbLiveStreams.Invoke(new MethodInvoker(delegate
                    {
                        imgCmbLiveStreams.Items.Clear();
                        Image img;
                        for (int i = 0; i < listLiveStreams.getSize(); i++)
                        {
                            img = (listLiveStreams[i].Host.Equals("Twitch") ?
                                    DesktopLiveStreamer.Properties.Resources.twitch :
                                    DesktopLiveStreamer.Properties.Resources.own3d);
                            imgCmbLiveStreams.Items.Add(new DropDownItem(listLiveStreams[i].Viewers.ToString() +
                                                                    " - " + listLiveStreams[i].Caption, img));
                        }
                        if (imgCmbLiveStreams.Items.Count > 0)
                            imgCmbLiveStreams.SelectedIndex = 0;
                    }));

                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Ready";
                        statusLabel.ForeColor = Color.Black;
                    }));

                if (qualityCheckProcess != null && !qualityCheckProcess.HasExited)
                    qualityCheckProcess.Kill();
                if (updateQualitiesThread != null)
                    updateQualitiesThread.Abort();
                updateQualitiesThread = new Thread(new ThreadStart(updateQualities));
                updateQualitiesThread.Start();

                updatingLiveStreams = false;
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (WebException)
            {
                try
                {
                    if (statusStrip1.InvokeRequired)
                        statusStrip1.Invoke(new MethodInvoker(delegate
                        {
                            statusLabel.Text = "Error: Connection failed. Check your internet access or firewall.";
                            statusLabel.ForeColor = Color.Red;
                        }));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            catch (Newtonsoft.Json.JsonException)
            {
                listLiveStreams.sortByViewers();

                if (imgCmbLiveStreams.InvokeRequired)
                    imgCmbLiveStreams.Invoke(new MethodInvoker(delegate
                    {
                        imgCmbLiveStreams.Items.Clear();
                        Image img;
                        for (int i = 0; i < listLiveStreams.getSize(); i++)
                        {
                            img = (listLiveStreams[i].Host.Equals("Twitch") ?
                                    DesktopLiveStreamer.Properties.Resources.twitch :
                                    DesktopLiveStreamer.Properties.Resources.own3d);
                            imgCmbLiveStreams.Items.Add(new DropDownItem(listLiveStreams[i].Viewers.ToString() +
                                                                    " - " + listLiveStreams[i].Caption, img));
                        }
                        if (imgCmbLiveStreams.Items.Count > 0)
                            imgCmbLiveStreams.SelectedIndex = 0;
                    }));

                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Ready";
                        statusLabel.ForeColor = Color.Black;
                    }));

                if (qualityCheckProcess != null && !qualityCheckProcess.HasExited)
                    qualityCheckProcess.Kill();
                if (updateQualitiesThread != null)
                    updateQualitiesThread.Abort();
                updateQualitiesThread = new Thread(new ThreadStart(updateQualities));
                updateQualitiesThread.Start();

                updatingLiveStreams = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (btnUpdate.InvokeRequired)
                    btnUpdate.Invoke(new MethodInvoker(delegate { btnUpdate.Enabled = true; }));

                if (btnPlay.InvokeRequired)
                    btnPlay.Invoke(new MethodInvoker(delegate { btnPlay.Enabled = true; }));

                if (btnOpenBrowser.InvokeRequired)
                    btnOpenBrowser.Invoke(new MethodInvoker(delegate { btnOpenBrowser.Enabled = true; }));

                if (progressLiveStreams.InvokeRequired)
                    progressLiveStreams.Invoke(new MethodInvoker(delegate { progressLiveStreams.Visible = false; }));
            }
        }


        /// <summary>
        /// /////////////////////////////////// UPDATE STREAM QUALITIES
        /// </summary>

        public void updateQualities()
        {
            updatingQualities = true;
            try
            {
                if (btnAddLiveStream.InvokeRequired)
                    btnAddLiveStream.Invoke(new MethodInvoker(delegate { btnAddLiveStream.Enabled = false; }));

                if (btnUpdate.InvokeRequired)
                    btnUpdate.Invoke(new MethodInvoker(delegate { btnUpdate.Enabled = false; }));

                if (btnPlay.InvokeRequired)
                    btnPlay.Invoke(new MethodInvoker(delegate { btnPlay.Enabled = false; }));

                if (cmbQualities.InvokeRequired)
                    cmbQualities.Invoke(new MethodInvoker(delegate { cmbQualities.Enabled = false; }));

                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Loading supported qualities for selected stream...";
                        statusLabel.ForeColor = Color.Brown;
                    }));

                if (progressQuality.InvokeRequired)
                    progressQuality.Invoke(new MethodInvoker(delegate {
                        toolTip1.SetToolTip(progressQuality, "Loading supported qualities for selected stream...");
                        progressQuality.Visible = true;
                    }));

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = XMLPersist.LiveStreamerExecutable;

                int index = 0;

                if (imgCmbLiveStreams.InvokeRequired)
                    imgCmbLiveStreams.Invoke(new MethodInvoker(delegate { index = imgCmbLiveStreams.SelectedIndex; }));

                String url = (String)listLiveStreams[index].StreamUrl;

                startInfo.Arguments = url + " --rtmpdump \"Livestreamer\\rtmpdump\\rtmpdump.exe\"";
                qualityCheckProcess = Process.Start(startInfo);

                String qualities = "";

                // Ignore first line of output
                qualityCheckProcess.StandardOutput.ReadLine();

                // Take the line where supported qualities are output
                qualities = qualityCheckProcess.StandardOutput.ReadLine();

                if (qualities != null && qualities.StartsWith("Found streams: "))
                {
                    qualities = qualities.Replace("Found streams: ", "");
                    qualities = qualities.Replace(", ", ",");

                    String[] tabQualities;
                    tabQualities = qualities.Split(',');

                    if (cmbQualities.InvokeRequired)
                        cmbQualities.Invoke(new MethodInvoker(delegate
                        {
                            cmbQualities.Items.Clear();
                            foreach (String q in tabQualities)
                            {
                                cmbQualities.Items.Add(q);
                            }

                            if (cmbQualities.Items.Count > 0)
                                cmbQualities.SelectedIndex = 0;
                        }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Ready";
                        statusLabel.ForeColor = Color.Black;
                    }));

                if (progressQuality.InvokeRequired)
                    progressQuality.Invoke(new MethodInvoker(delegate { progressQuality.Visible = false; }));

                if (btnUpdate.InvokeRequired)
                    btnUpdate.Invoke(new MethodInvoker(delegate { btnUpdate.Enabled = true; }));

                if (btnPlay.InvokeRequired)
                    btnPlay.Invoke(new MethodInvoker(delegate { btnPlay.Enabled = true; }));

                if (btnAddLiveStream.InvokeRequired)
                    btnAddLiveStream.Invoke(new MethodInvoker(delegate { btnAddLiveStream.Enabled = true; }));

                if (cmbQualities.Items.Count > 0)
                    if (cmbQualities.InvokeRequired)
                        cmbQualities.Invoke(new MethodInvoker(delegate { cmbQualities.Enabled = true; }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            updatingQualities = false;
        }


        /// <summary>
        /// /////////////////////////////////// CHECKING ONLINE STATUS
        /// </summary>

        public void checkFavoritesOnlineStatus()
        {
            checkingFavoritesOnlineStatus = true;

            if (btnCheckOnline.InvokeRequired)
                btnCheckOnline.Invoke(new MethodInvoker(delegate { btnCheckOnline.Enabled = false; }));

            int count = 0;
            if (imgCmbStreams.InvokeRequired)
                imgCmbStreams.Invoke(new MethodInvoker(delegate
                {
                    count = imgCmbStreams.Items.Count;
                }));

            if (statusStrip1.InvokeRequired)
                statusStrip1.Invoke(new MethodInvoker(delegate
                {
                    statusLabel.Text = "Checking online status for favourite streams...";
                    statusLabel.ForeColor = Color.Brown;

                    progressFavorites.Visible = true;

                    progressFavorites.Maximum = count;
                    progressFavorites.Value = 0;
                }));
            
            
            for (int i = 0; i < count; i++)
            {
                String streamUrl = listFavoriteStreams[i].StreamUrl;
                String[] parts = streamUrl.Split('/');
                String channel = parts[parts.Length - 1];

                String responseString = "";
                string url = "";

                if (streamUrl.ToLower().Contains("twitch"))
                    url = "https://api.justin.tv/api/stream/list.json?channel=" + channel;
                else if (streamUrl.ToLower().Contains("own3d"))
                    url = "http://api.own3d.tv/rest/live/list.json?liveid=" + channel;
                else
                {
                    // In case a url is unknown we mark it as offline

                    if (imgCmbStreams.InvokeRequired)
                        imgCmbStreams.Invoke(new MethodInvoker(delegate
                        {
                            DropDownItem item = (DropDownItem)imgCmbStreams.Items[i];
                            item.Image = DesktopLiveStreamer.Properties.Resources.OFF;

                            imgCmbStreams.Refresh();
                        }));

                    if (progressFavorites.InvokeRequired)
                        progressFavorites.Invoke(new MethodInvoker(delegate
                        {
                            progressFavorites.PerformStep();
                        }));

                    continue;
                }

                WebRequest request = WebRequest.Create(url);
                WebResponse ws = request.GetResponse();


                using (System.IO.Stream stream = ws.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    responseString = reader.ReadToEnd();
                }

                
                if (responseString.Contains(channel))
                {
                    if (imgCmbStreams.InvokeRequired)
                        imgCmbStreams.Invoke(new MethodInvoker(delegate
                        {
                            DropDownItem item = (DropDownItem)imgCmbStreams.Items[i];
                            item.Image = DesktopLiveStreamer.Properties.Resources.ON;

                            imgCmbStreams.Refresh();
                        }));
                }
                else
                {
                    if (imgCmbStreams.InvokeRequired)
                        imgCmbStreams.Invoke(new MethodInvoker(delegate
                        {
                            DropDownItem item = (DropDownItem)imgCmbStreams.Items[i];
                            item.Image = DesktopLiveStreamer.Properties.Resources.OFF;

                            imgCmbStreams.Refresh();
                        }));
                }

                if (progressFavorites.InvokeRequired)
                    progressFavorites.Invoke(new MethodInvoker(delegate
                    {
                        progressFavorites.PerformStep();
                    }));
            }


            if (statusStrip1.InvokeRequired)
                statusStrip1.Invoke(new MethodInvoker(delegate
                {
                    statusLabel.Text = "Ready";
                    statusLabel.ForeColor = Color.Black;

                    progressFavorites.Visible = false;
                }));

            if (btnCheckOnline.InvokeRequired)
                btnCheckOnline.Invoke(new MethodInvoker(delegate { btnCheckOnline.Enabled = true; }));

            checkingFavoritesOnlineStatus = false;
        }

        /// <summary>
        /// /////////////////////////////////// PLAYING LOOP
        /// </summary>

        private void playingLoop()
        {
            int index = 0;
            String url = "";
            String quality = "";
            String caption = "";
            bool live = true;
            Boolean error = false;

            if (groupLive.InvokeRequired)
                groupLive.Invoke(new MethodInvoker(delegate { live = groupLive.Enabled; }));

            if (live)
            {
                if (imgCmbLiveStreams.InvokeRequired)
                    imgCmbLiveStreams.Invoke(new MethodInvoker(delegate { index = imgCmbLiveStreams.SelectedIndex; }));

                if (cmbQualities.InvokeRequired)
                    cmbQualities.Invoke(new MethodInvoker(delegate { quality = (String)cmbQualities.SelectedItem; }));

            }
            else
            {
                if (imgCmbStreams.InvokeRequired)
                    imgCmbStreams.Invoke(new MethodInvoker(delegate { index = imgCmbStreams.SelectedIndex; }));
            }


            while (playing)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //startInfo.UseShellExecute = false;
                //startInfo.CreateNoWindow = true;
                //startInfo.RedirectStandardOutput = true;
                startInfo.FileName = XMLPersist.LiveStreamerExecutable;

                if (live)
                {
                    caption = listLiveStreams[index].Caption;
                    url = listLiveStreams[index].StreamUrl;
                }
                else
                {
                    caption = listFavoriteStreams[index].Caption;
                    url = listFavoriteStreams[index].StreamUrl;
                    quality = listFavoriteStreams[index].Quality;
                }
                    

                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Loading stream from '" + url + "' ...";
                        statusLabel.ForeColor = Color.Brown;

                        progressBar.Visible = true;
                    }));

                startInfo.Arguments = url + " " + quality + " --player=\"" + XMLPersist.VLCExecutable + "\""
                            + " --rtmpdump \"Livestreamer\\rtmpdump\\rtmpdump.exe\"";
                liveStreamerProcess = Process.Start(startInfo);

                //String streamerOutput = "";
                //int lineCount = 0;

                //liveStreamerProcess.BeginOutputReadLine();

                //liveStreamerProcess.OutputDataReceived += new DataReceivedEventHandler(liveStreamerProcess_OuputDataReceived);


                while (!liveStreamerProcess.HasExited)
                {
                    if (btnPlay.InvokeRequired)
                        btnPlay.Invoke(new MethodInvoker(delegate { btnPlay.Enabled = false; }));

                    if (btnStop.InvokeRequired)
                        btnStop.Invoke(new MethodInvoker(delegate { btnStop.Enabled = true; }));

                    //if (lineCount <= 2)
                    //{
                    //    //streamerOutput = liveStreamerProcess.StandardError.ReadLine();
                    //    lineCount++;
                    //}

                    //Console.WriteLine(streamerOutput);
                    //if (streamerOutput != null && streamerOutput.StartsWith("error"))
                    //{
                    //    streamerOutput = streamerOutput.Replace("error: ", "");
                    //    if (statusStrip1.InvokeRequired)
                    //        statusStrip1.Invoke(new MethodInvoker(delegate
                    //        {
                    //            progressBar.Visible = false;
                    //            statusLabel.Text = "Error: " + streamerOutput;
                    //            statusLabel.ForeColor = Color.Red;
                    //        }));

                    //    error = true;
                    //}
                    //else if (streamerOutput != null && streamerOutput.StartsWith("Invalid stream quality"))
                    //{
                    //    if (statusStrip1.InvokeRequired)
                    //        statusStrip1.Invoke(new MethodInvoker(delegate
                    //        {
                    //            progressBar.Visible = false;
                    //            statusLabel.Text = "Error: " + streamerOutput;
                    //            statusLabel.ForeColor = Color.Red;
                    //        }));

                    //    error = true;
                    //}

                    if ((VLCStreamProcess = getVLCStreamProcess()) != null)
                    {
                        if (!updatingLiveStreams && !updatingQualities && !checkingFavoritesOnlineStatus)
                        {
                            if (statusStrip1.InvokeRequired)
                                statusStrip1.Invoke(new MethodInvoker(delegate
                                {
                                    progressBar.Visible = false;
                                    statusLabel.Text = "Playing '" + caption.Substring(0, ((caption.Length > 64) ? 64 : caption.Length))
                                                                            .Replace("\n", "") + "' ...";
                                    statusLabel.ForeColor = Color.Green;
                                }));
                        }
                    }

                    Thread.Sleep(500);
                }

                if (VLCStreamProcess != null && !VLCStreamProcess.HasExited)
                    VLCStreamProcess.Kill();
                else
                    playing = false;
            }

            if (btnPlay.InvokeRequired)
                btnPlay.Invoke(new MethodInvoker(delegate { btnPlay.Enabled = true; }));

            if (btnStop.InvokeRequired)
                btnStop.Invoke(new MethodInvoker(delegate { btnStop.Enabled = false; }));

            if (statusStrip1.InvokeRequired)
                statusStrip1.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Visible = false;
                }));


            if (!error)
            {
                if (statusStrip1.InvokeRequired)
                    statusStrip1.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Ready";
                        statusLabel.ForeColor = Color.Black;
                    }));
            }
        }

        private void btnAddLiveStream_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listLiveStreams.getSize() + " " + imgCmbLiveStreams.Items.Count);
            int index = imgCmbLiveStreams.SelectedIndex;
            String caption = listLiveStreams[index].Caption;
            String url = listLiveStreams[index].StreamUrl;
            String quality = (String)cmbQualities.SelectedItem;

            FrmAdd frmAdd = new FrmAdd(listFavoriteStreams, caption, url, quality);

            if (frmAdd.ShowDialog() == DialogResult.OK)
                updateComboStreams();
        }

        private void btnCheckOnline_Click(object sender, EventArgs e)
        {
            Thread checkFavoritesOnlineStatusThread = new Thread(new ThreadStart(checkFavoritesOnlineStatus));
            checkFavoritesOnlineStatusThread.Start();
        }

        private void imgCmbLiveStreams_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!updatingLiveStreams)
            {
                if (qualityCheckProcess != null && !qualityCheckProcess.HasExited)
                    qualityCheckProcess.Kill();
                if (updateQualitiesThread != null)
                    updateQualitiesThread.Abort();
                updateQualitiesThread = new Thread(new ThreadStart(updateQualities));
                updateQualitiesThread.Start();
            }
        }

        private void imgCmbStreams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgCmbStreams.Items.Count == 0)
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                btnClone.Enabled = false;
            }
            else
            {
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                btnClone.Enabled = true;
            }
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            if (radioList1.Checked)
            {
                if (imgCmbStreams.Items.Count > 0)
                    Process.Start(listFavoriteStreams[imgCmbStreams.SelectedIndex].StreamUrl);
            }
            else
            {
                if (imgCmbLiveStreams.Items.Count > 0)
                    Process.Start(listLiveStreams[imgCmbLiveStreams.SelectedIndex].StreamUrl);
            }
        }
    }
}
