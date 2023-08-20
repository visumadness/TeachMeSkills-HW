namespace ClassLibrary1
{
    public class DeputyMinisterOfDefense : Army
    { 
        private string _departmentOfTheMinister;
        private string _command;

        public DeputyMinisterOfDefense(
            string initials,
            string departmentOfTheMinister, 
            string command, 
            double salary, 
            string position, 
            double workExperience) : base(salary,
                                            position, 
                                            workExperience,
                                            initials)
        {
            _departmentOfTheMinister = departmentOfTheMinister;
            _command = command;
        }
        public void SetDepartmentOfTheMinister(string departmentOfTheMinister)
        {
            _departmentOfTheMinister = departmentOfTheMinister;
            _position = "Deputy Minister for Armaments";
            _salary = 50;
            _workExperience = 26;
        }

        public string GetDepartmentOfTheMinister()
        {
            return _departmentOfTheMinister;
        }

        public void SetCommand(string command)
        {
            _command = command;
        }

        public string Command()
        {
            return _command;
        }
    }
}
