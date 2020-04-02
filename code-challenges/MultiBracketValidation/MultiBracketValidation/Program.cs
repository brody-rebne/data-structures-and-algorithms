using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool MultiBracketValidation(string input)
        {
            //creating a stack to house current open bracket
            Stack bracketStack = new Stack();

            //split input string to array of individual characters
            string[] splitInput = input.Split("");

            foreach(string character in splitInput)
            {
                //if the character is an opening bracket, push its complement to the stack
                if (character == "(")
                    bracketStack.Push(")");

                else if (character == "[")
                    bracketStack.Push("]");

                else if (character == "{")
                    bracketStack.Push("}");

                //if the character matches the currently needed complement (which would be on top of the stack), pop it off
                else if (character == bracketStack.Peek())
                    bracketStack.Pop();

                //if it's a closing bracket which doesn't complement the last opening bracket, something's wrong
                else if (character == ")" || character == "]" || character == "}")
                    return false;
            }

            //if the stack is empty after going through all these, either there were no brackets or every bracket was properly closed
            if (bracketStack.IsEmpty())
                return true;

            //if values remain, the syntax must have been invalid
            else
                return false;
        }
    }
}
