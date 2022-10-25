using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4計算入場費用
{
	public partial class Form1 : Form
	{
		//按車輛計費:
		//每部車收 200 元, 不管裡面坐多少乘客
		//按人頭計費:
        //每人收 60 元, 無論多少部車
		public Form1()
		{
			InitializeComponent();
		}

		private void calebtn_Click(object sender, EventArgs e)
		{
			string people = peopletxtb.Text;
			string cars = carstxtb.Text;
			int totalOfPeople, totalOfCars;
			try
			{
				 totalOfPeople = GetNum(people);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			
			try
			{
				 totalOfCars = GetNum(cars);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ;
			}

		    totalOfPeople = CalcPeople(totalOfPeople);
			totalOfCars = CalcCars(totalOfCars);

			Display(totalOfPeople, totalOfCars);

		}

		private void Display(int totalOfPeople,int totalOfCars)
		{
			string result = $"人數總金額:{totalOfPeople},車輛總金額:{totalOfCars},共{totalOfPeople + totalOfCars}" ;
			resulttxtb.Text = result;
		}

		private int CalcCars(int totalOfCars)
		{
			int feePerCars = 200;
			return totalOfCars*feePerCars;
		}

		private int CalcPeople(int totalOfPeople)
		{
			int feePerPeople = 60;
			return totalOfPeople * feePerPeople;
		}

		private int GetNum(string input)
		{
			bool isInt = int.TryParse(input, out int count);
			return isInt ? count : throw new Exception("請輸入整數");
		}


	}
}
