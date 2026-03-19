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
	public partial class AddConjugationForm : Form
	{
		private List<VerbConjugation> allCongjugations;
		public AddConjugationForm(List<VerbConjugation> allCongjugations)
		{
			InitializeComponent();
			this.allCongjugations = allCongjugations;
		}

		private void btAddConjugation_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(String.IsNullOrWhiteSpace(tbMood.Text))
			{
				errorProvider1.SetError(tbMood, "The conjugation has to have a mood!");
				return;
			}
			if (String.IsNullOrWhiteSpace(tbTense.Text))
			{
				errorProvider1.SetError(tbTense, "The conjugation has to have a mood!");
				return;
			}

			string[] forms = new string[] { tb1Sg.Text, tb2Sg.Text, tb3Sg.Text, tb1Pl.Text, tb2Pl.Text, tb3Pl.Text };
			if(forms.All(s => String.IsNullOrWhiteSpace(s)))
			{
				errorProvider1.SetError(btAddConjugation, "There should be at least one conjugation!");
				return;
			}

			this.allCongjugations.Add(new VerbConjugation(tbMood.Text, tbTense.Text, forms));
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
