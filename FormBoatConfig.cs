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
    public partial class FormBoatConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная лодка
        /// </summary>
        Vehicle boat = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddBoat;

        public FormBoatConfig()
        {
            InitializeComponent();
            colorPanel1.MouseDown += panelColor_MouseDown;
            colorPanel2.MouseDown += panelColor_MouseDown;
            colorPanel3.MouseDown += panelColor_MouseDown;
            colorPanel4.MouseDown += panelColor_MouseDown;
            colorPanel5.MouseDown += panelColor_MouseDown;
            colorPanel6.MouseDown += panelColor_MouseDown;
            colorPanel7.MouseDown += panelColor_MouseDown;
            colorPanel8.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать лодку
        /// </summary>
        private void DrawBoat()
        {
            if (boat != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.SetPosition(5, 5, pictureBoxBoat.Width, pictureBoxBoat.Height);
                boat.DrawTransport(gr);
                pictureBoxBoat.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddBoat == null)
            {
                eventAddBoat = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddBoat += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBoat_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelBoat_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelBoat_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычная лодка":
                    boat = new Boat((int)numericUpDownSpeed.Value, (int)numericUpDownWeigth.Value,
                        Color.White);
                    break;
                case "Катер":
                    boat = new Ship((int)numericUpDownSpeed.Value, (int)numericUpDownWeigth.Value,
                        Color.White, Color.Black, checkBoxLines.Checked, checkBoxWindow.Checked,
                        checkBoxRotors.Checked, (int)numericUpDownRotors.Value);
                    break;
            }
            DrawBoat();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null) {
                boat.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBoat();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat.GetType() == typeof(Ship))
            {
                (boat as Ship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawBoat();
            }
        }

        /// <summary>
        /// Добавление лодки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddBoat?.Invoke(boat);
            Close();
        }
    }
}
