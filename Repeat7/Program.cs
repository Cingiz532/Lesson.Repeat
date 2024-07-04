
using Repeat7;
using Repeat7.ADNSU;
using Repeat7.BDU;

ADNSUStudentManager aDNSUStudentManager = new ADNSUStudentManager();
BDUStudentManager bDUStudentManager = new BDUStudentManager();
//Interface -de yuxaridaki emeliyyati aparmaq ucun vacib olaraq birinci terefi Interface-den alir
//Lakin Abstract class-larda birinci teref Abstract-da ala biler , normal class -da
aDNSUStudentManager.Add();
bDUStudentManager.Add();
aDNSUStudentManager.TestUser();
bDUStudentManager.TestUser();