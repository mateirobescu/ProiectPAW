using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
	[Serializable]
	public class Verb : Word
	{
		private List<VerbConjugation> conjugations;
		
		public List<VerbConjugation> Conjugations  {
			get => this.conjugations;
		}

		public Verb(string text, string languageIsoCode, string description)
			: base(text, languageIsoCode, description)
		{
			this.conjugations = new List<VerbConjugation>();
		}
	}
}
