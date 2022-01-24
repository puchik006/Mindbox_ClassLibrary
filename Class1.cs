﻿using System;

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
        public float GetSquare();
        public float GetPerimeter();
    }

    public class Triangle : IFigure
    {
        private float _sideA;
        private float _sideB;
        private float _sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            _sideA = MathF.Abs(sideA);
            _sideB = MathF.Abs(sideB);
            _sideC = MathF.Abs(sideC);
        }

        public float GetPerimeter()
        {
            return (_sideA + _sideB + _sideC);
        }

        public float GetSquare()
        {
            float p = GetPerimeter() / 2;

            return (MathF.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC)));
        }

        public bool IsRectangle()
        {
            float minSide;
            float midleSide;
            float maxSide;

            //finding max side
            if (_sideA > _sideB)
            {
                maxSide = _sideA;
            }
            else
            {
                maxSide = _sideB;
            }

            if (_sideC > maxSide) maxSide = _sideC;

            //finding min side 
            if (_sideA < _sideB)
            {
                minSide = _sideA;
            }
            else
            {
                minSide = _sideB;
            }

            if (_sideC < minSide) minSide = _sideC;

            //finding midle side
            midleSide = GetPerimeter() - maxSide - minSide;

            //Pithagor theorem check
            if ((minSide * minSide + midleSide * midleSide) == maxSide * maxSide)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Circle
    {
        private float _radius;
    }
        
}
