using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabz
{
    class Presenter
    {

        public List<T> RandomizeList<T>()
        {
            List<T> originalList = GetVokabelList();
            List<T> randomizedList = Shuffle(originalList);
            return randomizedList;
        }

        public List<T> GetVokabelList<T>()
        {
            List<T> vocabList = XMLSerializer.getList();
            return vocabList;
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
