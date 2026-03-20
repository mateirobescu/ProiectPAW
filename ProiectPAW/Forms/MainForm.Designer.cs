namespace ProiectPAW
{
	partial class MainForm
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
			this.lvWords = new System.Windows.Forms.ListView();
			this.word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.wordsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addLangBtn = new System.Windows.Forms.Button();
			this.addWordBtn = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTimer = new System.Windows.Forms.Timer(this.components);
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wordsMenuStrip.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvWords
			// 
			this.lvWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.word,
            this.language,
            this.description});
			this.lvWords.ContextMenuStrip = this.wordsMenuStrip;
			this.lvWords.FullRowSelect = true;
			this.lvWords.GridLines = true;
			this.lvWords.HideSelection = false;
			this.lvWords.Location = new System.Drawing.Point(410, 201);
			this.lvWords.MultiSelect = false;
			this.lvWords.Name = "lvWords";
			this.lvWords.Size = new System.Drawing.Size(1052, 797);
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
			// wordsMenuStrip
			// 
			this.wordsMenuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
			this.wordsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
			this.wordsMenuStrip.Name = "contextMenuStrip2";
			this.wordsMenuStrip.Size = new System.Drawing.Size(172, 136);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(171, 44);
			this.editToolStripMenuItem.Text = "View";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(171, 44);
			this.deleteToolStripMenuItem.Text = "Edit";
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(171, 44);
			this.deleteToolStripMenuItem1.Text = "Delete";
			// 
			// searchTb
			// 
			this.searchTb.Location = new System.Drawing.Point(410, 133);
			this.searchTb.Name = "searchTb";
			this.searchTb.Size = new System.Drawing.Size(600, 35);
			this.searchTb.TabIndex = 1;
			this.searchTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(405, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search";
			// 
			// addLangBtn
			// 
			this.addLangBtn.Location = new System.Drawing.Point(82, 605);
			this.addLangBtn.Name = "addLangBtn";
			this.addLangBtn.Size = new System.Drawing.Size(249, 135);
			this.addLangBtn.TabIndex = 4;
			this.addLangBtn.Text = "Add &Language";
			this.addLangBtn.UseVisualStyleBackColor = true;
			this.addLangBtn.Click += new System.EventHandler(this.addLangBtn_Click);
			// 
			// addWordBtn
			// 
			this.addWordBtn.Location = new System.Drawing.Point(82, 791);
			this.addWordBtn.Name = "addWordBtn";
			this.addWordBtn.Size = new System.Drawing.Size(249, 135);
			this.addWordBtn.TabIndex = 5;
			this.addWordBtn.Text = "Add &Word";
			this.addWordBtn.UseVisualStyleBackColor = true;
			this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1488, 47);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(94, 43);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// searchTimer
			// 
			this.searchTimer.Interval = 400;
			this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(115, 43);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// xMLToolStripMenuItem
			// 
			this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
			this.xMLToolStripMenuItem.Size = new System.Drawing.Size(403, 48);
			this.xMLToolStripMenuItem.Text = "XML";
			this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1488, 1030);
			this.Controls.Add(this.addWordBtn);
			this.Controls.Add(this.addLangBtn);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.searchTb);
			this.Controls.Add(this.lvWords);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Dictionary";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.wordsMenuStrip.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvWords;
		private System.Windows.Forms.ColumnHeader word;
		private System.Windows.Forms.ColumnHeader language;
		private System.Windows.Forms.ColumnHeader description;
		private System.Windows.Forms.TextBox searchTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addLangBtn;
		private System.Windows.Forms.Button addWordBtn;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Timer searchTimer;
		private System.Windows.Forms.ContextMenuStrip wordsMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
	}
}

