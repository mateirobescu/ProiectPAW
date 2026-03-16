using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
	[Serializable]
	public class Language
	{
		private string isoCode;
		private string defaultName;

		public string IsoCode { get => isoCode; set => isoCode = value; }
		public string DefaultName { get => defaultName; set => defaultName = value; }

		private Language() { }

		public Language(string isoCode, string defaultName)
		{
			this.isoCode = isoCode.ToUpper();
			this.defaultName = defaultName;
		}

		override public string ToString()
		{
			return String.Format("Languge[{0}, {1}]", this.isoCode, this.defaultName);
		}

	}
}
