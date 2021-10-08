using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsLaba1
{
	class Ship
	{

		/// <summary>
		/// Левая координата отрисовки автомобиля
		/// </summary>
		private float _startPosX;
		/// <summary>
		/// Правая кооридната отрисовки автомобиля
		/// </summary>
		private float _startPosY;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private int _pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private int _pictureHeight;
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		private readonly int shipWidth = 140;
		/// <summary>
		/// Высота отрисовки автомобиля
		/// </summary>
		private readonly int shipHeight = 60;
		/// <summary>
		/// Максимальная скорость
		/// </summary>
		public int MaxSpeed { private set; get; }
		/// <summary>
		/// Вес автомобиля
		/// </summary>
		public float Weight { private set; get; }
		/// <summary>
		/// Основной цвет кузова
		/// </summary>
		public Color MainColor { private set; get; }
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

		public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool lines, bool window, bool rotors, int rotorsNum)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			Lines = lines;
			Window = window;
			Rotors = rotors;
			RotorsNum = rotorsNum;
		}

		/// <summary>
		/// Установка позиции автомобиля
		/// </summary>
		/// <param name="x">Координата X</param>
		/// <param name="y">Координата Y</param>
		/// <param name="width">Ширина картинки</param>
		/// <param name="height">Высота картинки</param>
		
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureHeight = height;
			_pictureWidth = width;
		}

		/// <summary>
		/// Изменение направления пермещения
		/// </summary>
		/// <param name="direction">Направление</param>
		
		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - shipWidth)
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
					if (_startPosY + step < _pictureHeight - shipHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		
		/// <summary>
		/// Отрисовка катера
		/// </summary>
		/// <param name="g"></param>
		/// 
		
		public void DrawTransport(Graphics g)
		{
			// Отрисовка Корабля
			Pen pen = new Pen(Color.Black);
			Pen doppen = new Pen(DopColor, 3);
			Brush mainBrush = new SolidBrush(MainColor);
			Brush dopBrush = new SolidBrush(DopColor);

			PointF p1 = new PointF(_startPosX + 0, _startPosY + 0);
			PointF p2 = new PointF(_startPosX + 100, _startPosY + 0);
			PointF p3 = new PointF(_startPosX + 140, _startPosY + 30);
			PointF p4 = new PointF(_startPosX + 100, _startPosY + 60);
			PointF p5 = new PointF(_startPosX + 0, _startPosY + 60);
			PointF[] points = { p1, p2, p3, p4, p5};

			g.DrawPolygon(pen, points);
			g.FillPolygon(mainBrush, points);

			g.DrawRectangle(pen, (int)_startPosX + 10, (int)_startPosY + 10, 80, 40);
			g.FillRectangle(dopBrush, (int)_startPosX + 10, (int)_startPosY + 10, 80, 40);
			if (Window)
			{
				g.FillRectangle(new SolidBrush(Color.Blue), (int)_startPosX + 70, (int)_startPosY + 12, 19, 36);
			}
			if (Lines)
			{
				p1 = new PointF(_startPosX + 4, _startPosY + 4);
				p2 = new PointF(_startPosX + 96, _startPosY + 4);
				p3 = new PointF(_startPosX + 132, _startPosY + 30);
				p4 = new PointF(_startPosX + 96, _startPosY + 56);
				p5 = new PointF(_startPosX + 4, _startPosY + 56);
				points[0] = p1;
				points[1] = p2;
				points[2] = p3;
				points[3] = p4;
				points[4] = p5;

				g.DrawPolygon(doppen, points);

				// Наличие моторов
				// гоночные полоски и стекло

				//g.DrawRectangle(pen, (int)_startPosX + 30, (int)_startPosY + 15, 30, 30);
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
			// отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка автомобиля на него "легла")
			/*
			if (FrontSpoiler)
			{
				g.DrawEllipse(pen, _startPosX + 80, _startPosY - 6, 20, 20);
				g.DrawEllipse(pen, _startPosX + 80, _startPosY + 35, 20, 20);
				g.DrawEllipse(pen, _startPosX - 5, _startPosY - 6, 20, 20);
				g.DrawEllipse(pen, _startPosX - 5, _startPosY + 35, 20, 20);
				g.DrawRectangle(pen, _startPosX + 80, _startPosY - 6, 15, 15);
				g.DrawRectangle(pen, _startPosX + 80, _startPosY + 40, 15, 15);
				g.DrawRectangle(pen, _startPosX, _startPosY - 6, 14, 15);
				g.DrawRectangle(pen, _startPosX, _startPosY + 40, 14, 15);
				Brush spoiler = new SolidBrush(DopColor);
				g.FillEllipse(spoiler, _startPosX + 80, _startPosY - 5, 20, 20);
				g.FillEllipse(spoiler, _startPosX + 80, _startPosY + 35, 20, 20);
				g.FillRectangle(spoiler, _startPosX + 75, _startPosY, 25, 40);
				g.FillRectangle(spoiler, _startPosX + 80, _startPosY - 5, 15, 15);
				g.FillRectangle(spoiler, _startPosX + 80, _startPosY + 40, 15, 15);
				g.FillEllipse(spoiler, _startPosX - 5, _startPosY - 5, 20, 20);
				g.FillEllipse(spoiler, _startPosX - 5, _startPosY + 35, 20, 20);
				g.FillRectangle(spoiler, _startPosX - 5, _startPosY, 25, 40);
				g.FillRectangle(spoiler, _startPosX, _startPosY - 5, 15, 15);
				g.FillRectangle(spoiler, _startPosX, _startPosY + 40, 15, 15);
			}
			// и боковые
			if (SideSpoiler)
			{
				g.DrawRectangle(pen, _startPosX + 25, _startPosY - 6, 39, 10);
				g.DrawRectangle(pen, _startPosX + 25, _startPosY + 45, 39, 10);
				Brush spoiler = new SolidBrush(DopColor);
				g.FillRectangle(spoiler, _startPosX + 25, _startPosY - 5, 40, 10);
				g.FillRectangle(spoiler, _startPosX + 25, _startPosY + 45, 40, 10);
			}
			// теперь отрисуем основной кузов автомобиля
			//границы автомобиля
			g.DrawEllipse(pen, _startPosX, _startPosY, 20, 20);
			g.DrawEllipse(pen, _startPosX, _startPosY + 30, 20, 20);
			g.DrawEllipse(pen, _startPosX + 70, _startPosY, 20, 20);
			g.DrawEllipse(pen, _startPosX + 70, _startPosY + 30, 20, 20);
			g.DrawRectangle(pen, _startPosX - 1, _startPosY + 10, 10, 30);
			g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 10, 30);
			g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 70, 52);
			//задние фары
			Brush brRed = new SolidBrush(Color.Red);
			g.FillEllipse(brRed, _startPosX, _startPosY, 20, 20);
			g.FillEllipse(brRed, _startPosX, _startPosY + 30, 20, 20);
			//передние фары
			Brush brYellow = new SolidBrush(Color.Yellow);
			g.FillEllipse(brYellow, _startPosX + 70, _startPosY, 20, 20);
			g.FillEllipse(brYellow, _startPosX + 70, _startPosY + 30, 20, 20);
			//кузов
			Brush br = new SolidBrush(MainColor);
			g.FillRectangle(br, _startPosX, _startPosY + 10, 10, 30);
			g.FillRectangle(br, _startPosX + 80, _startPosY + 10, 10, 30);
			g.FillRectangle(br, _startPosX + 10, _startPosY, 70, 50);
			
		//стекла
			Brush brBlue = new SolidBrush(Color.LightBlue);
			g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 5, 5, 40);
			g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 5, 5, 40);
			g.FillRectangle(brBlue, _startPosX + 25, _startPosY + 3, 35, 2);
			g.FillRectangle(brBlue, _startPosX + 25, _startPosY + 46, 35, 2);
			//выделяем рамкой крышу
			g.DrawRectangle(pen, _startPosX + 25, _startPosY + 5, 35, 40);
			g.DrawRectangle(pen, _startPosX + 65, _startPosY + 10, 25, 30);
			g.DrawRectangle(pen, _startPosX, _startPosY + 10, 15, 30);
			// рисуем гоночные полоски
			if (SportLine)
			{
				br = new SolidBrush(DopColor);
				g.FillRectangle(br, _startPosX + 65, _startPosY + 18, 25, 15);
				g.FillRectangle(br, _startPosX + 25, _startPosY + 18, 35, 15);
				g.FillRectangle(br, _startPosX, _startPosY + 18, 20, 15);
			}
			// рисуем задний спойлер автомобиля
			if (BackSpoiler)
			{
				Brush spoiler = new SolidBrush(DopColor);
				g.FillRectangle(spoiler, _startPosX - 5, _startPosY, 10, 50);
				g.DrawRectangle(pen, _startPosX - 5, _startPosY, 10, 50);
			}
			*/

		}
		
	}
}
