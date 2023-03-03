using System;
using System.Diagnostics.CodeAnalysis;

namespace PracticHome007
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Class 1 q1 "Phone

            Phone proMax = new Phone(174.6);
            proMax.PhoneStats();
            proMax.receiveCall("Artem");
            Console.WriteLine("------------------------------------------------------------------");

            proMax.ShowStats();
            proMax.receiveCall("Dina", 054696895);
            Console.WriteLine("------------------------------------------------------------------");
            proMax.sendMessage();

            Console.WriteLine("------------------------------------------------------------------");
            //Class 2 q2 "Doctor"

            Patient patient = new Patient(2);
            patient.SelelctDoctor();

            Console.WriteLine("___________________________________________________________________");
            //Class 2 q3 "CreditCard"

            CreditCard creditCard = new CreditCard();
            creditCard.Deposit();
            creditCard.withdraw();
            creditCard.CreditCardInfo();
            creditCard.Test();








            //Phone obj = new Phone();
            //int number = 12;
            //Phone car = new Phone();    
            //car.Care(12);
            //car.Care(ref number );
            //car.Care((long)2);

        }






    }
}