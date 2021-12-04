using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(!dockStages.ContainsKey(name))
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
            get {
                if (dockStages.ContainsKey(ind))
                    return dockStages[ind];
                return null;
            }
        }
    }
}
