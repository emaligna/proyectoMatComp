﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    public class infixToPostfix
    {
        private Dictionary<char,int> precedenceDictionary;
        
        public infixToPostfix() {
            this.precedenceDictionary = new Dictionary<char, int>();
            this.precedenceDictionary.Add('(', 1);
            this.precedenceDictionary.Add('|', 2);
            this.precedenceDictionary.Add('&', 3); //concatenation character
            this.precedenceDictionary.Add('?', 4);
            this.precedenceDictionary.Add('*', 4);
            this.precedenceDictionary.Add('+', 4);
            this.precedenceDictionary.Add('^', 5);
        }

        private int getPrecedence(char c){
            int precedence;
            if (this.precedenceDictionary.ContainsKey(c)){
                 precedence = this.precedenceDictionary[c];
            }
            else{
                precedence = 6;    
            }
            return precedence;
        }

        private string formatRegEx(string regex) {
            string res = "";
            char[] regexChar = regex.ToCharArray();
            List<char> allOperators = new List<char> {'|', '?', '+', '*', '^'};
            List<char> binaryOperators = new List<char> {'^','|'};

            for (int i = 0; i < regex.Length; i++) {
                char c1 = regexChar[i];
                if (i + 1 < regex.Length){
                    char c2 = regexChar[i + 1];
                    res += c1;
                    if (!c1.Equals('(') && !c2.Equals(')') && !allOperators.Contains(c2) && !binaryOperators.Contains(c1)){
                        res += '&';
                    }
                }
            }
            res += regexChar[regex.Length - 1];
            return res;
        }


        public string convertToPostfix(string regex) {
            string postfix = "";
            Stack<char> stack = new Stack<char>();
            string formattedRegEx = formatRegEx(regex);
            Console.WriteLine("Formatted Regex: " + formattedRegEx);
            foreach (char c in formattedRegEx.ToCharArray()){
                //Console.WriteLine(stack.ToString());
                //Console.WriteLine(c);
                //Console.WriteLine(postfix);
                switch (c) {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        while (!stack.Peek().Equals('(')){
                            //Console.WriteLine(stack.Peek());
                            postfix += stack.Pop();
                        }
                        stack.Pop();
                        break;
                    default:
                        while (stack.Count > 0) {
                            char peekedChar = stack.Peek();

                            int peekedCharPrecedence = getPrecedence(peekedChar);
                            int currentCharPrecedence = getPrecedence(c);

                            if (peekedCharPrecedence >= currentCharPrecedence){
                                postfix += stack.Pop();
                            }
                            else{
                                break;
                            }
                        }
                        stack.Push(c);
                        break;
                }
            }

            while (stack.Count > 0) {
                postfix += stack.Pop();
            }
            return postfix;
        }
    }
}