namespace PracticHome007
{
    public class Visa : CreditCard
    {
        public int numberAccountVisa = 121334;
        public int balanceVisa = 2500;

        public void DepositVisa()
        {
            //Console.WriteLine($"Your balance at the moment is on: {balanceVisa}");
            //Console.WriteLine("\nAmount you want for deposit: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balanceVisa += sumPlus;
            return;
            //Console.WriteLine($"Your balance after deposit money: {balanceVisa}");
        }
        public void CreditInfoCardVisa()
        {
            Console.WriteLine($"Your balnace for credit card Visa is: {balanceVisa}");
        }
    }
    
}
