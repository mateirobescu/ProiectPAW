using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
		public Gender Gender
		{
			get => this.gender;
		}
		public Noun(string text, string languageIsoCode, string description, Gender gender)
			: base(text, languageIsoCode, description)
		{
			this.gender = gender;
		}

		protected override void WriteXmlAttributes(XmlTextWriter writer)
		{
			base.WriteXmlAttributes(writer);
			writer.WriteStartElement("Gender");
			writer.WriteValue((int)this.gender);
			writer.WriteEndElement();
		}
		public override void WriteToXML(XmlTextWriter writer)
		{
			writer.WriteStartElement("Noun");
			this.WriteXmlAttributes(writer);
			writer.WriteEndElement();
		}
	}
}
