int[] RandomMassiv(int[] collect)
{
int length = collect.Length;
int i = 0;
while (i < length)
 {  
     collect[i] = new Random().Next(1, 100);
     i++;
 }
return collect;
}
void PrintArray(int[] col)

{
   int count = col.Length;
   int position = 0;
   while (position < count)
   {
    Console.Write(col[position] + "  ");
    position++;
   }
}
Console.WriteLine("Задайте длину массива!" );
int dlin = Convert.ToInt32(Console.ReadLine());
int [] array = new int[dlin];
int[]mas=RandomMassiv (array);
PrintArray(mas);