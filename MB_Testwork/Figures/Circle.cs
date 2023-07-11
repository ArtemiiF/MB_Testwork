
namespace MB_Testwork.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Circle
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius cannot be less or equal zero");
            }

            Radius = radius;
        }


        protected sealed override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
