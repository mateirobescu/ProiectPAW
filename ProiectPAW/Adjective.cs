using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
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
					[AdjectiveForm.MS] = formsArr[0],
					[AdjectiveForm.FS] = formsArr[1],
					[AdjectiveForm.MP] = formsArr[2],
					[AdjectiveForm.FP] = formsArr[3]
				};
		}

	}
}
