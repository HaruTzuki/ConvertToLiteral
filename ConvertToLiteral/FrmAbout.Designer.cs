
namespace ConvertToLiteral
{
	partial class FrmAbout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Lbl_Developer = new System.Windows.Forms.Label();
			this.Lbl_Developer_Name = new System.Windows.Forms.Label();
			this.Lbl_Version = new System.Windows.Forms.Label();
			this.Lbl_Version_Number = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ConvertToLiteral.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 284);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.Lbl_Developer, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Lbl_Developer_Name, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Lbl_Version, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Lbl_Version_Number, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 284);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// Lbl_Developer
			// 
			this.Lbl_Developer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_Developer.Location = new System.Drawing.Point(3, 0);
			this.Lbl_Developer.Name = "Lbl_Developer";
			this.Lbl_Developer.Size = new System.Drawing.Size(180, 25);
			this.Lbl_Developer.TabIndex = 0;
			this.Lbl_Developer.Text = "Developer:";
			this.Lbl_Developer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Lbl_Developer_Name
			// 
			this.Lbl_Developer_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_Developer_Name.Location = new System.Drawing.Point(189, 0);
			this.Lbl_Developer_Name.Name = "Lbl_Developer_Name";
			this.Lbl_Developer_Name.Size = new System.Drawing.Size(180, 25);
			this.Lbl_Developer_Name.TabIndex = 1;
			this.Lbl_Developer_Name.Text = "Vlachopoulos Dimitris";
			this.Lbl_Developer_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lbl_Version
			// 
			this.Lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_Version.Location = new System.Drawing.Point(3, 25);
			this.Lbl_Version.Name = "Lbl_Version";
			this.Lbl_Version.Size = new System.Drawing.Size(180, 25);
			this.Lbl_Version.TabIndex = 2;
			this.Lbl_Version.Text = "Version:";
			this.Lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Lbl_Version_Number
			// 
			this.Lbl_Version_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_Version_Number.Location = new System.Drawing.Point(189, 25);
			this.Lbl_Version_Number.Name = "Lbl_Version_Number";
			this.Lbl_Version_Number.Size = new System.Drawing.Size(180, 25);
			this.Lbl_Version_Number.TabIndex = 3;
			this.Lbl_Version_Number.Text = "1.0.0.0";
			this.Lbl_Version_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(617, 308);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Lbl_Developer;
		private System.Windows.Forms.Label Lbl_Developer_Name;
		private System.Windows.Forms.Label Lbl_Version;
		private System.Windows.Forms.Label Lbl_Version_Number;
	}
}