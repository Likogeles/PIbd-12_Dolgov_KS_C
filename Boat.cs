using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsLaba1
{
    public class Boat : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки лодки
        /// </summary>
        protected readonly int BoatWidth = 130;
        /// <summary>
        /// Высота отрисовки лодки
        /// </summary>
        protected readonly int BoatHeight = 60;
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
        /// Конструкторс изменением размеров машины
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
    }
}
