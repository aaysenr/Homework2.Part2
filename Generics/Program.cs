﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            


            List<string> sehirler = new List<string>();

            Console.WriteLine(sehirler.Count);  // ekranda 0 yazar.

            

            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");



            Console.WriteLine(sehirler.Count); //ekranda 5 yazar





            MyList<string> sehirler2 = new MyList<string>();

            Console.WriteLine(sehirler2.Count); //ekranda 0 yazar

            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");


            Console.WriteLine(sehirler2.Count); //ekranda 6 yazar

            
        }
    }


    class MyList<T> 
    {

        T[] _array;     
        T[] _tempArray; 

        public MyList()
        {

            _array = new T[0];

        }

        public void Add(T item) 
        {
            _tempArray = _array; 
            _array = new T[_array.Length + 1];  
            for (int i = 0; i < _tempArray.Length; i++)  
            {
                _array[i] = _tempArray[i];
            }
            
            _array[_array.Length - 1] = item; 
        }

       

        public int Count
        {
            get { return _array.Length; }

        }

    }
}
