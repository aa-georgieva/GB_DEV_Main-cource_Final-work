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
  System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

// // Program itself

Console.WriteLine("Hi! I can take some words from you and return only those less or equal three character. Please, enter a total number of word we'll check:"); // Program introduces itself and requests an array size
int num = Convert.ToInt32(Console.ReadLine()); // User inputs the array size
string [] wordStore = new string [num]; // Declare an initial array;
ManFillArray(wordStore); // Call the method to fill the array manually
int newArrSize = SymbolCounter(wordStore); // Call the method to count the array element which less or equal three
string [] resArray = new string [newArrSize];
resArray = FillResArray(wordStore, newArrSize); // Call the method to fill a new array with the elements which less or equal three
PrintArray(resArray); // Call the method to print the resul array