using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

		protected override void WriteXmlAttributes(XmlTextWriter writer)
		{
			base.WriteXmlAttributes(writer);
			if(conjugations.Count > 0)
			{
				writer.WriteStartElement("Conjugations");

				foreach (VerbConjugation vc in this.conjugations)
					vc.WriteToXML(writer);

				writer.WriteEndElement();
			}
		}
		public override void WriteToXML(XmlTextWriter writer)
		{
			writer.WriteStartElement("Verb");
			this.WriteXmlAttributes(writer);
			writer.WriteEndElement();
		}
	}
}
