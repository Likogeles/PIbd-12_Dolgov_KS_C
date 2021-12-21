using NLog;
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
        /// Объект от класса-коллекции гаваней
        /// </summary>
        private readonly DockCollection dockCollection;
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;
        public FormDock()
        {
            InitializeComponent();
            dockCollection = new DockCollection(pictureBoxDock.Width,
            pictureBoxDock.Height);
            logger = LogManager.GetCurrentClassLogger();
        }
        /// <summary>
        /// Заполнение listBoxDocks
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxDocks.SelectedIndex;
            listBoxDocks.Items.Clear();
            for (int i = 0; i < dockCollection.Keys.Count; i++)
            {
                listBoxDocks.Items.Add(dockCollection.Keys[i]);
            }
            if (listBoxDocks.Items.Count > 0 && (index == -1 || index >=
            listBoxDocks.Items.Count))
            {
                listBoxDocks.SelectedIndex = 0;
            }
            else if (listBoxDocks.Items.Count > 0 && index > -1 && index <
            listBoxDocks.Items.Count)
            {
                listBoxDocks.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки гавани
        /// </summary>
        private void Draw()
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDock.Width,
                pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dockCollection[listBoxDocks.SelectedItem.ToString()].Draw(gr);
                pictureBoxDock.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить гавань"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название гавани", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили гавань {textBoxNewLevelName.Text}");
            dockCollection.AddDock(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Удалить гавань"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelDock_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить гавань {listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили гавань{ listBoxDocks.SelectedItem.ToString()}");
                    dockCollection.DelDock(listBoxDocks.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить лодку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormBoatConfig();
            formCarConfig.AddEvent(AddBoat);
            formCarConfig.Show();
        }

        /// <summary>
        /// Метод добавления лодки
        /// </summary>
        /// <param name="car"></param>
        private void AddBoat(Vehicle boat)
        {
            if (boat != null && listBoxDocks.SelectedIndex > -1)
            {
                try
                {
                    if ((dockCollection[listBoxDocks.SelectedItem.ToString()]) + boat)
                    {
                        Draw();
                        logger.Info($"Добавлена лодка {boat}");
                    }
                    else
                    {
                        MessageBox.Show("Лодку не удалось поставить");
                    }
                    Draw();
                }
                catch (DockingOverflowException ex)
                {
                    logger.Warn("Переполнение гавани");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (listBoxDocks.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {

                    var boat = dockCollection[listBoxDocks.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBox.Text);
                    if (boat != null)
                    {
                        FormShip form = new FormShip();
                        form.SetShip(boat);
                        form.ShowDialog();
                        logger.Info($"Изъята лодка{boat} с места{ maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (DockingNotFoundException ex)
                {
                    logger.Warn($"Не найдена лодка в доке {maskedTextBox.Text}");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли в гавань{ listBoxDocks.SelectedItem.ToString()}");
            Draw();
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                } catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    dockCollection.LoadData(openFileDialog.FileName);

                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DockingOccupiedPlaceException ex)
                {
                    logger.Warn("Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (DockingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {logger.Warn("Неизвестная ошибка при сохранении загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                dockCollection[listBoxDocks.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
