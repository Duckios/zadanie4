using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Collections.Generic;

namespace pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            var flist = new ArrayList{"O",2,3,"F",5,6,"S",8,
                9,"T",11,"t",13,14,"f" };
            var slist = new ArrayList();

            for ( int i = 0; i < flist.Count; i++)
            {
                int z;
                string zs = flist[i].ToString();
                bool r = int.TryParse(zs, out z);
                if (r == false)
                {
                    if (zs == zs.ToUpper())
                    {
                        slist.Add(flist[i]);
                        flist.RemoveAt(i);
                    }
                    else flist.RemoveAt(i);
                } 
            }
            WriteLine("Заглавные: ");
            for (int i = 0; i < slist.Count; i++)
            {
                WriteLine(slist[i]);
            }
        }
    }
}
