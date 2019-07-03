using System;

namespace Lesson10_Inheritance
{
    class Employee : Person
    {
        DateTime employmentDate;
        uint personnelNumber;

        public DateTime EmploymentDate { get => employmentDate; set => employmentDate = value; }
        public uint PersonnelNumber { get => personnelNumber; set => personnelNumber = value; }

        public Employee(string fio, DateTime birthday, string address, string phone, DateTime employmentDate, uint personnelNumber) : base(fio, birthday, address, phone)
        {
            EmploymentDate = employmentDate;
            PersonnelNumber = personnelNumber;
            Birthday = birthday;
        }

        public new DateTime Birthday
        {
            get => Birthday;
            set => base.Birthday = (uint)(DateTime.Now.Year - value.Year) < Constants.MinEmployeeAge ? Errors.ErrorDateTime(5) : value;
        }

        public uint GetWorkExperience() {
            return (uint)(DateTime.Now.Year - EmploymentDate.Year);
        }

        public override string ToString()
        {
            if (this.ErrorCode > 0)
                return Errors.GetCurrentErrorInfo(this.ErrorCode);
            else
                return "Employee " + base.ToString() +
                    ". EmploymentDate: " + EmploymentDate.ToShortDateString() + " (work exp: "+ GetWorkExperience()+ ")" +
                    ", personnelNumber: " + PersonnelNumber;
        }


    }
}
