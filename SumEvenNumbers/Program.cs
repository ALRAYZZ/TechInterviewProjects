
List<int> numbers = new List<int> { 1, 2, 3, 4, 6, 8 };


List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

int result = 0;
foreach (int number in evenNumbers)
{
	result = result + number;
}

Console.WriteLine(result);


// More concise approach using the full power of LINQ functions

List<int> numbers2 = new List<int> { 1, 2, 3, 4, 6, 8 };

int result1 = numbers2.Where(n => n % 2 == 0).Sum();

Console.WriteLine(result1);