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

namespace ProiectPAW
{
	public partial class MainForm : Form
	{
		private AppData Data => AppData.Instance;
		private const string BINARY_FILENAME = "dicitonary.dat";

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Data.LoadFromBinary(BINARY_FILENAME);
			DisplayWords(Data.AllWords, Data.AllLanguages, lvWords);
			this.Data.OnDataChange += this.UpdateMainListView;
		}

		private void addLangBtn_Click(object sender, EventArgs e)
		{
			AddLangForm alf = new AddLangForm();
			alf.ShowDialog();
		}

		private void addWordBtn_Click(object sender, EventArgs e)
		{
			AddWordForm awf = new AddWordForm();
			awf.ShowDialog();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.Data.saveToBinary(this.Data, BINARY_FILENAME);

				MessageBox.Show(
					"The dictionary data has been successfully saved to the binary file.",
					"Save Successful",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					$"An error occurred while saving the data:\n{ex.Message}",
					"Save Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		static public void DisplayWords(ReadOnlyCollection<Word> words, ReadOnlyCollection<Language> langs, ListView listView)
		{
			listView.Items.Clear();

			foreach (Word w in words)
			{
				ListViewItem currItem = new ListViewItem(w.CapText);

				string language = "";
				foreach (Language l in langs)
					if (l.IsoCode == w.LanguageIsoCode)
						language = l.CapName;

				if (String.IsNullOrEmpty(language))
					language = w.LanguageIsoCode;

				currItem.SubItems.Add(language);
				currItem.SubItems.Add(w.Description);
				currItem.Tag = w.Id;

				listView.Items.Add(currItem);
			}
		}

		static public ReadOnlyCollection<Word> QueryWords(ReadOnlyCollection<Word> words, string query)
		{
			return words.Where(
					w => w.Text.ToLower().StartsWith(query)
				).ToList().AsReadOnly();
		}

		static public void QueryAndDisplay(string query, ListView listView, ReadOnlyCollection<Word> words, ReadOnlyCollection<Language> languages)
		{
			DisplayWords(QueryWords(words, query), languages, listView);
		}

		private void UpdateMainListView()
		{
			QueryAndDisplay(searchTb.Text, lvWords, Data.AllWords, Data.AllLanguages);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			searchTimer.Stop();

			searchTimer.Start();
		}

		private void searchTimer_Tick(object sender, EventArgs e)
		{
			searchTimer.Stop();
			ReadOnlyCollection<Word> wordsFound = QueryWords(Data.AllWords, searchTb.Text);
			DisplayWords(wordsFound, Data.AllLanguages, lvWords);

		}

		private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Title = "Export to XML";
				sfd.Filter = "XML file (*.xml)|*.xml";
				sfd.DefaultExt = "xml";
				sfd.FileName = "dictionary.xml";

				if(sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						this.Data.ExportToXML(sfd.FileName);
						MessageBox.Show("Data Exported to XML succesfully!", "Succes",MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"An error appeared when exporting: {ex.Message}", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ListViewItem wordToDelete = lvWords.SelectedItems[0];

			DialogResult result = MessageBox.Show(
			$"Are you sure you want to delete the word '{wordToDelete.Text}'?",
			"Confirm Deletion",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Warning);

			if(result == DialogResult.Yes)
			{
				long idToDelete = (long)wordToDelete.Tag;
				this.Data.RemoveWord(idToDelete);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.UpdateMainListView();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListViewItem wordToEdit = lvWords.SelectedItems[0];
			long wordId = (long)wordToEdit.Tag;

			Word selectedWord = Data.AllWords.First(w => w.Id == wordId);

			AddWordForm awf = new AddWordForm(selectedWord);

			awf.ShowDialog();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"This feature is a work in progress. Will be implemented soon!",
				"Work in Progress",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation
			);
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
