using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Vocabz
{
	public class XMLSerializer
	{
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
			return Vokabelliste;
		}
	}
}
