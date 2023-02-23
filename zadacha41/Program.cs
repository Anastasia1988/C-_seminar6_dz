// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int [] ReadInt()
{
    System.Console.WriteLine("Введите M чисел: ");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}
int numPozitiv(int[] array)
{
    
    int numberPozitiv = new int();
    int numberNegativ = new int();
    for(int i=0; i<array.Length; i++)
    {

        if(array[i]>0)
        {
            numberPozitiv ++;
        }
        else
        {
            numberNegativ ++;
        }
    }
    return numberPozitiv;
}

int[] myArray = ReadInt();
System.Console.WriteLine($"Введено положитетельных чисел :{numPozitiv(myArray)} ");




