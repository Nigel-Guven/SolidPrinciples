using System;

namespace SolidPrinciples.Dependency_Inversion_Principle
{
    /*
     * In this class the high level module for Notification is tightly coupled to Email and SMS
     * A change in implementation in one of Email or SMS classes would mean both need to be changed
     * Notification is coupled to concrete implementations
     */

    internal class DependencyInversionViolation
    {
        // Low Level Class
        class Email
        {
            public string ToAddress { get; set; }
            public string Subject { get; set; }
            public string Content { get; set; }
            public void SendEmail()
            { 
                Console.WriteLine("Sent Message"); 
            }
        }

        // Low Level Class
        class SMS
        {
            public string PhoneNumber { get; set; }
            public string Message { get; set; }
            public void SendSMS()
            {
                Console.WriteLine("Sent Message");
            }
        }


        // High Level Class
        class Notification
        {
            private Email _email;
            private SMS _sms;
            public Notification()
            {
                _email = new Email();
                _sms = new SMS();
            }

            public void Send()
            {
                _email.SendEmail();
                _sms.SendSMS();
            }
        }


    }
}
