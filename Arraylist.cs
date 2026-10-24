using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace explain_C_
{
  public class _Arraylist
  {
    // how to creat array list 

    object[] arr;
    int _Max_size;
    int _length;

    public object this[int index]
    {
      get
      {
        return (object)this.arr[index];
      }
      set
      {
        this.arr[index] = value ;
      }
    }

    public _Arraylist(int size)
    {
      _Max_size = size;
      _length = 0;
      arr = new object[size];
    }
    public _Arraylist()
    {
      _Max_size = 10;
      _length = 0;
      arr = new object[10];
    }

    public void _insert(int index, object val)
    {
      if (Isfull())
      {
        System.Console.WriteLine("Array list if Full ");

      }
      if (index > 0 || index < _length)
      {
        System.Console.WriteLine("index out of range ");
        return;
      }

      for (int i = _length; i > index; i--)
      {
        arr[i] = arr[i - 1];

      }
      arr[index] = val;
      _length++;
    }
    public int RemoveAT(int index)
    {
      if (index > 0 && index < _length)
      {
        System.Console.WriteLine("Index out of range.");
      }
      object vval = arr[index];

      for (int i = 0; i < _length; i++)
      {
        arr[i] = arr[i + 1];

      }
      _length--;
      return index;

    }


    public int _Lenght { get => _length; private set => _Lenght = value; }

    public bool Isfull()
    {
      return _Lenght == _Max_size;
    }

    public void print()
    {
      for (int i = 0; i < arr.Length; i++)
      {
        System.Console.WriteLine(arr[i]);
      }

    }
    public void ADD(object val)
    {
      if (Isfull())
      {
        System.Console.WriteLine("the array if full ");

      }
      arr[_length] = val;
    }
    public int indexof(object val)
    {
      // we can use try and catch 

      for (int i = 0; i < _length; i++)
      {
        if (arr[i].Equals(val))
        {
          return i;
        }
      }
      return -1;
    }
    public void remove(object vall)
    {
      int index = this.indexof(vall);
      for (int i = 0; i < _length; i++)
      {
        arr[i] = arr[i + 1];
      }
      _length--;

    }




  }
}