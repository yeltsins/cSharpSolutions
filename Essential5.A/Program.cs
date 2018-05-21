using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5.A
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            Console.WriteLine(dictionary["II"]);
            Console.ReadKey();
        }
    }

    class Dictionary
    {
        private string[,] dict;

        public string this[string word]
        {
            get
            {
                for (int i = 0; i < dict.GetLength(0); i++)                
                    for (int j = 0; j < dict.GetLength(1); j++)                    
                        if (dict[i,j]==word)                        
                            return $"Russian: {dict[i, 0]}, English: {dict[i,1]}, Deutsch: {dict[i,2]}";           
                return "No such word in dictionary";
            }
        }

        public Dictionary()
        {
            dict = new string[4, 3]
            {
                {"Дом","House","Haus" }
                ,{"Дерево","Tree","Baum" }
                ,{"Я","I","Ich" }
                ,{"Ты","You","Du" }
            };
        }
    }
}
