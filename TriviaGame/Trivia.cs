using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
        //TODO: Fill out the Trivia Object
        
        //The Trivia Object will have 2 properties
        // at a minimum, Question and Answer
        public string Question { get; set; }
        
        public string Answer{ get; set; }
        
        //The Constructor for the Trivia object will
        // accept only 1 string parameter.  You will
        // split the question from the answer in your
        // constructor and assign them to the Question
        // and Answer properties
        public Trivia(string answer)
        {
            List<string> newString = new List<string>();
            newString = answer.Split('*').ToList();
            this.Question = newString[0].ToString();
            this.Answer = newString[1].ToString();
        }
        public string Ask()
        {
            return this.Question;
        }
        public string Tell()
        {
            return this.Answer.ToLower();
        }

    }
}
