using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    class control
    {
        public void controler()
        {
            select();
        }
        int b = 0;
        int a = 0;
        public void select()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Make a Selection");
                Console.WriteLine("1: Create List");
                Console.WriteLine("2: Exit");

                a = Convert.ToInt32(Console.ReadLine());
                
                if (a == 2)
                    break;

                switch (a)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter Number of items.");
                        b = Convert.ToInt32(Console.ReadLine());
                        string[] item = new string[b];

                        for (int count = 0; count < b; count++)
                        {
                            Console.WriteLine("Enter Item: ");
                            item[count] = Console.ReadLine();

                        }
                        while (true)
                        {
                            int selection2;
                            //Console.Clear();
                            Console.WriteLine("Make a Selection");
                            Console.WriteLine("1: Sort Item");
                            Console.WriteLine("2: Exit");
                            selection2 = Convert.ToInt32(Console.ReadLine());
                            if (selection2 == 2)
                                break;


                            switch (selection2)
                            {
                                case 1:
                                    int a;
                                    Console.Clear();
                                    Console.WriteLine("Enter minimum number of letters in item");
                                    a = Convert.ToInt32(Console.ReadLine());

                                    var mem1 = Enumerable.Where(item, item1 => item1.Length > a);
                                    var mem2 = Enumerable.OrderBy(mem1, item1 => item1);
                                    Console.WriteLine("This Items have "+a+" or more letters");
                                    IEnumerable<string> query = Enumerable.Select(mem2, item1 => item1.ToUpper());
                                    foreach (string item1 in query)
                                    {
                                        
                                        Console.WriteLine(item1);
                                    }

                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}
