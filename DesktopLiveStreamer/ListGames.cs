using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopLiveStreamer
{
    class ListGames
    {
        private List<Game> listGames;

        public ListGames()
        {
            listGames = new List<Game>();
        }

        public void add(Game p)
        {
            listGames.Add(p);
        }

        public void sort()
        {
            Game.GameComparer comparer = new Game.GameComparer(Game.GameComparer.ComparisonType.Caption);
            listGames.Sort(comparer);
        }

        public void sortByViewers()
        {
            Game.GameComparer comparer = new Game.GameComparer(Game.GameComparer.ComparisonType.Viewers);
            listGames.Sort(comparer);
        }

        public int find(String caption)
        {
            for (int i = 0; i < listGames.Count; i++)
            {
                if (listGames[i].Caption == caption)
                    return i;
            }

            return -1;
        }

        public void clear()
        {
            listGames.Clear();
        }

        public int getSize()
        {
            return listGames.Count;
        }

        public void remove(int index)
        {
            listGames.RemoveAt(index);
        }

        public Game this[int i]
        {
            get { return (Game)listGames[i]; }
        }
    }
}
