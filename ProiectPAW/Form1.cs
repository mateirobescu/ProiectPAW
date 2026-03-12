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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Language en = new Language("EN", "English");
			Language ro = new Language("RO", "Romanian");

			Word tableEn = new Word("Table", "EN", "Table object");
			Word tableRO = new Word("Masa", "RO", "Obiectul masa");
			Word houseRO = new Word("Casa", "Rd", "Obiectul casa");
			Word houseEn = new Word("House", "EN", "House Object");
			List<Word> words = new List<Word> { tableEn, tableRO, houseRO, houseEn };
			List<Language> languages = new List<Language> { en, ro};

			foreach(Word w in words)
			{
				ListViewItem currItem = new ListViewItem(w.Text);

				string language = "";
				foreach (Language l in languages)
					if (l.IsoCode == w.LanguageIsoCode)
						language = l.DefaultName;

				if (String.IsNullOrEmpty(language))
					language = w.LanguageIsoCode;

				currItem.SubItems.Add(language);
				currItem.SubItems.Add(w.Description);


				lvWords.Items.Add(currItem);
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

	}
}
