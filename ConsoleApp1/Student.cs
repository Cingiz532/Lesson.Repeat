namespace Repeat5
{
    internal class Student
    {
        //method overloading
        public Student()
        {

        }
        public Student(int id)
        {

        }
        public Student(string FName )
        {

        }
        public Student(int id , string LName)
        {

        }
        public Student(int id, string FName, string LName)
        {
            Id = id;
            FirstName = FName;
            LastName = LName;
        }

        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
