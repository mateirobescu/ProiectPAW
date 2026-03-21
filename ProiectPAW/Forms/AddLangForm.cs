using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
	public partial class AddLangForm : Form
	{
		private AppData Data => AppData.Instance;

		public AddLangForm()
		{
			InitializeComponent();
		}

		private void AddLangForm_Load(object sender, EventArgs e)
		{

		}

		private void addLangBtn_Click(object sender, EventArgs e)
		{
			langErrorProvider.Clear();

			if (String.IsNullOrWhiteSpace(iso2CodeTb.Text))
			{
				langErrorProvider.SetError(iso2CodeTb, "This should not be empty!");
				return;
			}

			if (iso2CodeTb.Text.Length != 2)
			{
				langErrorProvider.SetError(iso2CodeTb, "The ISO code should have 2 characters!");
				return;
			}

			if (String.IsNullOrWhiteSpace(langNameTb.Text))
			{
				langErrorProvider.SetError(langNameTb, "This should not be empty!");
				return;
			}

			iso2CodeTb.Text = iso2CodeTb.Text.ToUpper();

			foreach(Language lang in this.Data.AllLanguages)
				if(iso2CodeTb.Text.Equals(lang.IsoCode))
				{
					langErrorProvider.SetError(iso2CodeTb, "This language already exists!");
					return;
				}

			Language newLang = new Language(iso2CodeTb.Text, langNameTb.Text);
			this.Data.AddLanguage(newLang);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
