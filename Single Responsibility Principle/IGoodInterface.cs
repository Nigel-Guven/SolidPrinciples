
namespace SolidPrinciples.Single_Responsibility_Principle
{
    /*
     * These interfaces are good practice in that they are clearly specific and understood in their task 
     */
    interface IAdditionInterface
    { 
        int Addition();
    }

    interface ISubtractionInterface
    {
        int Subtraction();
    }

    interface IMultiplicationInterface
    {
        int Multiplication();
    }

    interface IDivisionInterface
    {
        int Division();
    }
}
