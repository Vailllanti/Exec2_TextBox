using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1輸入數值是否在_1_99_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void judgebtn_Click(object sender, EventArgs e)
		{
			double input = 0;
			
			try
			{
				input = GetInput();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			if (input >= 1 && input <= 99)
			{
				MessageBox.Show($"{input}介於1~99");
			}
			else
			{
				MessageBox.Show($"{input}在1~99之外");
			}
		}

		private double GetInput()
		{
			string value = inputtxtb.Text;
			bool isDouble = double.TryParse(value, out double result);
			return isDouble ? result : throw new Exception("請輸入數值");
		}
	}
}
