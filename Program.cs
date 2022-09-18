string[] GetArray(int size)
{
string[] result = new string [size];
for (int i=0; i< size; i++) {
Console.WriteLine($"Введите {i+1}-ый элемент ");
result[i]= Console.ReadLine();
}
return result; 
}

Console.WriteLine("Введите размер массива");

int size=Convert.ToInt32(Console.ReadLine());
string[] array=GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(" , " , array)}]"); 
string[] arrayNew = new string[size];
int j=0;
for (int i=0; i<size; i++) {
if (array[i].Length< 4) {
arrayNew[j] = array[i];
j++;
}
} 
string[] arrayPrint = new string[j];
Array.Copy(arrayNew, 0, arrayPrint, 0, j);

Console.WriteLine($"Результат: [{String.Join(" , " , arrayPrint)}]"); 
