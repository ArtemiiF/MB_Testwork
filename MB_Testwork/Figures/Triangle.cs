
namespace MB_Testwork.Figures
{
    public class Triangle : Figure
    {
        private readonly Lazy<bool> isRight;

        /// <summary>
        /// Is it Right Triangle
        /// </summary>
        public bool IsRight => isRight.Value;

        /// <summary>
        /// Side A
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Side B
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Side C
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Triangle
        /// </summary>
        /// <param name="sideA">Cathetus</param>
        /// <param name="sideB">Cathetus</param>
        /// <param name="sideC">Hypotenuse</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA >= sideB + sideC ||
                sideB >= sideA + sideC ||
                sideC >= sideA + sideB)
            {
                throw new ArgumentException("One side is bigger then sum of two others. Triangle does not exist");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            isRight = new Lazy<bool>(CheckIsRightAngled);
        }
        
        private bool CheckIsRightAngled()
        {
            return (SideC * SideC) == (SideA * SideA) + (SideB * SideB) ^ (SideA * SideA) ==
                (SideC * SideC) + (SideB * SideB) ^ (SideB * SideB) == (SideC * SideC) + (SideA * SideA);
        }

        protected override double CalculateSquare()
        {
            if (this.IsRight)
            {
                return (SideA * SideB) / 2.0;
            }

            double p = (SideA + SideB + SideC) / 2.0;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
