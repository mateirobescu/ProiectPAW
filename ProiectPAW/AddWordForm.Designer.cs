namespace ProiectPAW
{
	partial class AddWordForm
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
			this.wordAddTabCtrl = new System.Windows.Forms.TabControl();
			this.nounTabPage = new System.Windows.Forms.TabPage();
			this.neuterRbtn = new System.Windows.Forms.RadioButton();
			this.feminineRbtn = new System.Windows.Forms.RadioButton();
			this.masculineRbtn = new System.Windows.Forms.RadioButton();
			this.adjectiveTabPage = new System.Windows.Forms.TabPage();
			this.addWordBtn = new System.Windows.Forms.Button();
			this.wordTextTb = new System.Windows.Forms.TextBox();
			this.wordLb = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.languageCb = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.descriptionRtb = new System.Windows.Forms.RichTextBox();
			this.wordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.wordAddTabCtrl.SuspendLayout();
			this.nounTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wordErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// wordAddTabCtrl
			// 
			this.wordAddTabCtrl.Controls.Add(this.nounTabPage);
			this.wordAddTabCtrl.Controls.Add(this.adjectiveTabPage);
			this.wordAddTabCtrl.Location = new System.Drawing.Point(35, 231);
			this.wordAddTabCtrl.Name = "wordAddTabCtrl";
			this.wordAddTabCtrl.SelectedIndex = 0;
			this.wordAddTabCtrl.Size = new System.Drawing.Size(464, 294);
			this.wordAddTabCtrl.TabIndex = 0;
			// 
			// nounTabPage
			// 
			this.nounTabPage.Controls.Add(this.neuterRbtn);
			this.nounTabPage.Controls.Add(this.feminineRbtn);
			this.nounTabPage.Controls.Add(this.masculineRbtn);
			this.nounTabPage.Location = new System.Drawing.Point(10, 47);
			this.nounTabPage.Name = "nounTabPage";
			this.nounTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.nounTabPage.Size = new System.Drawing.Size(444, 237);
			this.nounTabPage.TabIndex = 0;
			this.nounTabPage.Text = "Noun";
			this.nounTabPage.UseVisualStyleBackColor = true;
			// 
			// neuterRbtn
			// 
			this.neuterRbtn.AutoSize = true;
			this.neuterRbtn.Location = new System.Drawing.Point(23, 147);
			this.neuterRbtn.Name = "neuterRbtn";
			this.neuterRbtn.Size = new System.Drawing.Size(117, 33);
			this.neuterRbtn.TabIndex = 2;
			this.neuterRbtn.TabStop = true;
			this.neuterRbtn.Text = "Neuter";
			this.neuterRbtn.UseVisualStyleBackColor = true;
			// 
			// feminineRbtn
			// 
			this.feminineRbtn.AutoSize = true;
			this.feminineRbtn.Location = new System.Drawing.Point(23, 97);
			this.feminineRbtn.Name = "feminineRbtn";
			this.feminineRbtn.Size = new System.Drawing.Size(145, 33);
			this.feminineRbtn.TabIndex = 1;
			this.feminineRbtn.TabStop = true;
			this.feminineRbtn.Text = "Feminine";
			this.feminineRbtn.UseVisualStyleBackColor = true;
			// 
			// masculineRbtn
			// 
			this.masculineRbtn.AutoSize = true;
			this.masculineRbtn.Location = new System.Drawing.Point(23, 45);
			this.masculineRbtn.Name = "masculineRbtn";
			this.masculineRbtn.Size = new System.Drawing.Size(153, 33);
			this.masculineRbtn.TabIndex = 0;
			this.masculineRbtn.TabStop = true;
			this.masculineRbtn.Text = "Masculine";
			this.masculineRbtn.UseVisualStyleBackColor = true;
			// 
			// adjectiveTabPage
			// 
			this.adjectiveTabPage.Location = new System.Drawing.Point(10, 47);
			this.adjectiveTabPage.Name = "adjectiveTabPage";
			this.adjectiveTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.adjectiveTabPage.Size = new System.Drawing.Size(444, 237);
			this.adjectiveTabPage.TabIndex = 1;
			this.adjectiveTabPage.Text = "Adjective";
			this.adjectiveTabPage.UseVisualStyleBackColor = true;
			// 
			// addWordBtn
			// 
			this.addWordBtn.Location = new System.Drawing.Point(318, 567);
			this.addWordBtn.Name = "addWordBtn";
			this.addWordBtn.Size = new System.Drawing.Size(393, 71);
			this.addWordBtn.TabIndex = 1;
			this.addWordBtn.Text = "Add Word";
			this.addWordBtn.UseVisualStyleBackColor = true;
			this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
			// 
			// wordTextTb
			// 
			this.wordTextTb.Location = new System.Drawing.Point(45, 57);
			this.wordTextTb.Name = "wordTextTb";
			this.wordTextTb.Size = new System.Drawing.Size(346, 35);
			this.wordTextTb.TabIndex = 0;
			// 
			// wordLb
			// 
			this.wordLb.AutoSize = true;
			this.wordLb.Location = new System.Drawing.Point(40, 25);
			this.wordLb.Name = "wordLb";
			this.wordLb.Size = new System.Drawing.Size(130, 29);
			this.wordLb.TabIndex = 1;
			this.wordLb.Text = "Word Text:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Language";
			// 
			// languageCb
			// 
			this.languageCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.languageCb.FormattingEnabled = true;
			this.languageCb.Location = new System.Drawing.Point(45, 161);
			this.languageCb.Name = "languageCb";
			this.languageCb.Size = new System.Drawing.Size(346, 37);
			this.languageCb.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(530, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description";
			// 
			// descriptionRtb
			// 
			this.descriptionRtb.Location = new System.Drawing.Point(535, 57);
			this.descriptionRtb.Name = "descriptionRtb";
			this.descriptionRtb.Size = new System.Drawing.Size(455, 458);
			this.descriptionRtb.TabIndex = 5;
			this.descriptionRtb.Text = "";
			// 
			// wordErrorProvider
			// 
			this.wordErrorProvider.ContainerControl = this;
			// 
			// AddWordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 666);
			this.Controls.Add(this.descriptionRtb);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.languageCb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.wordTextTb);
			this.Controls.Add(this.wordLb);
			this.Controls.Add(this.addWordBtn);
			this.Controls.Add(this.wordAddTabCtrl);
			this.Name = "AddWordForm";
			this.Text = "AddWordForm";
			this.Load += new System.EventHandler(this.AddWordForm_Load);
			this.wordAddTabCtrl.ResumeLayout(false);
			this.nounTabPage.ResumeLayout(false);
			this.nounTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.wordErrorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl wordAddTabCtrl;
		private System.Windows.Forms.TabPage nounTabPage;
		private System.Windows.Forms.TabPage adjectiveTabPage;
		private System.Windows.Forms.Button addWordBtn;
		private System.Windows.Forms.Label wordLb;
		private System.Windows.Forms.TextBox wordTextTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox languageCb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox descriptionRtb;
		private System.Windows.Forms.RadioButton neuterRbtn;
		private System.Windows.Forms.RadioButton feminineRbtn;
		private System.Windows.Forms.RadioButton masculineRbtn;
		private System.Windows.Forms.ErrorProvider wordErrorProvider;
	}
}