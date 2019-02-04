using System;
using DynamicArray.Lists;

namespace DynamicArray
{
  class Program
  {
    static void Main(string[] args)
    {

      DynamicList list = new DynamicList();
      Console.WriteLine("Size: " + list.Size);
      list.Add(4);
      Console.WriteLine("Size: " + list.Size);

      list.Add(5);
      Console.WriteLine("Size: " + list.Size);

      list.GetAll();
      Console.ReadKey();
    }
  }
}
