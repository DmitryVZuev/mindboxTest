namespace Mindbox
{
    public static class Figures
    {
        public static double CalcArea(string figure, params float[] parameters)
        {
            return CreateFigure(figure, parameters).Area();
        }

        /// <summary>
        /// Создание фигур        
        /// </summary>
        /// <param name="figure"></param>
        /// <param name="parameters">Подразумевается что есть описание порядка следования параметров</param>
        /// <returns></returns>

        public static Figure CreateFigure(string figure, params float[] parameters)
        {
            Figure f = figure switch
            {
                "Circle" => new Circle(parameters),
                "Triangle" => new Triangle(parameters),
                _ => throw new System.Exception("Unknown figure!")
            };
            return f;
        }
    }
}
