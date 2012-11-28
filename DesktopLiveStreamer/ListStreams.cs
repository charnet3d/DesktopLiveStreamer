using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DesktopLiveStreamer
{
    public class ListStreams
    {
        private List<Stream> listStreams;
        
        public ListStreams()
        {
            listStreams = new List<Stream>();
        }

        public void add(Stream p)
        {
            listStreams.Add(p);
        }

        public void sort()
        {
            Stream.StreamComparer comparer = new Stream.StreamComparer(Stream.StreamComparer.ComparisonType.Caption);
            listStreams.Sort(comparer);
        }

        public void sortByViewers()
        {
            Stream.StreamComparer comparer = new Stream.StreamComparer(Stream.StreamComparer.ComparisonType.Viewers);
            listStreams.Sort(comparer);
        }

        public void clear()
        {
            listStreams.Clear();
        }

        public int getSize()
        {
            return listStreams.Count;
        }

        public void remove(int index)
        {
            listStreams.RemoveAt(index);
        }

        public Stream this[int i]
        {
            get { return (Stream)listStreams[i]; }
        }
    }
}
