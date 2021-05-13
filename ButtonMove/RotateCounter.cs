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
		private bool _isStop = true; // camel case
        private Button _stopButton;

        //private int _width;
        //private int _height;

        public int Width { get; set; }
        public int Height { get; set; }


        public void RotateButton(Button stopButton, Button btn, int numberOfRotate/*, int width , int height*/)
		{
            _stopButton = stopButton;
            //_width = width;
            //_height = height;

			if (_isStop == false)
			{
				btn.Text = $"◆";
                _isStop = true;
				stopButton.Text = "START";
			}
			else
			{
                _isStop = false;
				stopButton.Text = "STOP";
				ButtonMove(btn);
			}

		}

		public void ButtonMove(Button button1)
		{

			while (_isStop == false)
			{
				while (button1.Location.X > 0 && _isStop == false)
				{
					//button1.Text = (button1.Text == "OK") ? "<<<<" : "MOVE.";
					button1.Left--;
					button1.Text = "◀";
					SleepSpeed();
				}
				while (button1.Location.Y > 0 && _isStop == false)
				{
					button1.Top--;
					button1.Text = $"▲";
					SleepSpeed();
				}
				while (button1.Location.X + button1.Width <= /*_width*/ Width && _isStop == false)
				{
					button1.Left++;
					button1.Text = $"▶";
					SleepSpeed();
				}
				while (button1.Location.Y + button1.Height <= /*_height*/ Height && _isStop == false)
				{
					button1.Top++;
					button1.Text = $"▼";
					SleepSpeed();
				}
				while (button1.Location.X >= 0 && _isStop == false)
				{
					button1.Left--;
					button1.Text = "◀";
					SleepSpeed();
				}
				while (button1.Location.Y >= 0 && _isStop == false)
				{
					button1.Top--;
					button1.Text = $"▲";
					SleepSpeed();
				}
			}
		}

		private void SleepSpeed()
		{
			System.Threading.Thread.Sleep(10);
			Application.DoEvents();
			_stopButton.Focus();
		}


	}
}
