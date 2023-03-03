namespace PracticHome007
{
    public class MasterCard : CreditCard
    {
        public int numberAccountMasterCard = 12345;
        public int balanceMasterCard = 2500;

        public void DepositMasterCard()
        {
            //Console.WriteLine($"Your balance at the moment is on: {balanceMasterCard}");
            //Console.WriteLine("\nAmount you want for deposit: ");
            int sumPlus = int.Parse(Console.ReadLine());
            balanceMasterCard -= sumPlus;
            return;
            //Console.WriteLine($"Your balance after deposit money: {balanceMasterCard}");
        }
        public void CreditInfoCardMasterCard()
        {
            Console.WriteLine($"Your balnace for credit card MasterCard is: {balanceMasterCard}");
        }
    }
    
}
