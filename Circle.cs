using System;

namespace Mindbox_ClassLibrary
{
    public class Circle: IFigure
    {
        private float _radius;

        public Circle (float radius)
        {
            _radius = MathF.Abs(radius);
        }

        public float GetPerimeter()
        {
            return 2 * MathF.PI * _radius;
        }

        public float GetSquare()
        {
            return MathF.PI * _radius * _radius;
        }
    }
}
