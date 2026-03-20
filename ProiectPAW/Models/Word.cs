using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectPAW
{
	[Serializable]
	public abstract class Word : IXmlExportable, ICloneable, IComparable
	{
		private long id;
		private string languageIsoCode;
		private string text;
		private string description;
		private Dictionary<string, List<long>> translations;
		private static long idGenerator;

		public long Id { get => id; }
		public string Text { get => text; }
		public string Description { get => description; }
		public string LanguageIsoCode { get => languageIsoCode; }
		public Dictionary<string, List<long>> Translations { get => translations; }

		private Word() { }

		public Word(string text, string languageIsoCode, string description)
		{
			this.id = Word.idGenerator++;
			this.text = text;
			this.languageIsoCode = languageIsoCode.ToUpper();
			this.description = description;
			this.translations = new Dictionary<string, List<long>>();
		}

		public static void calculateIdGenerator(List<Word> existingWords)
		{
			long maxId = 0;
			foreach (Word word in existingWords)
				maxId = Math.Max(maxId, word.id);

			Word.idGenerator = maxId + 1;
		}

		public Object Clone()
		{
			Word copy = (Word)this.MemberwiseClone();
			copy.translations = new Dictionary<string, List<long>>();
			foreach (KeyValuePair<string, List<long>> entry in this.translations)
				copy.translations.Add(entry.Key, new List<long>(entry.Value));

			return copy;
		}

		public int CompareTo(Object o)
		{
			if (o == null) return 1;

			if (!(o is Word))
				throw new ArgumentException("Object is not a Word");

			Word other = (Word)o;
			int result = this.text.CompareTo(other.text);
			if (result != 0)
				return result;

			return this.id.CompareTo(other.id);
		}

		public static Word operator +(Word a, Word b)
		{
			if(a.LanguageIsoCode != b.LanguageIsoCode)
			{
				a.AddTranslation(b);
				b.AddTranslation(a);
			}
			return a;
		}

		public void AddTranslation(Word other)
		{
			if (!this.Translations.ContainsKey(other.languageIsoCode))
				this.Translations.Add(other.LanguageIsoCode, new List<long>);
			this.Translations[other.LanguageIsoCode].Add(other.id);
		}


		protected virtual void WriteXmlAttributes(XmlTextWriter writer)
		{
			writer.WriteStartElement("Id");
			writer.WriteValue(this.id);
			writer.WriteEndElement();

			writer.WriteStartElement("LanguageIsoCode");
			writer.WriteValue(this.LanguageIsoCode);
			writer.WriteEndElement();

			writer.WriteStartElement("Text");
			writer.WriteValue(this.text);
			writer.WriteEndElement();

			writer.WriteStartElement("Description");
			writer.WriteValue(this.description);
			writer.WriteEndElement();

			if(this.Translations.Count > 0)
			{
				writer.WriteStartElement("Translations");

				foreach (KeyValuePair<String, List<long>> translation in this.Translations)
					foreach (long wordId in translation.Value)
					{
						writer.WriteStartElement("Translation");

						writer.WriteStartElement("IsoCode");
						writer.WriteValue(translation.Key);
						writer.WriteEndElement();

						writer.WriteStartElement("WordId");
						writer.WriteValue(wordId);
						writer.WriteEndElement();

						writer.WriteEndElement();
					}

				writer.WriteEndElement();
			}	
		}

		public abstract void WriteToXML(XmlTextWriter writer);
	}
}
