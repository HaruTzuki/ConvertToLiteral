
namespace ConvertToLiteral
{
	partial class FrmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.main_menu = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Mstrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.MStrip_About = new System.Windows.Forms.ToolStripMenuItem();
			this.Lbl_SourceText = new System.Windows.Forms.Label();
			this.Txt_PlainText = new ConvertToLiteral.ExpressTextBox();
			this.Lbl_LiteralText = new System.Windows.Forms.Label();
			this.btn_toliteral = new System.Windows.Forms.Button();
			this.Txt_LiteralText = new ConvertToLiteral.ExpressTextBox();
			this.main_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// main_menu
			// 
			this.main_menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.MStrip_About});
			this.main_menu.Location = new System.Drawing.Point(0, 0);
			this.main_menu.Name = "main_menu";
			this.main_menu.Size = new System.Drawing.Size(812, 28);
			this.main_menu.TabIndex = 0;
			this.main_menu.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mstrip_Exit});
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.exitToolStripMenuItem.Text = "&File";
			// 
			// Mstrip_Exit
			// 
			this.Mstrip_Exit.Name = "Mstrip_Exit";
			this.Mstrip_Exit.Size = new System.Drawing.Size(116, 26);
			this.Mstrip_Exit.Text = "Exit";
			this.Mstrip_Exit.Click += new System.EventHandler(this.Mstrip_Exit_Click);
			// 
			// MStrip_About
			// 
			this.MStrip_About.Name = "MStrip_About";
			this.MStrip_About.Size = new System.Drawing.Size(64, 24);
			this.MStrip_About.Text = "&About";
			this.MStrip_About.Click += new System.EventHandler(this.MStrip_About_Click);
			// 
			// Lbl_SourceText
			// 
			this.Lbl_SourceText.AutoSize = true;
			this.Lbl_SourceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Lbl_SourceText.ForeColor = System.Drawing.Color.White;
			this.Lbl_SourceText.Location = new System.Drawing.Point(12, 54);
			this.Lbl_SourceText.Name = "Lbl_SourceText";
			this.Lbl_SourceText.Size = new System.Drawing.Size(90, 20);
			this.Lbl_SourceText.TabIndex = 1;
			this.Lbl_SourceText.Text = "Source Text";
			// 
			// Txt_PlainText
			// 
			this.Txt_PlainText.Location = new System.Drawing.Point(12, 77);
			this.Txt_PlainText.Multiline = true;
			this.Txt_PlainText.Name = "Txt_PlainText";
			this.Txt_PlainText.Size = new System.Drawing.Size(357, 447);
			this.Txt_PlainText.TabIndex = 2;
			// 
			// Lbl_LiteralText
			// 
			this.Lbl_LiteralText.AutoSize = true;
			this.Lbl_LiteralText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Lbl_LiteralText.ForeColor = System.Drawing.Color.White;
			this.Lbl_LiteralText.Location = new System.Drawing.Point(443, 54);
			this.Lbl_LiteralText.Name = "Lbl_LiteralText";
			this.Lbl_LiteralText.Size = new System.Drawing.Size(87, 20);
			this.Lbl_LiteralText.TabIndex = 3;
			this.Lbl_LiteralText.Text = "Literal Text";
			// 
			// btn_toliteral
			// 
			this.btn_toliteral.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btn_toliteral.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_toliteral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_toliteral.Location = new System.Drawing.Point(375, 268);
			this.btn_toliteral.Name = "btn_toliteral";
			this.btn_toliteral.Size = new System.Drawing.Size(62, 29);
			this.btn_toliteral.TabIndex = 5;
			this.btn_toliteral.Text = ">>";
			this.btn_toliteral.UseVisualStyleBackColor = false;
			this.btn_toliteral.Click += new System.EventHandler(this.btn_toliteral_Click);
			// 
			// Txt_LiteralText
			// 
			this.Txt_LiteralText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_LiteralText.Location = new System.Drawing.Point(443, 77);
			this.Txt_LiteralText.Multiline = true;
			this.Txt_LiteralText.Name = "Txt_LiteralText";
			this.Txt_LiteralText.Size = new System.Drawing.Size(357, 447);
			this.Txt_LiteralText.TabIndex = 6;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(812, 536);
			this.Controls.Add(this.Txt_LiteralText);
			this.Controls.Add(this.btn_toliteral);
			this.Controls.Add(this.Lbl_LiteralText);
			this.Controls.Add(this.Txt_PlainText);
			this.Controls.Add(this.Lbl_SourceText);
			this.Controls.Add(this.main_menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.main_menu;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Convert Text to Literal";
			this.main_menu.ResumeLayout(false);
			this.main_menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip main_menu;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MStrip_About;
		private System.Windows.Forms.Label Lbl_SourceText;
		private ExpressTextBox Txt_PlainText;
		private System.Windows.Forms.Label Lbl_LiteralText;
		private System.Windows.Forms.Button btn_toliteral;
		private ExpressTextBox Txt_LiteralText;
		private System.Windows.Forms.ToolStripMenuItem Mstrip_Exit;
	}
}

