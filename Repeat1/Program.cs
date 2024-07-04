
using Repeat1;

Student student = new Student();
//setter
student.Id = 1;
student.FullName = "Cingiz";
student.Description = "ADNSU telebesi";

//getter
Console.WriteLine($"Id si {student.Id} olan {student.FullName} , {student.Description} olaraq secildi");

Student student1 = new Student();
student1.Id = 2;
student1.FullName = "Ayxan";
student1.Description = "UNEC telebesi";

Console.WriteLine($"Id si {student1.Id} olan {student1.FullName} , {student1.Description} olaraq secildi");

Student[] students = { student, student1 };
for(int i=0;i<students.Length; i++)
{
    Console.WriteLine(students[i].Description);
}

