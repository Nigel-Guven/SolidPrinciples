
namespace SolidPrinciples.Interface_Segregation_Principle
{
    /*
     * This interface is poorly designed in that there are multiple tasks. A class that inherits this will not use all of the interface methods
     */
    internal interface BulkyInterface
    {
        void WashWheelArches();
        void WashBrakePads();
        void RemoveBrakePads();
        void RemoveBrakeDiscs();
        void PaintBrakeCalipers();
        void ChangeBrakeLine();
        void ChangeBrakeDiscs();
        void ChangeBrakePads();
        void LoosenNuts();
        void TightenNuts();
        void RemoveAirFromBrakeLines();
        void RaiseCar();
    }
}
