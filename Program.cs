﻿using System;

/*
Классы и Объекты.
Задание 1. Создать класс Point, содержащий следующие члены класса:
1. Поля:
· int x, y;
2. Конструкторы, позволяющие создать экземпляр класса:
· с нулевыми координатами;
· с заданными координатами.
3. Методы, позволяющие:
· вывести координаты точки на экран;
· рассчитать расстояние от начала координат до точки;
· переместить точку на плоскости на вектор(a, b).
4. Свойство:
· позволяющее получить-установить координаты точки(доступное для чтения и записи);
· позволяющее умножить координаты точки на скаляр(доступное только для записи).
5. Индексатор, позволяющий по индексу 0 обращаться к полю x, по индексу 1 – к полю y, при других значениях индекса выдается сообщение об ошибке.
6. Перегрузку:
· операции ++ (--): одновременно увеличивает(уменьшает) значение полей х и у на 1;
· констант true и false: обращение к экземпляру класса дает значение true, если значение полей x и у совпадает, иначе false;
· операции бинарный +: одновременно добавляет к полям х и у значение скаляра.

Продемонстрировать работу класса.
*/

namespace ClassesAndObjectsTask1
{
    class Program
    {
        static void Main()
        {
            Point a = new Point();
            Console.WriteLine(a);                                        // Метод, выводящий начальные координаты точки
            if (a)                                                       // Проверка на совпадение значений координат
                Console.WriteLine("Значение координат x и y совпадает");
            else Console.WriteLine("Значение координат x и y не совпадает");
            Console.WriteLine(a.CalculateDistance());                    // Метод, рассчитывающий расстояние
            Console.WriteLine(a.MovingPoint(7,8));                       // Метод, перемещающий точку
            Console.WriteLine(a[0]);                                     // Обращение к координатам по индексу
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.Write("Операция постфиксного инкремента: ", a++);    // Перегрузка операции ++
            Console.WriteLine(a);
            Console.Write("Операция постфиксного декремента: ", a--);    // Перегрузка операции --
            Console.WriteLine(a);
            Console.WriteLine(a+50);                                     // Добавление к координатам значения скаляра

            Console.WriteLine();

            Point b = new Point(-8, 6);
            Console.WriteLine(b);
            if (b)
                Console.WriteLine("Значение координат x и y совпадает");
            else Console.WriteLine("Значение координат x и y не совпадает");
            Console.WriteLine(b.CalculateDistance());
            Console.WriteLine(b.MovingPoint(7, 8));
            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(b[2]);
            Console.Write("Операция постфиксного инкремента: ", b++);
            Console.WriteLine(b);
            Console.Write("Операция постфиксного декремента: ", b--);
            Console.WriteLine(b);
            Console.WriteLine(b + 50);

            Console.ReadKey();
        }
    }
}