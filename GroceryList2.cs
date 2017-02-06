using System;

class GroceryList2
{
  static void Main()
  {
    string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice" };

    Console.WriteLine("My grocery list:");
    for (int index = 0; index < myGroceryList.Length; index++)
    {
      Console.WriteLine(myGroceryList[index]);
    }
  }
}
