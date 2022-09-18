string[] GetArray(int size)
{
   string[] result = new string [size];
    for (int i=0; i< size; i++){
        Console.WriteLine($"Введите  {i+1}-ый элемент ");
        result[i]= Console.ReadLine();
    }
  return  result; 
}

Console.WriteLine("Введите размер массива");
int size=Convert.ToInt32(Console.ReadLine());
string[] array=GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(" , " , array)}]"); 
 
 
int count=0;
for (int i=0; i< size; i++){
        if (array[i].Length< 4){
        count=count+1;
        }
    }
int sizeNew=count;
  

string[] GetNewArray(int sizeNew){
string[] resultNew= new string[sizeNew];
int j=0;
    for (int i=0; i< size; i++){
     if (array[i].Length< 4){
        resultNew[j]= array[i];
        j++;
    }
    } 
  return  resultNew; 
 }

 

string[] arrayNew=GetNewArray(sizeNew);
Console.WriteLine($"Результат: [{String.Join(" , " , arrayNew)}]");  
 