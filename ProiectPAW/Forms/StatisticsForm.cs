using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW.Forms
{

	public partial class StatisticsForm : Form
	{
		private AppData Data => AppData.Instance;
		public StatisticsForm()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Dictionary<string, Dictionary<string, int>> stats = new Dictionary<string, Dictionary<string, int>>();
			foreach(Word w in Data.AllWords)
			{
				if (!stats.ContainsKey(w.LanguageIsoCode))
					stats[w.LanguageIsoCode] = new Dictionary<string, int>();

				if (!stats[w.LanguageIsoCode].ContainsKey("Word"))
					stats[w.LanguageIsoCode]["Word"] = 0;
				stats[w.LanguageIsoCode]["Word"]++;

				if (w is Noun)
				{
					if (!stats[w.LanguageIsoCode].ContainsKey("Noun"))
						stats[w.LanguageIsoCode]["Noun"] = 0;
					stats[w.LanguageIsoCode]["Noun"]++;
				}
				if (w is Verb)
				{
					if (!stats[w.LanguageIsoCode].ContainsKey("Verb"))
						stats[w.LanguageIsoCode]["Verb"] = 0;
					stats[w.LanguageIsoCode]["Verb"]++;
				}
				if (w is Adjective)
				{
					if (!stats[w.LanguageIsoCode].ContainsKey("Adjective"))
						stats[w.LanguageIsoCode]["Adjective"] = 0;
					stats[w.LanguageIsoCode]["Adjective"]++;
				}
				if (w is OtherWord)
				{
					if (!stats[w.LanguageIsoCode].ContainsKey("OtherWord"))
						stats[w.LanguageIsoCode]["OtherWord"] = 0;
					stats[w.LanguageIsoCode]["OtherWord"]++;
				}
				
			}

			Graphics gr = e.Graphics;

			float width = panel1.Width;
			float langs = stats.Count;
			float bars = langs * 5 + langs + 1;
			float barWidth = width / bars;

			float x = barWidth;
			float maxHeight = panel1.Height - 50 - 50;
			float maxWords = stats.Max(pair => pair.Value["Word"]);

			foreach(string langIso in stats.Keys)
			{
				string langName = Data.AllLanguages.First(lang => lang.IsoCode.Equals(langIso)).Name;

				gr.DrawString(langName, this.Font, Brushes.Black, x + barWidth * 1.5f, panel1.Height - 20);

				DrawBar(gr, Brushes.Blue, langIso, "Word", x, maxHeight, maxWords, barWidth, stats);				
				x += barWidth;

				DrawBar(gr, Brushes.Red, langIso, "Noun", x, maxHeight, maxWords, barWidth, stats);
				x += barWidth;

				DrawBar(gr, Brushes.Orange, langIso, "Adjective", x, maxHeight, maxWords, barWidth, stats);
				x += barWidth;

				DrawBar(gr, Brushes.Green, langIso, "Verb", x, maxHeight, maxWords, barWidth, stats);
				x += barWidth;

				DrawBar(gr, Brushes.Purple, langIso, "Other", x, maxHeight, maxWords, barWidth, stats);
				x += barWidth;
				x += barWidth;

			}

		}

		void DrawBar(Graphics gr, Brush brush,string langIso, string key, float x, float maxHeight, float maxWords, float barWidth, Dictionary<string, Dictionary<string, int>> stats)
		{
			float nr = stats[langIso].ContainsKey(key) ? stats[langIso][key] : 0;
			gr.DrawString(key, this.Font, Brushes.Black, x, panel1.Height - 45);
			RectangleF recf = new RectangleF(x, 50 + (maxHeight - maxHeight * (nr / maxWords)), barWidth, maxHeight * (nr / maxWords));
			gr.FillRectangle(brush, recf);

			gr.DrawString(nr.ToString(), this.Font, Brushes.Black, x + barWidth / 2.25f, 35 + (maxHeight - maxHeight * (nr / maxWords)));

		}

		private void panel1_Resize(object sender, EventArgs e)
		{
			panel1.Invalidate();
		}
	}
}
