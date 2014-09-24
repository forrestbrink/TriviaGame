using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] {"banana", "apple", "orange","grape","pear","grapefruit","peach","watermelon", 
                                             "plum","pineapple", "apricot","lemon","lime","mango", "papaya","kiwi","cantaloupe",
                                             "nectarine","avocado","breadfruit","bilberry","blackberry","blueberry","boysenberry",
                                              "currant","cherry","cherimoya","cloudberry","coconut","cranberry","cucumber","damson",
                                              "date","dragonfruit","durian","eggplant","elderberry","feijoa","fig","gooseberry",
                                               "guava","huckleberry","jackfruit","lychee","honeydew","nut","olive","clementine",
                                               "mandarine", "tangarine","passionfruit","pomegranate","rasberry","tomato"};  //word Bank
            Random rnd = new Random();
            hiddenWord = words[rnd.Next(1, words.Length + 1) - 1];
            
        }
    }
}
