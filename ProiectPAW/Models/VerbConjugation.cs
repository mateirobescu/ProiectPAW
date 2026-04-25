using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectPAW
{
	[Serializable]
	public class VerbConjugation : IXmlExportable, ICloneable, IComparable
	{
		private string mood;
		private string tense;
		private string[] conjugations;

		public string Mood { get => this.mood; }
		public string Tense { get => this.tense; }

		public VerbConjugation(string mood, string tense, string[] conjugations)
		{
			this.mood = mood.ToLower();
			this.tense = tense.ToLower();
			this.conjugations = (string[])conjugations.Clone();
			for (int i = 0; i < conjugations.Length; i++)
				conjugations[i] = conjugations[i].ToLower();
		}

		public void WriteToXML(XmlTextWriter writer)
		{
			writer.WriteStartElement("Conjugation");

				writer.WriteStartElement("Mood");
				writer.WriteValue(this.Mood);
				writer.WriteEndElement();

				writer.WriteStartElement("Tense");
				writer.WriteValue(this.Tense);
				writer.WriteEndElement();

				if (!String.IsNullOrWhiteSpace(this.conjugations[0]))
				{
					writer.WriteStartElement("SG1");
					writer.WriteValue(this.conjugations[0]);
					writer.WriteEndElement();
				}

				if (!String.IsNullOrWhiteSpace(this.conjugations[1]))
				{
					writer.WriteStartElement("SG2");
					writer.WriteValue(this.conjugations[1]);
					writer.WriteEndElement();
				}

				if (!String.IsNullOrWhiteSpace(this.conjugations[2]))
				{
					writer.WriteStartElement("SG3");
					writer.WriteValue(this.conjugations[2]);
					writer.WriteEndElement();
				}

				if (!String.IsNullOrWhiteSpace(this.conjugations[3]))
				{
					writer.WriteStartElement("PL1");
					writer.WriteValue(this.conjugations[3]);
					writer.WriteEndElement();
				}

				if (!String.IsNullOrWhiteSpace(this.conjugations[4]))
				{
					writer.WriteStartElement("PL2");
					writer.WriteValue(this.conjugations[4]);
					writer.WriteEndElement();
				}

				if (!String.IsNullOrWhiteSpace(this.conjugations[5]))
				{
					writer.WriteStartElement("PL3");
					writer.WriteValue(this.conjugations[5]);
					writer.WriteEndElement();
				}

			writer.WriteEndElement();
		}

		public object Clone()
		{
			VerbConjugation vc = (VerbConjugation)this.MemberwiseClone();
			vc.conjugations = (string[])this.conjugations.Clone();
			return vc;
		}

		public int CompareTo(object obj)
		{
			if (obj == null)
				return 1;
			if (!(obj is VerbConjugation))
				throw new ArgumentException("The object is not a VerbConjugation!");

			VerbConjugation other = (VerbConjugation)obj;

			return this.conjugations.Length.CompareTo(other.conjugations.Length);
		}
	}
}
