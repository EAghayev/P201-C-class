using System;

namespace _28102021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            var reversedText = Reverse("salam");
            Console.WriteLine($"Task 1 result: {reversedText}");
            #endregion

            #region Task2
            string sectence = "    hello    World  ";
            Console.WriteLine($"Task 2 result: {FindWordsCount(sectence)}");
            #endregion
        }

        static string Reverse(string text)
        {
            string newText = "";

            for (int i = text.Length-1; i >=0; i--)
            {
                newText += text[i];
            }

            return newText;
        }

        static int FindWordsCount(string text)
        {
            int counter = 0;

            if (text[0] != ' ') counter++;

            for (int i = 0; i < text.Length-1; i++)
            {
                if(text[i]==' ' && text[i+1]!=' ')
                {
                    counter++;
                }
            }

            return counter;
        }

        static int[] FindIndex(string text, char chr)
        {
            int[] arr = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==chr)
                { 
                    int[] temp = arr;
                    arr = new int[arr.Length + 1];
                                        
                    
                    for (int k = 0; k < temp.Length; k++)
                    {
                        arr[k] = temp[k];
                    }
                    arr[arr.Length - 1] = i;



                }
               
            }
            return arr;
        }

        static int [] CharIndexFinder (string input , char wantedChar)
        {
            int charCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == wantedChar)
                {
                    charCount++;
                }
            }
            int[] charIndex = new int[charCount];
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == wantedChar)
                {
                    charIndex[j] = i;
                    j++;
                }
            }
            return charIndex;
        }

       
    }
}
