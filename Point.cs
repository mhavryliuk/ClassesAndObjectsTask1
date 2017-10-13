using System;

namespace ClassesAndObjectsTask1
{
    class Point
    {
        // Поля
        int x, y;

        // Конструктор, позволяющий создать экземпляр класса с нулевыми координатами.
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Конструктор, позволяющий создать экземпляр класса с заданными координатами.
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Метод, выводящий координаты точки на экран.
        public override string ToString() => "Координаты точки: (" + x + "," + y + ")";

        // Метод, расчитывающий расстояние от начала координат до точки.
        public string CalculateDistance()
        {
            double dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return $"Расстояние от начала координат до точки ({x},{y}): {dist}";
        }

        // Метод, перемещающий точку на плоскости на вектор (a, b).
        public string MovingPoint(int a, int b)
        {
            x += a;
            y += b;
            return $"({x},{y}) - координаты точки после ее перемещения на вектор ({a},{b})";
        }

        // Свойство, позволяющее получить-установить координаты точки (доступные для чтения и записи).
        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        // Свойство, позволяющее умножить координаты точки на скаляр (доступное только для записи).
        public int Scalar
        {
            set
            {
                x *= value;
                y *= value;
            }
        }

        // Индексатор, позволяющий по индексу 0 обращаться к полю x, по индексу 1 - к полю y, 
        // при других значениях индекса выдается сообщение об ошибке.
        public string this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return $"Индекс [0] соответствует координате x: {x}";
                }
                else
                {
                    if(i==1)
                    {
                        return $"Индекс [1] соответствует координате y: {y}";
                    }
                    else
                    {
                        return $"Индекс [{i}] является недопустимым";
                    }
                }
            }
        }

        // Перегрузка операции ++: одновременно увеличивает значение полей x и y на 1.
        public static Point operator ++(Point point) => new Point(point.x + 1, point.y + 1);

        // Перегрузка операции --: одновременно уменьшает значение полей x и y на 1.
        public static Point operator --(Point point) => new Point(point.x - 1, point.y - 1);

        // Перегрузка констант true и false: 
        // обращение к экземпляру класса дает значение true, если значение полей x и y совпадает, иначе false.
        public static bool operator true(Point b)
        {
            if (b.x!=b.y)
            {
                return false;
            }
            return true;
        }

        public static bool operator false(Point b)
        {
            if (b.x == b.y)
            {
                return true;
            }
            return false;
        }

        // Перегрузка операции бинарный +: одновременно добавляет к полям x и y значение скаляра.
        public static Point operator +(Point point, int scalar) => new Point(point.x + scalar, point.y + scalar);
    }
}