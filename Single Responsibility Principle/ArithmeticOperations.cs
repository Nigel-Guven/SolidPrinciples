
using System.Dynamic;
using System.Runtime.InteropServices;

namespace SolidPrinciples.Single_Responsibility_Principle
{
    /* 
     * This class implements the four arithmetic interfaces to perform mathematical operations on two numbers
     */
    public class ArithmeticOperations : IAdditionInterface, ISubtractionInterface, IMultiplicationInterface, IDivisionInterface
    {
        public int x;
        public int y;

        public ArithmeticOperations() {}

        public int Addition()
        {
            return x + y;
        }
        public int Subtraction()
        {
            return x - y;
        }
        public int Multiplication()
        {
            return x * y;
        }
        public int Division()
        {
            return x/y;
        }
    }
}
