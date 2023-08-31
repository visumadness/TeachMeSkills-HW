namespace ClassLibrary1
{
    public class Soldier : DeputyMinisterOfDefense
    {
        private int _company;
        private string _rank;

        public Soldier(string rank,int company,
            string departmentOfTheMinister,
            string command,
            double salary,
            string position,
            double workExperience,
            string initials) : base(initials,
                                        departmentOfTheMinister,
                                        command,
                                        salary,
                                        position,
                                        workExperience)
        {
            _rank = rank;
            _company = company;
        }

        public void SetRank(string rank)
        {
            _rank = rank;
            _initials = "V.Viktorov";
        }

        public string GetRank()
        {
            return _rank;
        }

        public void SetCompany(int company)
        {
            _company = company;
        }

        public int GetCompany()
        {
            return _company;
        }
    }
}
