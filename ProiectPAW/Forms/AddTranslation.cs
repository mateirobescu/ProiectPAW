using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProiectPAW.Forms
{
	public partial class AddTranslation : Form
	{
		private AppData Data => AppData.Instance;
		private Dictionary<string, List<long>> translations;
		public AddTranslation(Dictionary<string, List<long>> translations)
		{
			InitializeComponent();
			this.translations = translations;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			searchTimer.Stop();

			searchTimer.Start();
		}

		private void AddTranslation_Load(object sender, EventArgs e)
		{
			MainForm.DisplayWords(Data.AllWords, Data.AllLanguages, lvSearch);
			List<Word> words = translations.Values
				.SelectMany(ids => ids)
				.Select(id => Data.AllWords.First(w => w.Id == id))
				.ToList();

			MainForm.DisplayWords(words.AsReadOnly(), Data.AllLanguages, lvDisplay);
		}

		private void searchTimer_Tick(object sender, EventArgs e)
		{
			searchTimer.Stop();
			ReadOnlyCollection<Word> wordsFound = MainForm.QueryWords(Data.AllWords, searchTb.Text);
			MainForm.DisplayWords(wordsFound, Data.AllLanguages, lvSearch);
		}

		private void lvSearch_MouseDown(object sender, MouseEventArgs e)
		{
			ListViewItem selected = lvSearch.SelectedItems.Count > 0
				? lvSearch.SelectedItems[0] : null;
			if (selected == null) return;

			Word word = Data.AllWords.First(w => w.Id == (long)selected.Tag);

			DoDragDrop(word, DragDropEffects.Copy);
		}

		private void lvDisplay_DragDrop(object sender, DragEventArgs e)
		{
			Word word = e.Data.GetFormats()
				.Select(f => e.Data.GetData(f) as Word)
				.FirstOrDefault(w => w != null);

			if (!translations.ContainsKey(word.LanguageIsoCode))
				translations[word.LanguageIsoCode] = new List<long>() { word.Id };
			else
				translations[word.LanguageIsoCode].Add(word.Id);

			List<Word> words = translations.Values
				.SelectMany(ids => ids)
				.Select(id => Data.AllWords.First(w => w.Id == id))
				.ToList();

			MainForm.DisplayWords(words.AsReadOnly(), Data.AllLanguages, lvDisplay);
		}

		private void lvDisplay_DragEnter(object sender, DragEventArgs e)
		{
			if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;


		}

		private void addWordBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;  
			this.Close();
		}
	}
}
