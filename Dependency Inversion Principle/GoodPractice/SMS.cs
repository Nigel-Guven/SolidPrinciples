using System;

namespace SolidPrinciples.Dependency_Inversion_Principle.GoodPractice
{
    /*
     * SMS implements Message interface and is decoupled from Email class
     */
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Sent Message");
        }
    }
}
