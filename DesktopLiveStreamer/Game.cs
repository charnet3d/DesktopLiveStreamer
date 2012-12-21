using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopLiveStreamer
{
    class Game
    {
        public String Caption { get; set; }
        public String TwitchGameID { get; set; }
        public String Own3DGameID { get; set; }
        public String Viewers { get; set; }

        public Game()
        {
            Caption = "";
            TwitchGameID = "";
            Own3DGameID = "";
            Viewers = "";
        }
        
        public Game(String c, String tid, String oid, String v)
        {
            Caption = c;
            TwitchGameID = tid;
            Own3DGameID = oid;
            Viewers = v;
        }

        public int compareTo(Game s, GameComparer.ComparisonType comparisonMethod)
        {
            switch (comparisonMethod)
            {
                case GameComparer.ComparisonType.Caption:
                    return String.Compare(Caption, s.Caption);
                case GameComparer.ComparisonType.Viewers:
                    if (Viewers != "" && s.Viewers != "")
                        return Convert.ToUInt64(s.Viewers).CompareTo(Convert.ToUInt64(Viewers));
                    else if (Viewers == "" && s.Viewers != "")
                        return 1;
                    else if (s.Viewers == "" && Viewers != "")
                        return -1;
                    else
                        return Caption.CompareTo(s.Caption);

                default:
                    return Caption.CompareTo(s.Caption);
            }
        }

        public override String ToString()
        {
            return Viewers + " - " + Caption;
        }


        public class GameComparer : IComparer<Game>
        {
            public enum ComparisonType
            { Caption = 1, Viewers = 2 }

            private ComparisonType _comparisonType;

            public ComparisonType ComparisonMethod
            {
                get { return _comparisonType; }
                set { _comparisonType = value; }
            }

            public GameComparer(ComparisonType comparisonMethod)
            {
                _comparisonType = comparisonMethod;
            }

            public int Compare(Game x, Game y)
            {
                Game s1;
                Game s2;

                if (x is Game)
                    s1 = (Game)x;
                else
                    throw new ArgumentException("Object is not of type Stream");

                if (y is Game)
                    s2 = (Game)y;
                else
                    throw new ArgumentException("Object is not of type Stream");

                return s1.compareTo(s2, ComparisonMethod);
            }
        }
    }
}
