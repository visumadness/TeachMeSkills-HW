namespace ClassLibrary1
{
    public class Army 
    {
        protected double _salary;
        protected string _position;
        protected double _workExperience;
        protected string _initials;

        public Army(double salary, string position, double workExperience, string initials)
        {
            _salary = salary;
            _position = position;
            _workExperience = workExperience;
            _initials = initials;

        }

        public void SetSalary(double newSalary)
        {
            _salary = newSalary;
        }

        public void SetPosition(string newPosition)
        {
            _position = newPosition;
        }

        public void SetWorkExperience(double newWorkExperience)
        {
            _workExperience = newWorkExperience;
        }

        public void SetInitials(string newInitials)
        {
            _initials = newInitials;
        }

        public double GetSalary()
        {
            return _salary;
        }

        public string GetPosition()
        {
            return _position;
        }

        public double GetWorkExperience()
        {
            return _workExperience;
        }

        public string GetInitials()
        {
            return _initials;
        }


    }
}