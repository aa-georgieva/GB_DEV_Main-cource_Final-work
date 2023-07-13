// // Methods:

void ManFillArray(string [] Array) // Method to fill an array from the keyboard
{
  for (int i = 0; i < Array.Length; i++)
  {
     Console.WriteLine("Please, enter a word: ");
     Array[i] = Console.ReadLine();
  }
}

int SymbolCounter(string [] array) // Method to count number of the array element which less or equal three
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
    count++;
  }
  return count;
}

string [] FillResArray(string [] array, int num)
{
    string [] newArray = new string [num];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string [] array)
{
    Print
}


