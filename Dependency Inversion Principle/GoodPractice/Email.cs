using System;

namespace SolidPrinciples.Dependency_Inversion_Principle.GoodPractice
{
    /*
     * Email implements Message interface and is decoupled from SMS class
     */
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Sent Message");
        }
    }
}
