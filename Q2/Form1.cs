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
			DateTime Today = DateTime.Today;

			
			string Days = GetDays();

		}

		private int? GetDays()
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

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
