using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
	[Serializable]
	public class VerbConjugation
	{
		private string mood;
		private string tense;
		private string[] conjugations;

		public string Mood { get => this.mood; }
		public string Tense { get => this.tense; }

		public VerbConjugation(string mood, string tense, string[] conjugations)
		{
			this.mood = mood;
			this.tense = tense;
			this.conjugations = (string[])conjugations.Clone();
		}
	}
}
