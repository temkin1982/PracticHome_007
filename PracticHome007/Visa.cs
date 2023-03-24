namespace PracticHome007
{
    public class Visa : CreditCard
    {
        public int numberAccountVisa = 121334;
        public int balanceVisa = 2500;

        public int DepositVisa()
        {
            Console.WriteLine($"Your balance at the moment is on Visa: {balanceVisa}$");
            Console.WriteLine("\nAmount you want for deposit: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balanceVisa += sumPlus;
            return balanceVisa;
           // Console.WriteLine($"Your balance after deposit money: {balanceVisa}");
        }
        public void CreditInfoCardVisa()
        {
            Console.WriteLine($"Your balnace for credit card Visa is: {balanceVisa}$");
        }
        public void Test()
        {
            Console.WriteLine($"\nYour balnace for Visa credit card: {balanceVisa}$" );
            
        }
    }
    
}
