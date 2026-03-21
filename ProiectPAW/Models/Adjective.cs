using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectPAW
{
	[Serializable]
	enum AdjectiveForm
	{
		MS,
		FS,
		MP,
		FP
	}

	[Serializable]
	public class Adjective : Word
	{
		private bool hasVariableForm;
		private Dictionary<AdjectiveForm, string> forms;

		public Adjective(string text, string languageIsoCode, string description, bool hasVariableForm, string[] formsArr)
			: base(text, languageIsoCode, description)
		{
			this.hasVariableForm = hasVariableForm;
			if(hasVariableForm && formsArr != null)
				this.forms = new Dictionary<AdjectiveForm, string>
				{
					[AdjectiveForm.MS] = formsArr[0].ToLower(),
					[AdjectiveForm.FS] = formsArr[1].ToLower(),
					[AdjectiveForm.MP] = formsArr[2].ToLower(),
					[AdjectiveForm.FP] = formsArr[3].ToLower()
				};
		}

		protected override void WriteXmlAttributes(XmlTextWriter writer)
		{
			base.WriteXmlAttributes(writer);
			writer.WriteStartElement("HasVariableForm");
			writer.WriteValue(this.hasVariableForm);
			writer.WriteEndElement();
			
			if(this.hasVariableForm)
			{
				writer.WriteStartElement("Forms");

					writer.WriteStartElement("MS");
					writer.WriteValue(this.forms[AdjectiveForm.MS]);
					writer.WriteEndElement();

					writer.WriteStartElement("MP");
					writer.WriteValue(this.forms[AdjectiveForm.MP]);
					writer.WriteEndElement();

					writer.WriteStartElement("FS");
					writer.WriteValue(this.forms[AdjectiveForm.FS]);
					writer.WriteEndElement();

					writer.WriteStartElement("FP");
					writer.WriteValue(this.forms[AdjectiveForm.FP]);
					writer.WriteEndElement();

				writer.WriteEndElement();
			}

		}
		public override void WriteToXML(XmlTextWriter writer)
		{
			writer.WriteStartElement("Adjective");
			this.WriteXmlAttributes(writer);
			writer.WriteEndElement();
		}
	}
}
