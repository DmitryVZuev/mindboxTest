using System;
using System.Drawing;

namespace Mindbox
{
    public class Circle : Figure
    {
        public PointF Center { get; set; }
        public float Radius { get; set; }

        public Circle(params float[] parameters)
        {
            if (parameters.Length != 3)
                throw new Exception("Incorrect count parameters");

            Center = new PointF(parameters[0], parameters[1]);
            Radius = parameters[2];
        }
        
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Validate()
        {
            if (Radius < 0)
                throw new Exception("Incorrect radius!");
        }
    }
}
