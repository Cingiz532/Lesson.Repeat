using Repeat6;

Student student1 = new Student();
student1.Id = 1;
student1.FullName = "Chingiz Zaidov";
student1.Age = 18;
student1.PhoneNumber = "994509876";
student1.Point = 532.1;
student1.AgeControl(24);

Teacher teacher1 = new Teacher();
teacher1.Id = 1;
teacher1.FullName = "Eli Musayev";
teacher1.Age = 36;
teacher1.PhoneNumber = "9947812876";
teacher1.Majority = "Master";

PersonManager personManager1 = new PersonManager();
personManager1.Add(student1);//Add metodu hem student-i hemde teacher-i qebul ede bildiyi ucun 
personManager1.Add(teacher1);//bu funksiya polymorphisim adlanir
