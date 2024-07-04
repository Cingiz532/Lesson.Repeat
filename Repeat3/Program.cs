
string[] names = new string[5];

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
Console.WriteLine(numbers.Count);

foreach (int item in numbers)
{
    Console.WriteLine(item);
}