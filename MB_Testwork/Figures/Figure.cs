using MB_Testwork.Interfaces;

namespace MB_Testwork.Figures
{
    public abstract class Figure : ISquarable
    {
        private readonly Lazy<double> square;

        public double Square => square.Value;

        protected Figure()
        {
            square = new Lazy<double>(CalculateSquare);
        }

        /// <summary>
        /// Calclulate square
        /// </summary>
        protected abstract double CalculateSquare();
    }
}
