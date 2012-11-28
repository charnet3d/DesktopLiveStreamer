using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DesktopLiveStreamer
{
    class XMLPersist
    {
        public static String LiveStreamerExecutable;
        public static String VLCExecutable;

        public static String XMLFile;

        public static void loadStreamListConfig(ListStreams list)
        {
            XmlTextReader xr = null;
            int attributs_lus;
            Stream tmpStream = null;
            try
            {
                xr = new XmlTextReader(XMLFile);

                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "Stream")
                    {
                        tmpStream = new Stream();
                        attributs_lus = 0;
                        while (xr.Read())
                        {
                            // Lecture des attributs de personne
                            if (xr.NodeType == XmlNodeType.Element && xr.Name == "Caption")
                            {
                                xr.Read();
                                tmpStream.Caption = xr.Value;
                                attributs_lus++;
                            }
                            else if (xr.NodeType == XmlNodeType.Element && xr.Name == "URL")
                            {
                                xr.Read();
                                tmpStream.StreamUrl = xr.Value;
                                attributs_lus++;
                            }
                            else if (xr.NodeType == XmlNodeType.Element && xr.Name == "Quality")
                            {
                                xr.Read();
                                tmpStream.Quality = xr.Value;
                                attributs_lus++;
                            }

                            // Sortie de while quand tous les attributs on été lu
                            if (attributs_lus == 3)
                            {
                                list.add(tmpStream);
                                break;
                            }

                        }
                    }
                    else if (xr.NodeType == XmlNodeType.Element && xr.Name == "LiveStreamerExecutable")
                    {
                        xr.Read();
                        LiveStreamerExecutable = xr.Value;
                    }
                    else if (xr.NodeType == XmlNodeType.Element && xr.Name == "VLCExecutable")
                    {
                        xr.Read();
                        VLCExecutable = xr.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                xr.Close();
            }
        }

        public static void saveStreamListConfig(ListStreams list)
        {
            XmlTextWriter xw = null;
            Stream tmpStream = null;
            try
            {
                xw = new XmlTextWriter(XMLFile, Encoding.UTF8);
                xw.Formatting = Formatting.Indented;

                xw.WriteStartDocument(true);

                xw.WriteStartElement("DesktopLiveStreamer");

                // Le parametre de chemin du livestreamer
                xw.WriteElementString("LiveStreamerExecutable", LiveStreamerExecutable);

                // Le parametre de chemin de VLC
                xw.WriteElementString("VLCExecutable", VLCExecutable);

                Console.WriteLine(VLCExecutable);

                for (int i = 0; i < list.getSize(); i++)
                {
                    tmpStream = list[i];

                    xw.WriteStartElement("Stream");
                    xw.WriteElementString("Caption", tmpStream.Caption);
                    xw.WriteElementString("URL", tmpStream.StreamUrl);
                    xw.WriteElementString("Quality", tmpStream.Quality);
                    xw.WriteEndElement();
                }

                xw.WriteEndElement();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                xw.Close();
            }
        }
    }
}
