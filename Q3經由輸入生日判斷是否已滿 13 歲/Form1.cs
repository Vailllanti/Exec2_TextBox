using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3經由輸入生日判斷是否已滿_13_歲
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void confirmbtn_Click(object sender, EventArgs e)
		{
			DateTime birthday;
			try
			{
				birthday = GetInput();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			Display(birthday);

		}

		private DateTime GetInput()
		{
			string input = inputtxtb.Text;
			bool isDateTime = DateTime.TryParse(input, out DateTime birth);
			if (isDateTime == false)
			{
				throw new Exception("輸入格式錯誤");
			}
			else if (birth > DateTime.Today)
			{
				throw new Exception("生日不可晚於今日");
			}
			else
				return birth;
		}
		private void Display(DateTime birthday)
		{
			if (DateTime.Today.AddYears(-13) < birthday)
			{
				MessageBox.Show("您未滿13歲");
			}
			else
			{
				MessageBox.Show("您超過13歲了");
			}
		}

	}
}
