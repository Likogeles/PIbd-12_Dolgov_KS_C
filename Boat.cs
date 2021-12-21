using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsLaba1
{
    public class Boat : Vehicle, IEquatable<Boat>
    {
        /// <summary>
        /// Ширина отрисовки лодки
        /// </summary>
        protected readonly int BoatWidth;
        /// <summary>
        /// Высота отрисовки лодки
        /// </summary>
        protected readonly int BoatHeight;
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес лодки</param>
        /// <param name="mainColor">Основной цвет лодки</param>
        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Boat(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструктор с изменением размеров лодки
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес лодки</param>
        /// <param name="mainColor">Основной цвет лодки</param>
        /// <param name="boatWidth">Ширина отрисовки лодки</param>
        /// <param name="boatHeight">Высота отрисовки лодки</param>
        protected Boat(int maxSpeed, float weight, Color mainColor, int boatWidth, int boatHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.BoatWidth = boatWidth;
            this.BoatHeight = boatHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - BoatWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - BoatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen doppen = new Pen(Color.Brown, 3);
            Brush mainBrush = new SolidBrush(MainColor);
            Brush dopBrush = new SolidBrush(Color.Brown);

            PointF p1 = new PointF(_startPosX + 0, _startPosY + 0);
            PointF p2 = new PointF(_startPosX + 100, _startPosY + 0);
            PointF p3 = new PointF(_startPosX + 140, _startPosY + 30);
            PointF p4 = new PointF(_startPosX + 100, _startPosY + 60);
            PointF p5 = new PointF(_startPosX + 0, _startPosY + 60);
            PointF[] points = { p1, p2, p3, p4, p5 };

            g.DrawPolygon(pen, points);
            g.FillPolygon(mainBrush, points);

            g.DrawRectangle(pen, (int)_startPosX + 10, (int)_startPosY + 10, 80, 40);
            g.FillRectangle(dopBrush, (int)_startPosX + 10, (int)_startPosY + 10, 80, 40);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Boat
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Boat other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Boat boatObj))
            {
                return false;
            }
            else
            {
                return Equals(boatObj);
            }
        }
    }
}
