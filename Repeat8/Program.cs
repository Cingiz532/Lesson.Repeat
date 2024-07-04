

using Repeat8.Abstract;
using Repeat8.Concrete;


Student student1 = new Student();
student1.Id = 1;
student1.FullName = "Cingiz Zaidov";
student1.Birthday = new DateTime(2013,12,18);

Student student2 = new Student();   
student2.Id = 2;
student2.FullName = "Murad Kerimli";
student2.Birthday = new DateTime(2003, 09, 24);

CheckStudentManager checkStudentManager = new CheckStudentManager();

XStudentManager xStudentManager = new XStudentManager(checkStudentManager);
YStudentManager yStudentManager = new YStudentManager(checkStudentManager);


yStudentManager.Add(student2);
xStudentManager.Add(student1);