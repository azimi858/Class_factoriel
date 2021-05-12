using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMove
{
	class RotateCounter
	{
		public bool IsStop = true;

		public void RotateButton(Button StopButton, Button btn, int NumberOfRotate, int with, int height)
		{
			if (IsStop == false)
			{
				btn.Text = $"◆";
				IsStop = true;
				StopButton.Text = "START";
			}
			else
			{
				IsStop = false;
				StopButton.Text = "STOP";
				ButtonMove(btn, with, height, StopButton);
			}

		}

		public void ButtonMove(Button button1, int ClientWith, int ClientHeight, Button StopButton)
		{

			while (IsStop == false)
			{
				while (button1.Location.X > 0 && IsStop == false)
				{
					//button1.Text = (button1.Text == "OK") ? "<<<<" : "MOVE.";
					button1.Left--;
					button1.Text = "◀";
					SleepSpeed(StopButton);
				}
				while (button1.Location.Y > 0 && IsStop == false)
				{
					button1.Top--;
					button1.Text = $"▲";
					SleepSpeed(StopButton);
				}
				while (button1.Location.X + button1.Width <= ClientWith && IsStop == false)
				{
					button1.Left++;
					button1.Text = $"▶";
					SleepSpeed(StopButton);
				}
				while (button1.Location.Y + button1.Height <= ClientHeight && IsStop == false)
				{
					button1.Top++;
					button1.Text = $"▼";
					SleepSpeed(StopButton);
				}
				while (button1.Location.X >= 0 && IsStop == false)
				{
					button1.Left--;
					button1.Text = "◀";
					SleepSpeed(StopButton);
				}
				while (button1.Location.Y >= 0 && IsStop == false)
				{
					button1.Top--;
					button1.Text = $"▲";
					SleepSpeed(StopButton);
				}
			}
		}

		private void SleepSpeed(Button StopButton)
		{
			System.Threading.Thread.Sleep(10);
			Application.DoEvents();
			StopButton.Focus();
		}


	}
}
