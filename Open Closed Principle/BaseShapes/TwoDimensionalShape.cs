
namespace SolidPrinciples.Open_Closed_Principle
{
    /*
     * Two Dimensional Base class which inherits base class
     */
    abstract class TwoDimensionalShape : Shape
    {
        public double width;
        public double length;

        public override double Area()
        {
            return width * length;
        }
    }
}
