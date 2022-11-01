using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttoncheck_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;

			DateTime input;
			try
			{
				input = IsTrueValue(textBoxShow.Text);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
				return;
			}

			int age = now.Year - input.Year;
			if (age >= 13) MessageBox.Show("已滿13歲");
			else MessageBox.Show("未滿13歲");

		}
		private DateTime IsTrueValue(string value)
		{
			DateTime now = DateTime.Now;
			bool isTrue = DateTime.TryParse(value, out DateTime result);

			if (!isTrue) throw new Exception("請輸入正確日期");
			else if (result > now) throw new Exception("生日不能大於今天");

			return result;
		}
	}
}
