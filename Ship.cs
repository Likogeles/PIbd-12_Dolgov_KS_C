using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsLaba1
{
	public class Ship : Boat
	{
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		/// <summary>
		/// Признак наличия спортивных наклеек
		/// </summary>
		public bool Lines { private set; get; }
		/// <summary>
		/// Признак наличия лобового стекла
		/// </summary>
		public bool Window { private set; get; }
		/// <summary>
		/// Признак наличия моторов
		/// </summary>
		public bool Rotors { private set; get; }
		/// <summary>
		/// Количество моторов
		/// </summary>
		public int RotorsNum { private set; get; }


		/// <summary>
		/// Инициализация свойств
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		/// <param name="lines">Признак наличия спортивных наклеек</param>
		/// <param name="window">Признак наличия спортивных наклеек</param>
		/// <param name="rotors">Признак наличия пропеллеров</param>
		/// <param name="rotorsNum">Количество моторов (1-3) (по умолчанию 1)</param>

		public Ship(int maxSpeed, float weight, Color mainColor, Color dopColor,
			bool lines, bool window, bool rotors, int rotorsNum) :
			base(maxSpeed, weight, mainColor, 130, 60)
		{
			DopColor = dopColor;
			Lines = lines;
			Window = window;
			Rotors = rotors;
			RotorsNum = rotorsNum;
		}

		/// <summary>
		/// Отрисовка катера
		/// </summary>
		/// <param name="g"></param>
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Pen doppen = new Pen(DopColor, 3);
			Brush mainBrush = new SolidBrush(MainColor);
			Brush dopBrush = new SolidBrush(DopColor);

			base.DrawTransport(g);

			PointF p1;
			PointF p2;
			PointF p3;
			PointF p4;
			PointF p5;
			PointF[] points = new PointF[5];
			

			if (Window)
			{
				g.FillRectangle(new SolidBrush(Color.Blue), (int)_startPosX + 70, (int)_startPosY + 12, 19, 36);
			}
			
			if (Lines)
			{
				p1 = new PointF((int)_startPosX + 4, (int)_startPosY + 4);
				p2 = new PointF((int)_startPosX + 96, (int)_startPosY + 4);
				p3 = new PointF((int)_startPosX + 132, (int)_startPosY + 30);
				p4 = new PointF((int)_startPosX + 96, (int)_startPosY + 56);
				p5 = new PointF((int)_startPosX + 4, (int)_startPosY + 56);
				points[0] = p1;
				points[1] = p2;
				points[2] = p3;
				points[3] = p4;
				points[4] = p5;

				g.DrawPolygon(doppen, points);
			}
            
			
			if (Rotors)
            {
				if(RotorsNum == 1)
				{
					p1 = new PointF(_startPosX - 7, _startPosY + 20);
					p2 = new PointF(_startPosX - 5, _startPosY + 24);
					p3 = new PointF(_startPosX + 0, _startPosY + 30);
					p4 = new PointF(_startPosX - 5, _startPosY + 36);
					p5 = new PointF(_startPosX - 7, _startPosY + 40);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);
				}
				else if (RotorsNum == 2)
				{
					p1 = new PointF(_startPosX - 7, _startPosY + 0);
					p2 = new PointF(_startPosX - 5, _startPosY + 4);
					p3 = new PointF(_startPosX + 0, _startPosY + 10);
					p4 = new PointF(_startPosX - 5, _startPosY + 16);
					p5 = new PointF(_startPosX - 7, _startPosY + 20);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);

					p1 = new PointF(_startPosX - 7, _startPosY + 60);
					p2 = new PointF(_startPosX - 5, _startPosY + 56);
					p3 = new PointF(_startPosX + 0, _startPosY + 50);
					p4 = new PointF(_startPosX - 5, _startPosY + 44);
					p5 = new PointF(_startPosX - 7, _startPosY + 40);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);
				}
				else if (RotorsNum == 3)
				{
					p1 = new PointF(_startPosX - 7, _startPosY + 0);
					p2 = new PointF(_startPosX - 5, _startPosY + 4);
					p3 = new PointF(_startPosX + 0, _startPosY + 10);
					p4 = new PointF(_startPosX - 5, _startPosY + 16);
					p5 = new PointF(_startPosX - 7, _startPosY + 20);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);

					p1 = new PointF(_startPosX - 7, _startPosY + 20);
					p2 = new PointF(_startPosX - 5, _startPosY + 24);
					p3 = new PointF(_startPosX + 0, _startPosY + 30);
					p4 = new PointF(_startPosX - 5, _startPosY + 36);
					p5 = new PointF(_startPosX - 7, _startPosY + 40);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);

					p1 = new PointF(_startPosX - 7, _startPosY + 60);
					p2 = new PointF(_startPosX - 5, _startPosY + 56);
					p3 = new PointF(_startPosX + 0, _startPosY + 50);
					p4 = new PointF(_startPosX - 5, _startPosY + 44);
					p5 = new PointF(_startPosX - 7, _startPosY + 40);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);
				}
			}
		}
		/// <summary>
		/// Смена дополнительного цвета
		/// </summary>
		/// <param name="color"></param>
		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
	}
}
