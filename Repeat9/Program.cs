
using Repeat9.Concrete;

ACompanyManager aCompanyManager = new ACompanyManager();
BCompanyManager bCompanyManager = new BCompanyManager();

Worker worker = new Worker();
worker.Id = 1;
worker.Name = "Eli";
worker.Age = 18;
worker.Majority = "Muhasib";

Worker worker1 = new Worker();
worker1.Id = 2;
worker1.Name = "Resul";
worker1.Birthday = new DateTime(2010,10,18);
worker1.Majority = "Isci";
aCompanyManager.Add(worker);
bCompanyManager.Add(worker1);
