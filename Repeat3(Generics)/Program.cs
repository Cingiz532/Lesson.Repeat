
using Repeat3_Generics_;

/*MyGeneric<int> myGeneric1 = new MyGeneric<int>();
myGeneric1.Add(23);
myGeneric1.Add(47);
myGeneric1.Add(47);

MyGeneric<string> myGeneric2 = new MyGeneric<string>();
myGeneric2.Add("Cingiz");
myGeneric2.Add("Fuad");
myGeneric2.Add("Murad");
Console.WriteLine(myGeneric1.Add);*/


//Calculate

Calculate calculate = new Calculate();
calculate.Plus(10, 20);//void=> geriye deyer gondermir prosta hesablayir capa verir
 int result = calculate.Minus(40,16);//hesablayirki uzerinde daha murekkeb emeliyyatlar aparilacaq
Console.WriteLine(result/3);

string FirstName = calculate.SayHello("Chingiz");
Console.WriteLine($" Salam olsun adi  {FirstName} olan telebeye ");



