using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
	public partial class AddWordForm : Form
	{
		private AppData Data => AppData.Instance;
		private List<VerbConjugation> currConjugations = new List<VerbConjugation>();
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
			if (wordAddTabCtrl.SelectedTab == tabPageNoun)
				word = CreateNoun(text, languageIsoCode, description);
			else if (wordAddTabCtrl.SelectedTab == tabPageAdjective)
				word = CreateAdjective(text, languageIsoCode, description);
			else if (wordAddTabCtrl.SelectedTab == tabPageVerb)
				word = CreateVerb(text, languageIsoCode, description);
			else if (wordAddTabCtrl.SelectedTab == tabPageOther)
				word = CreateOther(text, languageIsoCode, description);

			if (word != null)
			{
				Data.AddWord(word);
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

		private Word CreateAdjective(string text, string languageIsoCode, string description)
		{
			if(varFormChck.Checked)
			{
				if(String.IsNullOrWhiteSpace(mascSngTb.Text))
				{
					wordErrorProvider.SetError(mascSngTb, "This field cannot be empty!");
					return null;
				}
				if (String.IsNullOrWhiteSpace(femSngTb.Text))
				{
					wordErrorProvider.SetError(femSngTb, "This field cannot be empty!");
					return null;
				}
				if (String.IsNullOrWhiteSpace(mascPlrTb.Text))
				{
					wordErrorProvider.SetError(mascPlrTb, "This field cannot be empty!");
					return null;
				}
				if (String.IsNullOrWhiteSpace(femPlrTb.Text))
				{
					wordErrorProvider.SetError(femPlrTb, "This field cannot be empty!");
					return null;
				}
			}

			bool hasVarForm = varFormChck.Checked;
			string[] varForms = null;
			if(hasVarForm)
				varForms = new string[] { mascSngTb.Text, femSngTb.Text, mascPlrTb.Text, femPlrTb.Text };

			Adjective adj = new Adjective(text, languageIsoCode, description, hasVarForm, varForms);
			return adj;
		}

		private Word CreateVerb(string text, string languageIsoCode, string description)
		{
			Verb verb = new Verb(text, languageIsoCode, description);
			foreach (VerbConjugation conjugation in this.currConjugations)
				verb.Conjugations.Add(conjugation);

			return verb;
		}

		private Word CreateOther(string text, string languageIsoCode, string description)
		{
			if(String.IsNullOrWhiteSpace(tbPartOfSpeech.Text))
				{
				wordErrorProvider.SetError(tbPartOfSpeech, "This field cannot be empty!");
				return null;
			}

			OtherWord otherWord = new OtherWord(text, languageIsoCode, description, tbPartOfSpeech.Text);
			return otherWord;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if(varFormChck.Checked)
			{
				mascSngTb.Enabled = true;
				femSngTb.Enabled = true;
				mascPlrTb.Enabled = true;
				femPlrTb.Enabled = true;
			} else
			{
				mascSngTb.Enabled = false;
				femSngTb.Enabled = false;
				mascPlrTb.Enabled = false;
				femPlrTb.Enabled = false;
			}
		}

		private void mascSngTb_TextChanged(object sender, EventArgs e)
		{
			wordTextTb.Text = mascSngTb.Text;
		}

		private void wordTextTb_TextChanged(object sender, EventArgs e)
		{
			if(wordAddTabCtrl.SelectedTab == tabPageAdjective)
			{
				mascSngTb.Text = wordTextTb.Text;
			}
		}

		private void wordAddTabCtrl_Selected(object sender, TabControlEventArgs e)
		{
			if (wordAddTabCtrl.SelectedTab == tabPageAdjective)
				mascSngTb.Text = wordTextTb.Text;
		}

		private void btnAddConjugation_Click(object sender, EventArgs e)
		{
			AddConjugationForm acf = new AddConjugationForm(this.currConjugations);
			acf.ShowDialog();

			lvConjugations.Clear();
			foreach(VerbConjugation conjugation in this.currConjugations)
			{
				ListViewItem lvt = new ListViewItem(conjugation.Mood);
				lvt.SubItems.Add(conjugation.Tense);

				lvConjugations.Items.Add(lvt);
			}	
			
		}
	}
}
