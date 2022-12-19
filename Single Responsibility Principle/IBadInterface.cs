
namespace SolidPrinciples.Single_Responsibility_Principle
{
    /* 
     * This interface is poorly designed because it is doing four different modes of arithmetic
     */
    internal interface IBadInterface
    {
        int Addition();
        int Subtraction();
        int Multiplication();
        int Division();
    }
}
