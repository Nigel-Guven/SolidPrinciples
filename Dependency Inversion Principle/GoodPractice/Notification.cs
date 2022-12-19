using System.Collections.Generic;

namespace SolidPrinciples.Dependency_Inversion_Principle.GoodPractice
{
    /*
     * Notification is now decoupled from both Email and SMS classes
     * It is only coupled to the message interface so it only requires change in the event that Message implementation changes
     * Dependency Injection is done on messages rather than both Email and SMS classes
     */
    public class Notification
    {
        private readonly ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
