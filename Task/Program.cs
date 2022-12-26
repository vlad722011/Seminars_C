/* 
Только для типа int. 
Сделал это просто для себя. Придумал себе задачу и реализовал вот такой штуку.
Это программа, которая преобразует любое натурльное число N (N > 0, N - целое число),
в целлочисленный массив, используя только математические вычисления. Сначала программа, 
используя математические вычисления находит длину числа, и далее создает массив и 
заполняет его цифрами, из которых состоит исходное число.
*/

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyOfNumber = number;

//определяем длину числа.
double numberLength = Math.Log(number, 10) + 1;
int Length = (int)(numberLength);

// Создаем массив длинной равной длине числа, и заполняем его цифрами, из которых состоит число.
int[] arr = new int[Length];

// нулевой элемент массива:
int count1 = 0;
int i = 0;
while (count1 < Length - 1)
    {
       copyOfNumber = copyOfNumber / 10;
       count1++;
    }
   arr [i] = copyOfNumber;

// все остальные элементы массива.
copyOfNumber = number;
int k;
count1 = 1;
int count2 = 1;
for (k = 1; k < Length; k++)
{
    count1++;
    copyOfNumber = number;
    while (count2 < Length - 1)
    {
       copyOfNumber = copyOfNumber / 10;
       count2++;
    }
   arr [k] = copyOfNumber % 10;
   count2 = count1;
}   

// это проверка, что наш массив заполнился правильными значениями.
// выведем элементы массива в строку, через запятую.
string s = String.Join(", ", arr);
Console.WriteLine(s);        