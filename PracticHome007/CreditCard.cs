namespace PracticHome007
{
    public class CreditCard 
    {
        public int numberAccount = 1234566;
        public int balance = 2500;

        public int Deposit()
        {
            Console.WriteLine($"Your balance at the moment is on CreditCard: { balance}$");
            Console.WriteLine("\nAmount you want for deposit: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balance += sumPlus;
            return balance;
            Console.WriteLine($"Your balance after deposit money: {balance}$");
        }
        public int withdraw()
        {
            Console.WriteLine($"Your balance:  {balance}$");
            Console.WriteLine($"Withdraw Money\nAmount to withdraw:");
            int sumPlus = int.Parse(Console.ReadLine());
            balance -= sumPlus;
            Console.WriteLine($"Your balance after withdraw: {balance}$");
            return balance;
        }
        public void CreditCardInfo()
        {
            Console.WriteLine($"Number account: {numberAccount}\nYour balance at the moment is on CreditCard: {balance}$");
        }
        
        


    }
}
