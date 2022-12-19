
namespace SolidPrinciples.Interface_Segregation_Principle
{
    /*
     * Interfaces are segregated and it is easy to understand what exactly each interface is responsible in its tasks
     */
    internal interface Washing
    {
        void WashWheelArches();
        void WashBrakePads();       
    }
    internal interface Tighten
    {
        void TightenNuts();
    }
    internal interface Loosen
    {
        void LoosenNuts();
    }
    internal interface Remove
    {
        void RemoveBrakePads();
        void RemoveBrakeDiscs();
        void RemoveAirFromBrakeLines();
    }
    internal interface Paint
    {
        void PaintBrakeCalipers();
    }
    internal interface Raise
    {
        void RaiseCar();
    }
    internal interface Change
    {
        void ChangeBrakeLine();
        void ChangeBrakeDiscs();
        void ChangeBrakePads();
    }

}
