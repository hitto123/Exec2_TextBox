using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			DateTime input;
			try
			{
				input = IsTrueValue(textBoxinput.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
											MessageBoxIcon.Information);
				return;
			}

			if (input > now) MessageBox.Show("大於今日日期!!");
			else MessageBox.Show("小於等於今日日期!!");
		}

		private DateTime IsTrueValue(string value)
		{
			bool isTrue = DateTime.TryParse(value, out DateTime result);

			DateTime output = isTrue ? result : throw new Exception("請輸入正確的日期");

			return output;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
