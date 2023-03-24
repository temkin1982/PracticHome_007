namespace PracticHome007
{
    public class Plan 
    {
        public int Code { get; set; }  //ato sosdana dla tavo shtob bil Plan Patcientu vet sam potcient ne mojet sebe sosdat plan! 

        public Plan(int code)
        {
            Code = code;
        }
    }

    public class Patient     
    {
        public Plan Plan { get; set; }  //sdes potcient mojet imet kakoito plan toist plan lichenie ato svoistva

        public Patient(int code)     // ato konstruktar vnutri classa potcienta   
        {
            Plan = new Plan(code); // ato dla vivoda svoistva plan na konsul uje v programme naznachenie coda
        }

        public void SelelctDoctor() // ato dla tvao shtob posle opridelenie coda idot obrachenie k vrachu
                                    // i tam propisina metod kak lichit on opridelon v drugom classe Classe dlya vrachei
        {                           
            int code = Plan.Code;  

            switch (code)
            {
                case 1:
                    Surgen surgen = new Surgen();
                    surgen.Treat();
                    break;
                    case 2:
                    Dentist dentist = new Dentist();
                    dentist.Treat();    
                    break;
                   default:
                    Therapist therapist = new Therapist();
                    therapist.Treat();
                    break;
                    

                   
            }
        }
    }
}
