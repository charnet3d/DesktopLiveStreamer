using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopLiveStreamer
{
    public class Stream
    {
        public String Caption { get; set; }
        public String StreamUrl { get; set; }
        public String Quality { get; set; }
        public long Viewers { get; set; }
        public String Host { get; set; }
        public String Channel { get; set; }
        public String displayName { get; set; }

        public Stream()
        {
            Caption = "";
            StreamUrl = "";
            Quality = "";
        }

        public Stream(String c, String url, String q)
        {
            Caption = c;
            StreamUrl = url;
            Quality = q;
        }

        public Stream(String c, String url, long v, String h, String ch)
        {
            Caption = c;
            StreamUrl = url;
            Viewers = v;
            Host = h;
            Channel = ch;
        }

        public int compareTo(Stream s, StreamComparer.ComparisonType comparisonMethod)
        {
            switch (comparisonMethod)
            {
                case StreamComparer.ComparisonType.Caption:
                    return String.Compare(Caption, s.Caption);
                case StreamComparer.ComparisonType.Viewers:
                    return s.Viewers.CompareTo(Viewers);

                default:
                    return Caption.CompareTo(s.Caption);
            }
        }

        public override String ToString()
        {
            return displayName + "(" + String.Format("{0:#,##0}", Viewers) + ") - " + Caption;
        }


        public class StreamComparer : IComparer<Stream>
        {
            public enum ComparisonType
            { Caption = 1, Viewers = 2 }

            private ComparisonType _comparisonType;

            public ComparisonType ComparisonMethod
            {
                get { return _comparisonType; }
                set { _comparisonType = value; }
            }

            public StreamComparer(ComparisonType comparisonMethod)
            {
                _comparisonType = comparisonMethod;
            }

            public int Compare(Stream x, Stream y)
            {
                Stream s1;
                Stream s2;

                if (x is Stream)
                    s1 = (Stream)x;
                else
                    throw new ArgumentException("Object is not of type Stream");

                if (y is Stream)
                    s2 = (Stream)y;
                else
                    throw new ArgumentException("Object is not of type Stream");

                return s1.compareTo(s2, ComparisonMethod);
            }
        }
    }
}
