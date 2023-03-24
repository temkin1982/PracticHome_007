namespace PracticHome007
{
    public class MasterCard : CreditCard
    {
        public int numberAccountMasterCard = 12345;
        public int balanceMasterCard = 2500;

        public int DepositMasterCard()
        {
            Console.WriteLine($"Your balance at the moment is on MasterCard: {balanceMasterCard}$");
            Console.WriteLine("\nAmount you want for deposit MasterCard: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balanceMasterCard -= sumPlus;
            return balanceMasterCard;
           
        }
        public void CreditInfoCardMasterCard()
        {
            Console.WriteLine($"Your balnace for credit card MasterCard is: {balanceMasterCard}$");
        }
        public void Test()
        {
            
            Console.WriteLine($"\nAfter withdraw from MasterCard balance is: {balanceMasterCard}$");
        }
    }
    
}
