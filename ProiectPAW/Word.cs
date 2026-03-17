using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
	[Serializable]
	public abstract class Word
	{
		private long id;
		private string languageIsoCode;
		private string text;
		private string description;
		private Dictionary<string, List<long>> translations;
		private static long idGenerator;

		public string Id { get => id.ToString(); }
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

		public override string ToString()
		{
			//return String.Format("Word[{0}, {1}]")
			throw new NotImplementedException();
		}

		public static void calculateIdGenerator(List<Word> existingWords)
		{
			long maxId = 0;
			foreach (Word word in existingWords)
				maxId = Math.Max(maxId, word.id);

			Word.idGenerator = maxId + 1;
		}

	}
}
