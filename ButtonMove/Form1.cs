using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMove
{
	public partial class Form1 : Form
	{
		bool IsStop = true;
		public Form1()
		{
			InitializeComponent();
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			if (IsStop == false)
			{
				button1.Text = $"◆";
				IsStop = true;
				StopButton.Text = "START";
			}
			else
			{
				IsStop = false;
				StopButton.Text = "STOP";
				ButtonMove();
			}


		}




		private void SleepSpeed()
		{
			System.Threading.Thread.Sleep(10);
			Application.DoEvents();
			StopButton.Focus();
		}


		private void ButtonMove()
		{
			while (IsStop == false)
			{
				while (button1.Location.X > 0 && IsStop == false)
				{
					//button1.Text = (button1.Text == "OK") ? "<<<<" : "MOVE.";
					button1.Left--;
					button1.Text = "◀";
					SleepSpeed();
				}
				while (button1.Location.Y > 0 && IsStop == false)
				{
					button1.Top--;
					button1.Text = $"▲";
					SleepSpeed();
				}
				while (button1.Location.X + button1.Width <= ClientSize.Width && IsStop == false)
				{
					button1.Left++;
					button1.Text = $"▶";
					SleepSpeed();
				}
				while (button1.Location.Y + button1.Height <= ClientSize.Height && IsStop == false)
				{
					button1.Top++;
					button1.Text = $"▼";
					SleepSpeed();
				}
				while (button1.Location.X >= 0 && IsStop == false)
				{
					button1.Left--;
					button1.Text = "◀";
					SleepSpeed();
				}
				while (button1.Location.Y >= 0 && IsStop == false)
				{
					button1.Top--;
					button1.Text = $"▲";
					SleepSpeed();
				}
			}
		}


	}
}
