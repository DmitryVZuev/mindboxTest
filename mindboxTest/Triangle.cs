using System;

namespace Mindbox
{
    public class Triangle : Figure
    {
        public float SideA { get; set; }
        public float SideB { get; set; }
        public float SideC { get; set; }
        public bool IsRightTriangle
        {
            get
            {
                bool CheckTriangleRight(float a, float b, float c) => Math.Abs(a * a - (b * b + c * c)) < 0.1;

                return CheckTriangleRight(SideA, SideB, SideC)
                || CheckTriangleRight(SideB, SideA, SideC)
                || CheckTriangleRight(SideC, SideB, SideA);
            }
        }       

        public Triangle(params float[] parameters)
        {
            if (parameters.Length != 3)
                throw new Exception("Incorrect count parameters");

            SideA = parameters[0];
            SideB = parameters[1];
            SideC = parameters[2];

            Validate();
        }

        public override void Validate()
        {
            bool CheckTriangleInequality(float a, float b, float c) => a < b + c;
            if (CheckTriangleInequality(SideA, SideB, SideC)
                && CheckTriangleInequality(SideB, SideA, SideC)
                && CheckTriangleInequality(SideC, SideB, SideA))
                return;
            throw new InvalidOperationException("Incorrect sides triangle!!");
        }

        public override double Area()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
