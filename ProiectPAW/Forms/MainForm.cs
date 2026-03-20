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

			this.displayWords(Data.AllWords);	
		}

		private void addLangBtn_Click(object sender, EventArgs e)
		{
			AddLangForm alf = new AddLangForm();
			//DEBUG
			MessageBox.Show(String.Join(" ", this.Data.AllLanguages));
			alf.ShowDialog();
		}

		private void addWordBtn_Click(object sender, EventArgs e)
		{
			AddWordForm awf = new AddWordForm();
			awf.ShowDialog();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Data.saveToBinary(this.Data, BINARY_FILENAME);
			MessageBox.Show("Data was saved succesfully!");
		}

		private void displayWords(List<Word> words)
		{
			lvWords.Items.Clear();

			foreach (Word w in words)
			{
				ListViewItem currItem = new ListViewItem(w.Text);

				string language = "";
				foreach (Language l in Data.AllLanguages)
					if (l.IsoCode == w.LanguageIsoCode)
						language = l.Name;

				if (String.IsNullOrEmpty(language))
					language = w.LanguageIsoCode;

				currItem.SubItems.Add(language);
				currItem.SubItems.Add(w.Description);


				lvWords.Items.Add(currItem);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			searchTimer.Stop();

			searchTimer.Start();
		}

		private void searchTimer_Tick(object sender, EventArgs e)
		{
			searchTimer.Stop();
			List<Word> wordsFound = performSearch();
			displayWords(wordsFound);

		}

		private List<Word> performSearch()
		{
			string query = searchTb.Text;
			return Data.AllWords.Where(
					w => w.Text.ToLower().StartsWith(query)
				).ToList();
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
	}
}
