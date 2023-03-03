namespace PracticHome007
{
    public class Doctor
    {
        public virtual void Treat() { }
    }
    
    public class Dentist : Doctor
    {
        public override void Treat()  
        {
            Console.WriteLine("Treat Dantist");
        }
    }
    public class Surgen : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Treat Surgen");
        }
    }
    public class Therapist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Treat Therapist");
        }
    }
   
    
        
    
    

}    
