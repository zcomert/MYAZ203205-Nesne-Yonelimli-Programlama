var numbers = new List<int>();
numbers.Add(44);
numbers.Add(23);
numbers.Add(55);
numbers.Add(61);
numbers.Add(53);

Console.WriteLine($"Size of list :{numbers.Count}");
foreach (var number in numbers)
{
    System.Console.WriteLine(number);
}

numbers.Sort();

System.Console.WriteLine(new String('-',5));
foreach (var number in numbers)
{
    System.Console.WriteLine(number);
}