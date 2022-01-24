using System;

namespace Mindbox_ClassLibrary
{
    public class Circle: IFigure
    {
        private float _radius;

        /// <summary>
        /// Provides method to calculate perimeter and square of circle by radius
        /// </summary>
        /// <param name="radius"></param>
        public Circle (float radius)
        {
            _radius = MathF.Abs(radius);
        }

        /// <summary>
        /// Calculate perimeter of a circle
        /// </summary>
        /// <returns>float perimeter</returns>
        public float GetPerimeter()
        {
            return 2 * MathF.PI * _radius;
        }

        /// <summary>
        /// Calculate square of a circle
        /// </summary>
        /// <returns>float square</returns>
        public float GetSquare()
        {
            return MathF.PI * _radius * _radius;
        }
    }
}
