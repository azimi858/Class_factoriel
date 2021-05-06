using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonChange
{
	struct ButtonActions
	{
		public Color[] Colors;
		public int SleepTime;
	}

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ChangeColorButton_Click(object sender, EventArgs e)
		{
			ButtonActions btn1;
			btn1.Colors = new Color[] { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.White };
			btn1.SleepTime = 300;

			ButtonChangeColor(btn1);
		}
		/// <summary>
		/// تغییر رنگ دکمه به رنگهای داده شده با سرعت داده شده
		/// </summary>
		/// <param name="actions">مقادیر رنگها و زنان توقف بین هر رنگ</param>
		private void ButtonChangeColor(ButtonActions actions)
		{
			foreach (Color item in actions.Colors)
			{
				ChangeColorButton.BackColor = item;
				System.Threading.Thread.Sleep(actions.SleepTime);
				Application.DoEvents();
			}
		}
	}
}
