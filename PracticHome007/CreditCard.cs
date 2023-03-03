namespace PracticHome007
{
    public class CreditCard 
    {
        public int numberAccount = 1234566;
        public int balance = 2500;

        public void Deposit()
        {
            Console.WriteLine($"Your balance at the moment is on: { balance}");
            Console.WriteLine("\nAmount you want for deposit: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balance += sumPlus;
            return;
            Console.WriteLine($"Your balance after deposit money: {balance}");
        }
        public void withdraw()
        {
            Console.WriteLine($"Your balance:  {balance}");
            Console.WriteLine($"Withdraw Money\nAmount to withdraw:");
            int sumPlus = int.Parse(Console.ReadLine());
            balance -= sumPlus;
            Console.WriteLine($"Your balance after withdraw: {balance}");
            return;
        }
        public void CreditCardInfo()
        {
            Console.WriteLine($"Number account: {numberAccount}\nYour balance at the moment is on: {balance}");
        }
        public void Test()
        {
            Visa visa = new Visa(); 
            MasterCard masterCard = new MasterCard();
            AmericanCard americanCard= new AmericanCard();
            Console.WriteLine("\nAmount you want for Visa credit card: "+(+1));
            visa.DepositVisa();
            Console.WriteLine("\nAmount you want for American Card card: "+(+2));
            americanCard.DepositAmericanCard();
            Console.WriteLine($"Withdraw Money\nAmount to withdraw:");
            masterCard.DepositMasterCard();
            Console.WriteLine("\nInfo for all 3 credit card is:");
            visa.CreditInfoCardVisa();
            americanCard.CreditInfoCardAmericanCard();
            masterCard.CreditInfoCardMasterCard();

        }
        


    }
}
