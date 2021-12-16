using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsLaba1
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Dock<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест в доке
        /// </summary>
        private readonly int _maxCount;
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
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер гавани - ширина</param>
        /// <param name="picHeight">Рамзер гавани - высота</param>
        public Dock(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _currentIndex = -1;
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
            if (d._places.Count >= d._maxCount)
            {
                throw new DockingOverflowException();
            }
            if (d._places.Contains(boat))
            {
                throw new DockingAlreadyHaveException();
            }
            d._places.Add(boat);
            return true;
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
            if (index < -1 || index > d._places.Count)
            {
                throw new DockingNotFoundException(index);
            }
            T b = d._places[index];
            d._places.Remove(b);
            return b;
        }
        /// <summary>
        /// Метод отрисовки гавани
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(10 + i % 3 * _placeSizeWidth, 15 + i / 3 * _placeSizeHeight, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки гавани
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        /// <summary>
        /// Функция получения элемента из списка
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        /// <summary>
        /// Сортировка лодок в гавани
        /// </summary>
        public void Sort() => _places.Sort((IComparer<T>)new BoatComparer());
        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _currentIndex++;
            if(_currentIndex == _maxCount)
            {
                Reset();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = 0;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

    }
}
