using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectPAW
{
	[Serializable]
	public class OtherWord : Word
	{
		string partOfSpeech;

		public OtherWord(string text, string languageIsoCode, string description, string partOfSpeech)
			: base(text, languageIsoCode, description)
		{
			this.partOfSpeech = partOfSpeech.ToLower();
		}

		protected override void WriteXmlAttributes(XmlTextWriter writer)
		{
			base.WriteXmlAttributes(writer);
			writer.WriteStartElement("PartOfSpeech");
			writer.WriteValue(this.partOfSpeech);
			writer.WriteEndElement();
		}
		public override void WriteToXML(XmlTextWriter writer)
		{
			writer.WriteStartElement("Other");
			this.WriteXmlAttributes(writer);
			writer.WriteEndElement();
		}

	}
}
