namespace mr_system.Model
{
    public class CaseOwner
    {
        private string _caseOwner;

        public CaseOwner(string Name)
        {
            _caseOwner = Name;
            
            new CaseOwner("Pelle");
            new CaseOwner("Råstof");
            new CaseOwner("Halfdan");

        }


    }
}