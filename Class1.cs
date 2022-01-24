using System;

namespace Mindbox_ClassLibrary
{
    //Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
    //Дополнительно к работоспособности оценим:
    //Юнит-тесты
    //Легкость добавления других фигур
    //Вычисление площади фигуры без знания типа фигуры в compile-time
    //Проверку на то, является ли треугольник прямоугольным

    interface IFigure
    {
        public float Square();
        public float Perimeter();
    }

    public class Triangle: IFigure
    {
        public float SideA;
        public float SideB;
        public float SideC;

        public float Square(float sideA, float sideB, float sideC)
        {
            return 5f;
        }

        public float Perimeter(float sideA, float  sideB, float sideC)
        {
            return (sideA + sideB + sideC);
        }


    }
}
