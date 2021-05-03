using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_factoriel
{
	public partial class Form1 : Form
	{
		bool is_result = false;
		string SenderButton = string.Empty;

		public Form1()
		{
			InitializeComponent();
		}

		private void button_factoriel_Click(object sender, EventArgs e)
		{
			is_result = true;
			UInt64 InputNumber;

			// ------------ Solotion 1
			//byte InputNumber = byte.Parse(textBox_input.Text);

			// ------------ Solotion 2
			bool is_number = UInt64.TryParse(richTextBox1.Text, out InputNumber);
			if (is_number == false)
			{
				richTextBox1.Text = $"Only numbers are valid !";
			}
			else
			{
				if (InputNumber > 22)
				{
					richTextBox1.Text = $"The result is too long !";
				}
				else
				{
					UInt64 result = 1;
					for (UInt64 i = 1; i <= InputNumber; i++)
					{
						result = result * i;
					}

					string result_final = String.Format("{0:n0}", result);

					richTextBox1.Text = string.Empty;
					richTextBox1.SelectionFont = new Font("Microsoft YaHei UI Light", 10, FontStyle.Italic);
					richTextBox1.SelectionColor = System.Drawing.Color.Gray;
					richTextBox1.AppendText($"{InputNumber} factoriel ={Environment.NewLine}");
					richTextBox1.SelectionFont = new Font("Microsoft YaHei UI Light", 14, FontStyle.Regular);
					richTextBox1.AppendText($"{result_final}");
				}
			}


		}


		private void button_7_Click(object sender, EventArgs e)
		{
			if (is_result == true)
			{
				richTextBox1.Text = string.Empty;
			}

			is_result = false;

			SenderButton = (sender as Button).Text;

			richTextBox1.Text = $"{richTextBox1.Text}{SenderButton}";
		}

		private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (is_result == false)
			{
				SenderButton = e.KeyValue.ToString();
			}
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			is_result = false;
			richTextBox1.Text = string.Empty;
		}


		private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
		{
			if (is_result == true)
			{
				richTextBox1.Text = string.Empty;
			}
			is_result = false;
		}
	}
}
