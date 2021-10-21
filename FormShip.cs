﻿using System;
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
		private ITransport boat;

		/// <summary>
		/// Конструктор
		/// </summary>
		public FormShip()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Передача судна на форму
		/// </summary>
		/// <param name="ship"></param>
		public void SetShip(ITransport boat)
		{
			this.boat = boat;
			Draw();
	    }

		/// <summary>
		/// Метод отрисовки судна
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShips.Width, pictureBoxShips.Height);
			Graphics gr = Graphics.FromImage(bmp);
			boat.DrawTransport(gr);
			pictureBoxShips.Image = bmp;
		}

		/// <summary>
		/// Обработка нажатия кнопки "Создать лодку"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			boat = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true, true, 3);
			boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShips.Width, pictureBoxShips.Height);
			Draw();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Создать катер"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCreateBoat_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
			boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShips.Width, pictureBoxShips.Height);
			Draw();
		}

		/// <summary>
		/// Обработка нажатия кнопок управления
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					boat?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					boat?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					boat?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					boat?.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
    }
}
