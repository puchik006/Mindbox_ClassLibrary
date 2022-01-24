using System;

namespace Mindbox_ClassLibrary
{
    public class Triangle : IFigure
    {
        private float _sideA;
        private float _sideB;
        private float _sideC;

        /// <summary>
        /// Provides method to calculate perimeter and square of triangle(A,B,C) by 3 sides
        /// </summary>
        /// <param name="sideA">Side A</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side C</param>
        public Triangle(float sideA, float sideB, float sideC)
        {
            _sideA = MathF.Abs(sideA);
            _sideB = MathF.Abs(sideB);
            _sideC = MathF.Abs(sideC);
        }

        /// <summary>
        /// Calculate perimeter of a triangle
        /// </summary>
        /// <returns>float perimeter</returns>
        public float GetPerimeter()
        {
            return (_sideA + _sideB + _sideC);
        }

        /// <summary>
        /// Calculate square of a triangle
        /// </summary>
        /// <returns>float perimeter</returns>
        public float GetSquare()
        {
            float p = GetPerimeter() / 2;

            return (MathF.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC)));
        }

        /// <summary>
        /// Check if triangle is orthogonal
        /// </summary>
        /// <returns>bool true - if orthogonal, false - if not</returns>
        public bool IsOrthogonal()
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
}
