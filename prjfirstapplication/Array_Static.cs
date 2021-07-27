using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjfirstapplication
{
    //by default access specifier for class is internal
    class ArrayEg
    {   //by default access specifier for class is internal

        //single dimensioanl array
        //datatype[] arrayname=new datatype[size];

        string[] fruits = new string[3];
        int[] mark = { 89, 78, 90 };

     internal   void GetFruits()
        {
            for (int i = 0; i < fruits.Length;i++)
            {
                Console.WriteLine("enter the fruitname");
                
                fruits[i] = Console.ReadLine();
            }
            foreach(var fu in fruits)
            {
                Console.WriteLine("Fruitanme:{0}", fu);
            }
        }
    }
    class StringEg
    {
        internal void StringFunctionEg()
        {
            string Firstname = "Sai";
            string Name = "Monisha Devi";
            Console.WriteLine("TO UPPER:{0}",Firstname.ToUpper());
            Console.WriteLine("TO LOWER:{0}", Firstname.ToLower());
            Console.WriteLine("Length{0}",Name.Length);
            bool isContains = Name.Contains("UP");
            Console.WriteLine("Contains up:{0}",isContains);
            Console.WriteLine("substring : {0}",Name.Substring(3,5));
        }
    }
    class Array_Static
    {
        static void Main()
        {
            ArrayEg arrayEg = new ArrayEg();
            arrayEg.GetFruits();

            StringEg stringEg = new StringEg();
            stringEg.StringFunctionEg();
        }
    }
}
