namespace ProiectPAW
{
	partial class AddLangForm
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
			this.iso2CodeTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.langNameTb = new System.Windows.Forms.TextBox();
			this.addLangBtn = new System.Windows.Forms.Button();
			this.langErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.langErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// iso2CodeTb
			// 
			this.iso2CodeTb.Location = new System.Drawing.Point(130, 95);
			this.iso2CodeTb.Name = "iso2CodeTb";
			this.iso2CodeTb.Size = new System.Drawing.Size(270, 35);
			this.iso2CodeTb.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Iso2 Code";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(130, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Language Name";
			// 
			// langNameTb
			// 
			this.langNameTb.Location = new System.Drawing.Point(130, 221);
			this.langNameTb.Name = "langNameTb";
			this.langNameTb.Size = new System.Drawing.Size(270, 35);
			this.langNameTb.TabIndex = 2;
			// 
			// addLangBtn
			// 
			this.addLangBtn.Location = new System.Drawing.Point(130, 321);
			this.addLangBtn.Name = "addLangBtn";
			this.addLangBtn.Size = new System.Drawing.Size(211, 89);
			this.addLangBtn.TabIndex = 4;
			this.addLangBtn.Text = "Add Language";
			this.addLangBtn.UseVisualStyleBackColor = true;
			this.addLangBtn.Click += new System.EventHandler(this.addLangBtn_Click);
			// 
			// langErrorProvider
			// 
			this.langErrorProvider.ContainerControl = this;
			// 
			// AddLangForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 450);
			this.Controls.Add(this.addLangBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.langNameTb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.iso2CodeTb);
			this.Name = "AddLangForm";
			this.Text = "Add Language";
			((System.ComponentModel.ISupportInitialize)(this.langErrorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox iso2CodeTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox langNameTb;
		private System.Windows.Forms.Button addLangBtn;
		private System.Windows.Forms.ErrorProvider langErrorProvider;
	}
}