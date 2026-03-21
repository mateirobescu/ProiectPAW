using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectPAW
{
	[Serializable]
	public class Language : IXmlExportable
	{
		private string isoCode;
		private string name;

		public string IsoCode { get => isoCode; set => isoCode = value; }
		public string Name { get => name; set => name = value; }

		public string CapName { get => char.ToUpper(name[0]) + name.Substring(1); }

		private Language() { }

		public Language(string isoCode, string name)
		{
			this.isoCode = isoCode.ToUpper();
			this.name = name.ToLower();
		}

		override public string ToString()
		{
			return String.Format("Languge[{0}, {1}]", this.isoCode, this.name);
		}

		public static explicit operator string(Language lang)
		{
			return lang.IsoCode;
		}

		public void WriteToXML(XmlTextWriter writer)
		{
			writer.WriteStartElement("Language");

			writer.WriteStartElement("Iso2Code");
			writer.WriteValue(this.IsoCode);
			writer.WriteEndElement();

			writer.WriteStartElement("Name");
			writer.WriteValue(this.Name);
			writer.WriteEndElement();

			writer.WriteEndElement();
		}

	}
}
