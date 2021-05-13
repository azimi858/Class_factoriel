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
		private RotateCounter _rotateClass = new RotateCounter();

		public Form1()
		{
			InitializeComponent();
		}

		public void StopButton_Click(object sender, EventArgs e)
		{
            _rotateClass.Width = ClientSize.Width;
            _rotateClass.Height = ClientSize.Height;

            _rotateClass.RotateButton(StopButton, button1, 3/*, ClientSize.Width, ClientSize.Height*/);
            
            
		}
	}
}
