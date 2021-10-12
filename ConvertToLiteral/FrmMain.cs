using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToLiteral
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void btn_toliteral_Click(object sender, EventArgs e)
		{
			Txt_LiteralText.Text = Txt_PlainText.Text.ToLiteral();
		}

		private void Mstrip_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MStrip_About_Click(object sender, EventArgs e)
		{
			using var form = new FrmAbout();
			form.ShowDialog();
		}
	}
}
