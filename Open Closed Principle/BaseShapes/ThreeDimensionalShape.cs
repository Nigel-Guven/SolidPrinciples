
namespace SolidPrinciples.Open_Closed_Principle
{
    /*
     * Three Dimensional Base class which inherits base class
     */
    abstract class ThreeDimensionalShape : Shape
    {
        public double width;       
        public double length;
        public double height;

        public override double Area()
        {
            return width * length * height;
        }
    }
}
