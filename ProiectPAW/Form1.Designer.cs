namespace ProiectPAW
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lvWords = new System.Windows.Forms.ListView();
			this.word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvWords
			// 
			this.lvWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.word,
            this.language,
            this.description});
			this.lvWords.GridLines = true;
			this.lvWords.HideSelection = false;
			this.lvWords.Location = new System.Drawing.Point(12, 21);
			this.lvWords.Name = "lvWords";
			this.lvWords.Size = new System.Drawing.Size(1014, 797);
			this.lvWords.TabIndex = 0;
			this.lvWords.UseCompatibleStateImageBehavior = false;
			this.lvWords.View = System.Windows.Forms.View.Details;
			// 
			// word
			// 
			this.word.Text = "Word";
			this.word.Width = 122;
			// 
			// language
			// 
			this.language.Text = "Language";
			this.language.Width = 130;
			// 
			// description
			// 
			this.description.Text = "Description";
			this.description.Width = 224;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1056, 1030);
			this.Controls.Add(this.lvWords);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvWords;
		private System.Windows.Forms.ColumnHeader word;
		private System.Windows.Forms.ColumnHeader language;
		private System.Windows.Forms.ColumnHeader description;
	}
}

