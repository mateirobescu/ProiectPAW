using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
	//internal abstract class Word
	internal class Word
	{
		private Guid id;
		private string languageIsoCode;
		private string text;
		private string description;
		private Dictionary<string, List<Guid>> translations;

		public string Id { get => id.ToString(); }
		public string Text { get => text; }
		public string Description { get => description; }
		public string LanguageIsoCode { get => languageIsoCode; }
		public Dictionary<string, List<Guid>> Translations { get => translations; }

		private Word() { }

		public Word(string text, string languageIsoCode, string description)
		{
			this.id = Guid.NewGuid();
			this.text = text;
			this.languageIsoCode = languageIsoCode.ToUpper();
			this.description = description;
		}

	}
}
