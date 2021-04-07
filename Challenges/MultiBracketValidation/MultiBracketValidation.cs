using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.StackAndQueueChallenges
{
    public class MultiBracketValidation
    {
        public static bool CheckBracketBalance(string input)
        {
            Stack<char> stack = new Stack<char>();
            bool containsBracket = false; // make sure the input has brackets

            foreach(char c in input)
            {
                    
                switch (c)
                {
                    case '{':
                        stack.Push(c);
                        containsBracket = true;
                        break;
                    case '[':
                        stack.Push(c);
                        containsBracket = true;
                        break;
                    case '(':
                        stack.Push(c);
                        containsBracket = true;
                        break;
                    case '}':
                        if (!stack.TryPop(out char o ) || o != '{') // define o then run the check
                            return false;
                        break;
                    case ']':
                        if (!stack.TryPop(out o) || o != '[') // if try pop failed or pop result isnt equal to partner bracket
                            return false;
                        break;
                    case ')':
                        if (!stack.TryPop(out o) || o != '(')
                            return false;
                        break;
                }
            }
            if (stack.Count != 0 || !containsBracket) // if there are left over brackets or it didn't contain brackets
                return false;
            return true;
        }
    }
}
