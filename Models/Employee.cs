namespace Task_EMPLOYEE.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }


        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - DateOfBirth.Year;

                // Adjust age if birthday hasn't occurred yet this year
                if (DateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }

        public string Salary { get; set; }
        public string Department { get; set; }


    }
}
