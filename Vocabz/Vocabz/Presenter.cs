using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabz
{
    class Presenter
    {
        //test List



        //Work in Progress

        public List<Vokabel> RandomizeList<T>()
        {
            List<Vokabel> originalList = XMLSerializer.ReadFromFile();
            List<Vokabel> randomizedList = Shuffle(originalList);
            return randomizedList;
        }

        private static Random rng = new Random();

        public static List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

    }
}
