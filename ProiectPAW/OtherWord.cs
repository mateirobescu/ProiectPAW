using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
	[Serializable]
	public class OtherWord : Word
	{
		string partOfSpeech;

		public OtherWord(string text, string languageIsoCode, string description, string partOfSpeech)
			: base(text, languageIsoCode, description)
		{
			this.partOfSpeech = partOfSpeech;
		}
	}
}
