namespace PracticHome007
{
    public class AmericanCard : CreditCard
    {
        public int numberAccountAmericanCard = 1234;
        public int balanceAmericanCard = 2500;

        public void DepositAmericanCard()
        {
           // Console.WriteLine($"Your balance at the moment is on: {balanceAmericanCard}");
           // Console.WriteLine("\nAmount you want for deposit: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balanceAmericanCard += sumPlus;
            return;
            Console.WriteLine($"Your balance after deposit money: {balanceAmericanCard}");
        }
        public void CreditInfoCardAmericanCard()
        {
            Console.WriteLine($"Your balnace for credit card AmericanCard is: {balanceAmericanCard}");
        }
    }
}
