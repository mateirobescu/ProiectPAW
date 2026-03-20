using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProiectPAW
{
	[Serializable]
	public class AppData
	{
		private List<Word> allWords = new List<Word>();
		private List<Language> allLanguages = new List<Language>();

		private static AppData _instance;
		public static AppData Instance
		{
			get
			{
				if (_instance == null) 
					_instance = new AppData();
				return _instance;
			}

			set => _instance = value;
		}

		public List<Word> AllWords { get => this.allWords; }
		public List<Language> AllLanguages { get => this.allLanguages; }

		private AppData() { }

		public override string ToString()
		{
			return String.Join(" ", this.AllLanguages) + Environment.NewLine + String.Join(" ", this.AllWords);
		}

		public void saveToBinary(AppData appData, string fileName)
		{
			try
			{
				using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(fs, appData);
				}
			}
			catch(IOException exc)
			{
				Console.WriteLine(exc.Message);
			}

		}

		public void LoadFromBinary(string fileName)
		{
			try
			{
				using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))

				{
					BinaryFormatter bf = new BinaryFormatter();
					AppData.Instance = (AppData)bf.Deserialize(fs);
					Word.calculateIdGenerator(AppData.Instance.allWords);
				}
			}
			catch (IOException exc)
			{
				Console.WriteLine(exc.Message);
			}
			
		}

		public Word this[int index]
		{
			get
			{
				return this.AllWords[index];
			}

			set
			{
				this.AllWords[index] = value;
			}
		}

		public Language this[string isoCode]
		{
			get 
			{
				return this.AllLanguages.Find(lang => lang.IsoCode.Equals(isoCode));	
			}
			
			set
			{
				int index = this.AllLanguages.FindIndex(lang => lang.IsoCode.Equals(isoCode));
				if (index == -1)
					this.AllLanguages.Add(value);
				else
					this.AllLanguages[index] = value;
			}
		}

		public void ExportToXML(string filename)
		{
			MemoryStream ms = new MemoryStream();
			XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8);
			writer.Formatting = Formatting.Indented;

			writer.WriteStartDocument();

			writer.WriteStartElement("Dictionary", "http://tempuri.org/schema.xsd");
			writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
			writer.WriteAttributeString("xsi", "schemaLocation", null, "http://tempuri.org/schema.xsd schema.xsd");

			writer.WriteStartElement("Languages");

			foreach (Language lang in this.AllLanguages)
				lang.WriteToXML(writer);

			writer.WriteEndElement();

			writer.WriteStartElement("Words");

			foreach (Word word in this.AllWords)
				word.WriteToXML(writer);


			writer.WriteEndElement();

			writer.WriteEndDocument();

			writer.Close();

			ms.Close();
			string xml = Encoding.UTF8.GetString(ms.ToArray());

			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.WriteLine(xml);
			}

		}
	}
}
