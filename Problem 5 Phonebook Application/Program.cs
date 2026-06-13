using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public class PhoneBook
    {
        private Dictionary<string, string> phonebook = new Dictionary<string, string>();
        public void Store(string name, string number)
        {
            phonebook[name] = number;
        }
        public (string name, string number) Retrieve(string name)
        {
            if(phonebook.ContainsKey(name))
            {
                return (name, phonebook[name]);
            }
            return (null,null);
        }
    }
    static void Main(string[] args)
    {
        PhoneBook phone = new PhoneBook();

        phone.Store("Sadeq","0552696357");
        phone.Store("Sadeq 2","0568515020");

        Console.WriteLine($"Sadeq Phone Number Is: {phone.Retrieve("Sadeq").number}");
        Console.WriteLine($"Sadeq Second Phone Number Is: {phone.Retrieve("Sadeq 2").number}");

    }
}

