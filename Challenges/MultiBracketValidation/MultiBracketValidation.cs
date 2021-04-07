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
            bool containsBracket = false;

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
                        if (!stack.TryPop(out char o ) || o != '{')
                            return false;
                        break;
                    case ']':
                        // if (stack.Pop() != '[')
                        if (!stack.TryPop(out o) || o != '[')
                            return false;
                        break;
                    case ')':
                        if (!stack.TryPop(out o) || o != '(')
                            return false;
                        break;
                    default:
                        break;
                }
            }
            if (stack.Count != 0 || !containsBracket)
                return false;
            return true;
        }
    }
}
