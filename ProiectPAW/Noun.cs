using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{

	[Serializable]
	public enum Gender
	{
		Masculine,
		Feminine,
		Neuter
	}

	[Serializable]
	public class Noun : Word
	{
		Gender gender;
		public Noun(string text, string languageIsoCode, string description, Gender gender)
			: base(text, languageIsoCode, description)
		{
			this.gender = gender;
		}

	}
}
