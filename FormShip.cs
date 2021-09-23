using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLaba1
{
	public partial class FormShip : Form
	{
		private Ship ship;

		public FormShip()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShips.Width, pictureBoxShips.Height);
			Graphics gr = Graphics.FromImage(bmp);
			ship.DrawTransport(gr);
			pictureBoxShips.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			ship = new Ship();
			ship.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Brown, true, true, true, 3);
			ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShips.Width, pictureBoxShips.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			if (ship != null)
			{
				string name = (sender as Button).Name;
				switch (name)
				{
					case "buttonUp":
						ship.MoveTransport(Direction.Up);
						break;
					case "buttonDown":
						ship.MoveTransport(Direction.Down);
						break;
					case "buttonLeft":
						ship.MoveTransport(Direction.Left);
						break;
					case "buttonRight":
						ship.MoveTransport(Direction.Right);
						break;
				}
				Draw();
			}
		}
	}
}
