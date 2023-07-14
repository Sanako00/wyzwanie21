
int number = 31032000;
string numberAsString = number.ToString();
char[] chars = numberAsString.ToArray();

int[] counter = new int[10];
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (char c in chars)
{
    if (c == '0') { counter[0]++; }
    else if (c == '1') { counter[1]++; }
    else if (c == '2') { counter[2]++; }
    else if (c == '3') { counter[3]++; }
    else if (c == '4') { counter[4]++; }
    else if (c == '5') { counter[5]++; }
    else if (c == '6') { counter[6]++; }
    else if (c == '7') { counter[7]++; }
    else if (c == '8') { counter[8]++; }
    else if (c == '9') { counter[9]++; }
}
Console.WriteLine("Ilość znaków w liczbie " + number);
Console.WriteLine(numbers[0] + "=>" + counter[0]);
Console.WriteLine(numbers[1] + "=>" + counter[1]);
Console.WriteLine(numbers[2] + "=>" + counter[2]);
Console.WriteLine(numbers[3] + "=>" + counter[3]);
Console.WriteLine(numbers[4] + "=>" + counter[4]);
Console.WriteLine(numbers[5] + "=>" + counter[5]);
Console.WriteLine(numbers[6] + "=>" + counter[6]);
Console.WriteLine(numbers[7] + "=>" + counter[7]);
Console.WriteLine(numbers[8] + "=>" + counter[8]);
Console.WriteLine(numbers[9] + "=>" + counter[9]);
