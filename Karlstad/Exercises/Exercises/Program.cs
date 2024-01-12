/*for(int i = 0; i <= 30; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/

/*Console.Write("Enter a number: ");
string input = Console.ReadLine();
int num = int.Parse(input);

if (num < 0)
{
    Console.WriteLine($"{num} is Negative");
}
else if (num > 0)
{
    Console.WriteLine($"{num} is Positive");
}
else
{
    Console.WriteLine($"{num} is zero");
}*/

/*int n = 10;
Console.Write("Enter a number: ");
string input = Console.ReadLine();
int n2 = int.Parse(input);

if(n < n2)
{
    Console.WriteLine($"{n2} is bigger");
}
else
{
    Console.WriteLine($"{n2} is smaller");
}*/


/*int counter = 0;
Console.Write("Enter a text: ");
string input = Console.ReadLine();
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Equals('A') || input[i].Equals('B'))
    {
        counter++;
    }
}
Console.WriteLine($"Number of AB is {counter}");*/

/*int[] arr = {10, 19, 14, 4, 5, 6, 9, 18, 26, 36};

for (int i = 1; i < arr.Length; ++i)
{
    int key = arr[i];
    int j = i - 1;
    while (j >= 0 && arr[j] > key)
    {
        arr[j + 1] = arr[j];
        j = j - 1;
    }
    arr[j + 1] = key;
}

int sum = 0;
foreach(int n in arr){
    sum += n;
    Console.WriteLine(n); 
}
Console.WriteLine("--------------------");
int avg = sum / arr.Length;
Console.WriteLine(avg);
Console.WriteLine("--------------------");
int num = (arr.Length - 1) / 2;
int median =  (arr[num] + (arr[num + 1])) / 2;
Console.WriteLine(median);*/

/*static void sum(int a, int b)
{
    Console.WriteLine(a + b);
}
sum(10, 20);*/

/*static bool isAlpha(char a)
{
    string letter = "abcdefghijklmnopqrstuvwxyzABCDEFJHIJKLMNOPQRSTUVWXYZ";
    return letter.Contains(a);
}

Console.WriteLine(isAlpha('a'));
Console.WriteLine(isAlpha('ش'));*/
