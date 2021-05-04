using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_divisors_Click(object sender, EventArgs e)
		{
			listBox_result.Items.Clear();

			UInt64 InputNumber;
			UInt64.TryParse(textBox_input.Text, out InputNumber);

			string result = string.Empty;
			int DivisorCount = 0;

			for (UInt64 i = 1; i <= InputNumber; i++)
			{
				if (InputNumber % i == 0)
				{
					DivisorCount ++;
					listBox_result.Items.Add($"{listBox_result.Text}{i}");
				}

				label_count.Text = $"Count = {DivisorCount.ToString()}";

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label_count.Text = string.Empty;
			textBox_input.Text = string.Empty;
		}
	}
}
