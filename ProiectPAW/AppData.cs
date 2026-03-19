using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
	[Serializable]
	public class AppData
	{
		private List<Word> allWords = new List<Word>();
		private List<Language> allLanguages = new List<Language>();

		private static AppData _instance;
		public static AppData Instance
		{
			get
			{
				if (_instance == null) 
					_instance = new AppData();
				return _instance;
			}

			set => _instance = value;
		}

		public List<Word> AllWords { get => this.allWords; }
		public List<Language> AllLanguages { get => this.allLanguages; }

		private AppData() { }

		public override string ToString()
		{
			return String.Join(" ", this.AllLanguages) + Environment.NewLine + String.Join(" ", this.AllWords);
		}

		public static void saveToBinary(AppData appData, string fileName)
		{
			try
			{
				using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(fs, appData);
				}
			}
			catch(IOException exc)
			{
				Console.WriteLine(exc.Message);
			}

		}

		public static void LoadFromBinary(string fileName)
		{
			try
			{
				using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))

				{
					BinaryFormatter bf = new BinaryFormatter();
					AppData.Instance = (AppData)bf.Deserialize(fs);
					Word.calculateIdGenerator(AppData.Instance.allWords);
				}
			}
			catch (IOException exc)
			{
				Console.WriteLine(exc.Message);
			}
			
		}


	}
}
