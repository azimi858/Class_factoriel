using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int[,] NewArray = new int[2, 4];
			int dNomber = NewArray.Rank;
			int RowArray = NewArray.GetLength(0);
			int CollomnArray = NewArray.GetLength(1);
		}
	}
}
