using System;

namespace DynamicArray.Lists
{
  public class DynamicList
  {
      //initialize an empty array
    private int[] arr = new int[0];

    public void Add(int n)
    {
      //First check to see whether the array is empty of not
      if (arr.Length == 0)
      {
        //create a new array with Length of 1
        arr = new int[1];
        //store the value in the array
        arr[0] = n;
      }
      else
      {
        //create a newArray which is one greater than original array
        int[] newArray = new int[arr.Length + 1];

        //copy all values of originalArray to newArray
        for (int i = 0; i < arr.Length; i++)
        {
          newArray[i] = arr[i];
        }

        //assign the incoming value to the last index of the newArray
        newArray[newArray.Length - 1] = n;
        //assign newArray as the original array
        arr = newArray;
      }
    }

    //Get the size of the array
    public int Size
    {
      get
      {
        return arr.Length;
      }
    }

    //Loop over all the elements in the array
    public void GetAll()
    {
      foreach (var i in arr)
      {
        Console.WriteLine(i);
      }
    }

  }
}