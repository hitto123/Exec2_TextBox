using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exec2_TextBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int? rows = GetRange();
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入數字");
				return;
			}
			if (rows.Value <= 0)
			{
				MessageBox.Show("數字請大於零");
				return;
			}
			string number1 = GetNumber(rows.Value);


		}

		private string GetNumber(int rows)
		{
			if (0 <= rows && rows <= 99)
			{
				MessageBox.Show("在0-99之間");
				
			}
			else
			{
				MessageBox.Show("不在0-99之間");
			}
			return rows.ToString();
		}

		private int? GetRange()
		{
			string input = textBox1.Text;
			bool isint = int.TryParse(input, out int rows);

			if (isint)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}
	}
}
