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
		private RotateCounter RotateClass = new RotateCounter();

		public Form1()
		{
			InitializeComponent();
		}

		public void StopButton_Click(object sender, EventArgs e)
		{
			RotateClass.RotateButton(StopButton, button1, 3, ClientSize.Width, ClientSize.Height);
		}
	}
}
