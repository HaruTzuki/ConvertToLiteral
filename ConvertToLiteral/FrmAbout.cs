using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToLiteral
{
	public partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			InitializeComponent();
			GetInformation();
		}

		private void GetInformation()
		{
			var assembly = Assembly.GetExecutingAssembly();
			var companyAttribute = assembly.GetCustomAttributes<AssemblyCompanyAttribute>();
			Lbl_Developer_Name.Text = companyAttribute?.FirstOrDefault()?.Company??"";
			var versionAttribute = assembly.GetCustomAttributes<AssemblyFileVersionAttribute>();
			Lbl_Version_Number.Text = versionAttribute.FirstOrDefault()?.Version;
		}
	}
}
