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
		/// 

		public override void DrawTransport(Graphics g, int x=0, int y = 0)
		{
			// Отрисовка катера
			Pen pen = new Pen(Color.Black);
			Pen doppen = new Pen(DopColor, 3);
			Brush mainBrush = new SolidBrush(MainColor);
			Brush dopBrush = new SolidBrush(DopColor);

			base.DrawTransport(g, x, y);

			
			PointF p1;
			PointF p2;
			PointF p3;
			PointF p4;
			PointF p5;
			PointF[] points = new PointF[5];
			

			if (Window)
			{
				g.FillRectangle(new SolidBrush(Color.Blue), (int)_startPosX + 70 + x, (int)_startPosY + 12 + y, 19, 36);
			}
			
			if (Lines)
			{
				p1 = new PointF((int)_startPosX + 4 + x, (int)_startPosY + 4 + y);
				p2 = new PointF((int)_startPosX + 96 + x, (int)_startPosY + 4 + y);
				p3 = new PointF((int)_startPosX + 132 + x, (int)_startPosY + 30 + y);
				p4 = new PointF((int)_startPosX + 96 + x, (int)_startPosY + 56 + y);
				p5 = new PointF((int)_startPosX + 4 + x, (int)_startPosY + 56 + y);
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
					p1 = new PointF(_startPosX - 7 + x, _startPosY + 20 + y);
					p2 = new PointF(_startPosX - 5 + x, _startPosY + 24 + y);
					p3 = new PointF(_startPosX + 0 + x, _startPosY + 30 + y);
					p4 = new PointF(_startPosX - 5 + x, _startPosY + 36 + y);
					p5 = new PointF(_startPosX - 7 + x, _startPosY + 40 + y);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);
				}
				else if (RotorsNum == 2)
				{
					p1 = new PointF(_startPosX - 7 + x, _startPosY + 0 + y);
					p2 = new PointF(_startPosX - 5 + x, _startPosY + 4 + y);
					p3 = new PointF(_startPosX + 0 + x, _startPosY + 10 + y);
					p4 = new PointF(_startPosX - 5 + x, _startPosY + 16 + y);
					p5 = new PointF(_startPosX - 7 + x, _startPosY + 20 + y);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);

					p1 = new PointF(_startPosX - 7 + x, _startPosY + 60 + y);
					p2 = new PointF(_startPosX - 5 + x, _startPosY + 56 + y);
					p3 = new PointF(_startPosX + 0 + x, _startPosY + 50 + y);
					p4 = new PointF(_startPosX - 5 + x, _startPosY + 44 + y);
					p5 = new PointF(_startPosX - 7 + x, _startPosY + 40 + y);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);
				}
				else if (RotorsNum == 3)
				{
					p1 = new PointF(_startPosX - 7 + x, _startPosY + 0 + y);
					p2 = new PointF(_startPosX - 5 + x, _startPosY + 4 + y);
					p3 = new PointF(_startPosX + 0 + x, _startPosY + 10 + y);
					p4 = new PointF(_startPosX - 5 + x, _startPosY + 16 + y);
					p5 = new PointF(_startPosX - 7 + x, _startPosY + 20 + y);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);

					p1 = new PointF(_startPosX - 7 + x, _startPosY + 20 + y);
					p2 = new PointF(_startPosX - 5 + x, _startPosY + 24 + y);
					p3 = new PointF(_startPosX + 0 + x, _startPosY + 30 + y);
					p4 = new PointF(_startPosX - 5 + x, _startPosY + 36 + y);
					p5 = new PointF(_startPosX - 7 + x, _startPosY + 40 + y);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);

					p1 = new PointF(_startPosX - 7 + x, _startPosY + 60 + y);
					p2 = new PointF(_startPosX - 5 + x, _startPosY + 56 + y);
					p3 = new PointF(_startPosX + 0 + x, _startPosY + 50 + y);
					p4 = new PointF(_startPosX - 5 + x, _startPosY + 44 + y);
					p5 = new PointF(_startPosX - 7 + x, _startPosY + 40 + y);
					points[0] = p1;
					points[1] = p2;
					points[2] = p3;
					points[3] = p4;
					points[4] = p5;
					g.FillPolygon(dopBrush, points);
				}
			}
		}
		
	}
}
