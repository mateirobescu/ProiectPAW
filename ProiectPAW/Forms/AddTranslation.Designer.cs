namespace ProiectPAW.Forms
{
	partial class AddTranslation
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
			this.components = new System.ComponentModel.Container();
			this.searchTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvSearch = new System.Windows.Forms.ListView();
			this.word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvDisplay = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.searchTimer = new System.Windows.Forms.Timer(this.components);
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// searchTb
			// 
			this.searchTb.Location = new System.Drawing.Point(42, 93);
			this.searchTb.Name = "searchTb";
			this.searchTb.Size = new System.Drawing.Size(567, 35);
			this.searchTb.TabIndex = 2;
			this.searchTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search";
			// 
			// lvSearch
			// 
			this.lvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.word,
            this.columnHeader2});
			this.lvSearch.FullRowSelect = true;
			this.lvSearch.GridLines = true;
			this.lvSearch.HideSelection = false;
			this.lvSearch.Location = new System.Drawing.Point(42, 149);
			this.lvSearch.MultiSelect = false;
			this.lvSearch.Name = "lvSearch";
			this.lvSearch.Size = new System.Drawing.Size(567, 562);
			this.lvSearch.TabIndex = 4;
			this.lvSearch.UseCompatibleStateImageBehavior = false;
			this.lvSearch.View = System.Windows.Forms.View.Details;
			this.lvSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSearch_MouseDown);
			// 
			// word
			// 
			this.word.Text = "Word";
			this.word.Width = 122;
			// 
			// lvDisplay
			// 
			this.lvDisplay.AllowDrop = true;
			this.lvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
			this.lvDisplay.FullRowSelect = true;
			this.lvDisplay.GridLines = true;
			this.lvDisplay.HideSelection = false;
			this.lvDisplay.Location = new System.Drawing.Point(755, 93);
			this.lvDisplay.MultiSelect = false;
			this.lvDisplay.Name = "lvDisplay";
			this.lvDisplay.Size = new System.Drawing.Size(493, 618);
			this.lvDisplay.TabIndex = 5;
			this.lvDisplay.UseCompatibleStateImageBehavior = false;
			this.lvDisplay.View = System.Windows.Forms.View.Details;
			this.lvDisplay.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvDisplay_DragDrop);
			this.lvDisplay.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvDisplay_DragEnter);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Word";
			this.columnHeader1.Width = 122;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(750, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "Translations";
			// 
			// searchTimer
			// 
			this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Language";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Language";
			// 
			// AddTranslation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1318, 822);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lvDisplay);
			this.Controls.Add(this.lvSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.searchTb);
			this.Name = "AddTranslation";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.AddTranslation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox searchTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvSearch;
		private System.Windows.Forms.ColumnHeader word;
		private System.Windows.Forms.ListView lvDisplay;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer searchTimer;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}