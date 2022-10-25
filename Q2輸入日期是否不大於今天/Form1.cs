using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2輸入日期是否不大於今天
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime input;
			try
			{
				input = GetInput();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			Display(input);
		}

		private DateTime GetInput()
		{
			string input = textBox1.Text;
			bool isDateTime = DateTime.TryParse(input ,out DateTime dateTime);
			return isDateTime ? dateTime : throw new Exception("抱歉，您輸入的格式不符");
		}
		
		private void Display(DateTime input)
		{
			if (input > DateTime.Today)
			{
				MessageBox.Show("輸入日期不可大於今日");
			}
			else
			{
				MessageBox.Show($"{input:yyyy/MM/dd}不大於今天");
			}
		}
	}
}
