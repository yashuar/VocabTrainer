using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vocabz
{
    class Presenter
    {
        public static String Deutsch { get; set; }
        public static String Uebersetzung { get; set; }
        public static String Falsch1 { get; set; }
        public static String Falsch2 { get; set; }
        public static String Falsch3 { get; set; }


        public static IEnumerable<Vokabel> ReturnVokabel()
        {
            IEnumerable<Vokabel> randomizedList = RandomizeList();

            foreach (Vokabel vokabel in randomizedList)
            {
                yield return vokabel;
            }
        }

        public static void ChangeFields()
        {
            Vokabel vokabel = (Vokabel) ReturnVokabel();
            Deutsch = vokabel.Deutsch;
            Uebersetzung = vokabel.Fremdsprache;
            Falsch1 = vokabel.Falsch[1];
            Falsch2 = vokabel.Falsch[2];
            Falsch3 = vokabel.Falsch[3];
        }

        public static IEnumerable<Vokabel> RandomizeList()
        {
            IEnumerable<Vokabel> originalList = XMLSerializer.ReadFromFile();
            IEnumerable<Vokabel> randomizedList = Shuffle(originalList);
            return randomizedList;
        }

        private static Random rng = new Random();

        public static IEnumerable<Vokabel> Shuffle<Vokabel>(IEnumerable<Vokabel> list)
        {
            List<Vokabel> tmpList = (List<Vokabel>)list;
            int n = list.Count();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Vokabel value = tmpList[k];
                tmpList[k] = tmpList[n];
                tmpList[n] = value;
            }
            return (IEnumerable<Vokabel>)tmpList;
        }

    }
}
