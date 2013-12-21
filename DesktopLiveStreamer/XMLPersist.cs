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
        public static String PreferedQuality;
        public static String DefaultGame;

        public static String StreamXMLFile;
        public static String GameXMLFile;

        public static void loadStreamListConfig(ListStreams list)
        {
            XmlTextReader xr = null;
            int attributs_lus;
            Stream tmpStream = null;
            try
            {
                xr = new XmlTextReader(StreamXMLFile);

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
                                tmpStream.Caption = xr.Value.Trim();
                                attributs_lus++;
                            }
                            else if (xr.NodeType == XmlNodeType.Element && xr.Name == "URL")
                            {
                                xr.Read();
                                tmpStream.StreamUrl = xr.Value.Trim();
                                attributs_lus++;
                            }
                            else if (xr.NodeType == XmlNodeType.Element && xr.Name == "Quality")
                            {
                                xr.Read();
                                tmpStream.Quality = xr.Value.Trim();
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
                        LiveStreamerExecutable = xr.Value.Trim();
                    }
                    else if (xr.NodeType == XmlNodeType.Element && xr.Name == "VLCExecutable")
                    {
                        xr.Read();
                        VLCExecutable = xr.Value.Trim();
                    }
                    else if (xr.NodeType == XmlNodeType.Element && xr.Name == "PreferedQuality")
                    {
                        xr.Read();
                        PreferedQuality = xr.Value.Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (xr != null)
                    xr.Close();
            }
        }

        public static void saveStreamListConfig(ListStreams list)
        {
            XmlTextWriter xw = null;
            Stream tmpStream = null;
            try
            {
                xw = new XmlTextWriter(StreamXMLFile, Encoding.UTF8);
                xw.Formatting = Formatting.Indented;

                xw.WriteStartDocument(true);

                xw.WriteStartElement("DesktopLiveStreamer");

                // Le parametre de chemin du livestreamer
                xw.WriteElementString("LiveStreamerExecutable", LiveStreamerExecutable);

                // Le parametre de chemin de VLC
                xw.WriteElementString("VLCExecutable", VLCExecutable);

                // Le parametre de la qualité préferée
                xw.WriteElementString("PreferedQuality", PreferedQuality);

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
                if (xw != null)
                    xw.Close();
            }
        }

        public static void loadGameListConfig(ListGames list)
        {
            XmlTextReader xr = null;
            int attributs_lus;
            Game tmpGame = null;
            try
            {
                xr = new XmlTextReader(GameXMLFile);

                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "Game")
                    {
                        tmpGame = new Game();
                        attributs_lus = 0;
                        while (xr.Read())
                        {
                            // Lecture des attributs d'une game
                            if (xr.NodeType == XmlNodeType.Element && xr.Name == "Caption")
                            {
                                xr.Read();
                                tmpGame.Caption = xr.Value.Trim();
                                attributs_lus++;
                            }
                            else if (xr.NodeType == XmlNodeType.Element && xr.Name == "Twitch_ID")
                            {
                                xr.Read();
                                tmpGame.TwitchGameID = xr.Value.Trim();
                                attributs_lus++;
                            }
                            else if (xr.NodeType == XmlNodeType.Element && xr.Name == "Own3D_ID")
                            {
                                xr.Read();
                                tmpGame.Own3DGameID = xr.Value.Trim();
                                attributs_lus++;
                            }

                            // Sortie de while quand tous les attributs on été lu
                            if (attributs_lus == 3)
                            {
                                list.add(tmpGame);
                                break;
                            }

                        }
                    }
                    else if (xr.NodeType == XmlNodeType.Element && xr.Name == "DefaultGame")
                    {
                        xr.Read();
                        DefaultGame = xr.Value.Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (xr != null)
                    xr.Close();
            }
        }


        public static void saveGameListConfig(ListGames list)
        {
            XmlTextWriter xw = null;
            Game tmpGame = null;
            try
            {
                xw = new XmlTextWriter(GameXMLFile, Encoding.UTF8);
                xw.Formatting = Formatting.Indented;

                xw.WriteStartDocument(true);

                xw.WriteStartElement("DesktopLiveStreamer");

                // Le parametre du jeu par défaut
                xw.WriteElementString("DefaultGame", DefaultGame);


                for (int i = 0; i < list.getSize(); i++)
                {
                    tmpGame = list[i];

                    xw.WriteStartElement("Game");
                    xw.WriteElementString("Caption", tmpGame.Caption);
                    xw.WriteElementString("Twitch_ID", tmpGame.TwitchGameID);
                    xw.WriteElementString("Own3D_ID", tmpGame.Own3DGameID);
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
                if (xw != null)
                    xw.Close();
            }
        }
    }
}
