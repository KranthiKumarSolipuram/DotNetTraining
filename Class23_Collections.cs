using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DotNetTraining
{
    internal class Class23_Collections
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add(2);
            obj.Add("Kranthi");
            obj.Add(true);
            obj.Insert(2, 100);
            obj.Insert(5, 30);
            obj.Add(4);

            //obj.Remove(30);
            Console.WriteLine("The ArrayList Elements....");
            foreach (var i in obj)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine("Arraylist size is: "+obj.Count);

            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("Kranthi");
            Console.WriteLine("The stack elements are ");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            //stack generic
            Stack<int> st = new Stack<int>();
            st.Push(100);
            st.Push(21);
            Console.WriteLine("The generic stack elements are ");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            //queue data structure with the generic also
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue("Kranthi");
            queue.Enqueue(null);
            Console.WriteLine("queue elements are ...");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Hashtable ht = new Hashtable();
            ht.Add(1, 100);
            ht.Add("a", "Kranthi");
            ht.Add("b", "Reddy");
            Console.WriteLine("The hashtable elements are ....");
            //use dictionaryentry to iterate over a key value pair
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+"-->"+de.Value);
            }


            //List data structure 
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(21);

            list.Sort();
            Console.WriteLine("The list item are ...");
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }

            List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer() { Name="Kranthi",Department="SDA",Amount=23456.4f});
            Customer customer = new Customer()
            {
                Name = "Kranthi",
                Department = "SDA",
                Amount = 2345.34f

            };
            customers.Add(customer);
            Console.WriteLine();
            Console.WriteLine("The Custom customer elements:");
            foreach (Customer cust in customers)
            {
                Console.Write(cust.Name+" "+cust.Department+" "+cust.Amount);
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public float Amount { get; set; }
    }
}
