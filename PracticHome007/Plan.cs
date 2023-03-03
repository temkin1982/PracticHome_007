namespace PracticHome007
{
    public class Plan 
    {
        public int Code { get; set; }   

        public Plan(int code)
        {
            Code = code;
        }
    }

    public class Patient 
    {
        public Plan Plan { get; set; }  

        public Patient(int code)
        {
            Plan = new Plan(code);
        }

        public void SelelctDoctor()
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
