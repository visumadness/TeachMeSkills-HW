namespace ClassLibrary1
{
    public class MinisterOfDefense : Army
    {

        private int _cabinetNumber;

        public MinisterOfDefense(string initials,
            int cabinetNumber,
            double salary,
            string position,
            double workExperience) : base(salary,
                                            position,
                                            workExperience,
                                            initials)
        {
            _initials = initials;
            _cabinetNumber = cabinetNumber;
        }

        public void SetCabinetNumber(int cabinetNumber)
        {
            _cabinetNumber = cabinetNumber;
        }

        public int GetCabinetNy()
        {
            return _cabinetNumber;
        }
    }
}
