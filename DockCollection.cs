using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace WinFormsLaba1
{
    class DockCollection
    {
        /// <summary>
        /// Словарь (хранилище) с доками
        /// </summary>
        readonly Dictionary<string, Dock<Vehicle>> dockStages;
        /// <summary>
        /// Возвращение списка названий доков
        /// </summary>
        public List<string> Keys => dockStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DockCollection(int pictureWidth, int pictureHeight)
        {

            dockStages = new Dictionary<string, Dock<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление дока
        /// </summary>
        /// <param name="name">Название дока</param>
        public void AddDock(string name)
        {
            if (!dockStages.ContainsKey(name))
                dockStages.Add(name, new Dock<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление дока
        /// </summary>
        /// <param name="name">Название дока</param>
        public void DelDock(string name)
        {
            if (dockStages.ContainsKey(name))
                dockStages.Remove(name);
        }
        /// <summary>
        /// Доступ к доку
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Dock<Vehicle> this[string ind]
        {
            get
            {
                if (dockStages.ContainsKey(ind))
                    return dockStages[ind];
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по лодках в гаванях в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write($"DockingCollection{Environment.NewLine}");
                foreach (var level in dockStages)
                {
                    //Начинаем гавань
                    sw.Write($"Docking{separator}{level.Key}{Environment.NewLine}");

                    foreach (ITransport boat in level.Value)
                    {
                        if (boat != null)
                        {
                            //если место не пустое
                            //Записываем тип лодки
                            if (boat.GetType().Name == "Boat")
                            {
                                sw.Write($"Boat{separator}");
                            }
                            if (boat.GetType().Name == "Ship")
                            {
                                sw.Write($"Ship{separator}");
                            }
                            //Записываемые параметры
                            sw.Write(boat + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Загрузка нформации по лодкам в гаванях из файла
        /// </summary>
        /// <param name="filename"></param>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            Vehicle boat = null;
            string key = string.Empty;

            using (StreamReader sr = new StreamReader(filename))
            {
                string strs = sr.ReadLine();
                if (strs != null)
                {
                    if (strs.Contains("DockingCollection"))
                    {
                        //очищаем записи
                        dockStages.Clear();
                    }
                    else
                    {
                        //если нет такой записи, то это не те данные
                        throw new FileFormatException();
                    }
                }
                while ((strs = sr.ReadLine()) != null)
                {
                    //идем по считанным записям
                    if (strs.Contains("Docking"))
                    {
                        //начинаем новую гавань
                        key = strs.Split(separator)[1];
                        dockStages.Add(key, new Dock<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(strs))
                    {
                        continue;
                    }
                    if (strs.Split(separator)[0] == "Boat")
                    {
                        boat = new Boat(strs.Split(separator)[1]);
                    }
                    else if (strs.Split(separator)[0] == "Ship")
                    {
                        boat = new Ship(strs.Split(separator)[1]);
                    }
                    if (!(dockStages[key] + boat))
                    {
                        throw new DockingNotLoadBoatException();
                    }
                }
            }
        }
    }
}
