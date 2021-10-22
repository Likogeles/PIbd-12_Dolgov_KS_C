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
    public partial class FormDock : Form
    {
        /// <summary>
        /// Объект от класса-гавани
        /// </summary>
        private readonly Dock<Boat> dock;
        public FormDock()
        {
            InitializeComponent();
            dock = new Dock<Boat>(pictureBoxDock.Width,
            pictureBoxDock.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки гавани
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dock.Draw(gr);
            pictureBoxDock.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Пришвартовать судно"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, dialog.Color);
                if (dock + boat != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Док уже заполнен");
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Пришвартовать катер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Ship(100, 1000, dialog.Color, dialogDop.Color,
                    true, true, true, rnd.Next(1, 3));
                    if (dock + ship != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Док уже заполнен");
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var boat = dock - Convert.ToInt32(maskedTextBox.Text);
                if (boat != null)
                {
                    FormShip form = new FormShip();
                    form.SetShip(boat);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
