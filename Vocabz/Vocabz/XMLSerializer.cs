using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Vocabz
{
	public class XMLSerializer
	{
		private static Random rnd = new Random();
		public static List<Vokabel> ReadFromFile()
		{
			List<Vokabel> myList = new List<Vokabel>();
			var serializer = new XmlSerializer(typeof(List<Vokabel>));
			var fileStream = new FileStream("Vokabelliste.xml", FileMode.Open);
			var textReader = new XmlTextReader(fileStream);
			var Vokabelliste = (List<Vokabel>)serializer.Deserialize(textReader);
			textReader.Close();
			fileStream.Close();
			fileStream.Dispose();
			return AddWrong(Vokabelliste);
		}

		private static List<Vokabel> AddWrong(List<Vokabel> Vokabelliste)
		{
			foreach (Vokabel vokabel in Vokabelliste)
			{
				vokabel.Falsch[0] = Vokabelliste[rnd.Next(Vokabelliste.Count)].Fremdsprache;
				vokabel.Falsch[1] = Vokabelliste[rnd.Next(Vokabelliste.Count)].Fremdsprache;
				vokabel.Falsch[2] = Vokabelliste[rnd.Next(Vokabelliste.Count)].Fremdsprache;
			}
			return Vokabelliste;
		}
	}
}
