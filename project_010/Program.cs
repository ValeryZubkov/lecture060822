int [] array = {154, 122, 543, 844, 65, 96, 547, 668};
int n = array.Length;
int find = 547;
int index = 0;
while(index < n)
{
    if(array[index] == find) 
    {
        Console.WriteLine(index);
    }
    index++;
}