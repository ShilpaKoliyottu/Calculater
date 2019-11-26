using System;
using System.Collections.Generic;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();

            Console.WriteLine("Enter words:\0Enter # to stop");

            while (true)
            {
                string word = Console.ReadLine();

                if (word != "#")
                {
                    wordList.Add(word);
                }
                else
                {
                    break;
                }
            }

            SortWithOutUsingSortMethod(wordList);
        }



        //sorting without using method

        
        public static void SortWithOutUsingSortMethod(List<string> wordList)
        {

            Console.WriteLine("---------------");
            int listCount = wordList.Count;
            for (int count = listCount - 1; count > 0; count--)
            {
                for (int i = 0; i < count; i++)
                {
                    if (wordList[i].CompareTo(wordList[i + 1]) < 0)
                    {
                        string temp = wordList[i];
                        wordList[i] = wordList[i + 1];
                        wordList[i + 1] = temp;
                    }
                }
                Console.WriteLine(wordList[count]);
            }
        }

        public static void SortUsingSortMethod(List<string> sortList)
        {
            sortList.Sort();

            foreach (var item in sortList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
