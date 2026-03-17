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
	public partial class AddWordForm : Form
	{
		private AppData Data => AppData.Instance;
		public AddWordForm()
		{
			InitializeComponent();
		}

		private void AddWordForm_Load(object sender, EventArgs e)
		{
			List<Language> displayList = new List<Language>();
			displayList.Add(new Language("", "---Select a Langauge---"));
			displayList.AddRange(Data.AllLanguages);

			languageCb.DataSource = displayList;
			languageCb.DisplayMember = "DefaultName";
			languageCb.ValueMember = "IsoCode";
		}

		private void addWordBtn_Click(object sender, EventArgs e)
		{
			wordErrorProvider.Clear();
			if (String.IsNullOrWhiteSpace(wordTextTb.Text))
			{
				wordErrorProvider.SetError(wordTextTb, "The word text cannot be empty!");
				return;
			}

			if(String.IsNullOrEmpty(languageCb.SelectedValue.ToString()))
			{
				wordErrorProvider.SetError(languageCb, "You have to select a language");
				return;
			}
			

			if (string.IsNullOrWhiteSpace(descriptionRtb.Text))
			{
				wordErrorProvider.SetError(descriptionRtb, "Description cannot be empty!");
				return; // Oprim metoda Save aici
			}

			string text = wordTextTb.Text;
			string languageIsoCode = languageCb.SelectedValue.ToString();
			string description = descriptionRtb.Text;
			Word word = null;
			if (wordAddTabCtrl.SelectedTab == nounTabPage)
				word = CreateNoun(text, languageIsoCode, description);
			
			if(word != null)
			{
				Data.AllWords.Add(word);
				this.DialogResult = DialogResult.OK;
				this.Close();
			}

		}

		private Word CreateNoun(string text, string languageIsoCode, string description)
		{
			if (!masculineRbtn.Checked && !feminineRbtn.Checked && !neuterRbtn.Checked)
			{
				wordErrorProvider.SetError(masculineRbtn, "You have to choose a gender!");
				wordErrorProvider.SetError(feminineRbtn, "You have to choose a gender!");
				wordErrorProvider.SetError(neuterRbtn, "You have to choose a gender!");
				return null;
			}

			Gender gender = Gender.Neuter;
			if (masculineRbtn.Checked)
				gender = Gender.Masculine;
			else if (feminineRbtn.Checked)
				gender = Gender.Feminine;

			Noun noun = new Noun(text, languageIsoCode, description, gender);
			return noun;
		}
	}
}
