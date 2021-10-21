using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsLaba1
{
    class Dock<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер пристани (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер пристани (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер гавани - ширина</param>
        /// <param name="picHeight">Рамзер гавани - высота</param>
        public Dock(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в гавань добавляется корабль
        /// </summary>
        /// <param name="p">Доки</param>
        /// <param name="boat">Добавляемый корабль</param>
        /// <returns></returns>
        public static bool operator +(Dock<T> d, T boat)
        {
            int ind = d._places.Length;
            for(int i = 0; i < d._places.Length; i++)
            {
                if(d._places[i] == null)
                {
                    ind = i;
                    break;
                }
            }
            
            if (d._places.Length > ind)
            {
                d._places[ind] = boat;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с гавани забираем корабль
        /// </summary>
        /// <param name="p">Доки</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Dock<T> d, int index)
        {
            if (index >= d._places.Length) return null;
            T b = d._places[index];
            d._places[index] = null;
            return b;
        }
        /// <summary>
        /// Метод отрисовки гавани
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            int x = 10;
            int y = 10;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g, x, y);
                x += _placeSizeWidth;
                if (x > 600)
                {
                    y += _placeSizeHeight;
                    x = 10;
                }
            }
        }
        /// <summary>
        /// Метод отрисовки разметки гавани
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++){
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
