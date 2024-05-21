using System;
using System.Linq;
using System.Text;

namespace S.week5
{
    
    class Words
    {
        private string word;
        

        public Words(string word_1)
        {
            word = word_1;
        }

        public string SetWord(string w1)
        {
            word = w1;
            return word;
        }

        public int Count()
        {
            return word.Length;
        }

        public int Count(char c)
        {
            int counts = 0;
            foreach (char a in word)
            {
                if (a == c) counts++;
            }

            return counts;

        }

        public string Replace(char input, char c)
        {

            word = word.Replace(input, c);
            return word;

        }

        public string ThisIs()
        {
            
            String text = "This is good";
            StringBuilder mySB = new StringBuilder(text);
            mySB.Append("This is a good start.");
            mySB.Append("This is a good end.");
            mySB.Append("This is not a good end.");
            Console.WriteLine(mySB);
            return text;
        }
        static int NrOfChars = 256;

        public Boolean isAnagram(string word2)
        {

            int[] count1 = new int[NrOfChars];
            int[] count2 = new int[NrOfChars];
            int i;

            for (i = 0; i <word.Length && i <word2.Length; i++)
            {
                count1[word[i]]++;
                count2[word2[i]]++;
            }

            if (word.Length != word2.Length)
                return false;

            for (i = 0; i < NrOfChars; i++)
                if (count1[i] != count2[i])
                    return false;
 
            return true;
           
        }

        public Boolean isAnagramIgnoreCase(string word2)
        {
            
            int[] count1 = new int[NrOfChars];
            int[] count2 = new int[NrOfChars];
            int i;

            for (i = 0; i < word.Length && i < word2.Length; i++)
            {
                if (word.Equals(word2, StringComparison.OrdinalIgnoreCase))
                {
                    count1[word[i]]++;
                    count2[word2[i]]++;
                }
                
            }

            if (word.Length != word2.Length)
                return false;

            for (i = 0; i < NrOfChars; i++)
                if (count1[i] != count2[i])
                    return false;

            for (i = 0; i < NrOfChars; i++)
                if (word.Equals(word2, StringComparison.OrdinalIgnoreCase))
                    return true;

             
            return true;
        }
        public static Boolean IsLetterOrDigit(string s1)
        {
            return true;
        }
        
        public Boolean isAnagramIgnoreCaseNSpace(String word2)
        {


            bool result;
            string str1 = word;
            string str2 = word2;
            result = char.IsLetterOrDigit(str1);
            /*int[] count1 = new int[NrOfChars];
            int[] count2 = new int[NrOfChars];
            int i;

            for (i = 0; i < word.Length && i < word2.Length; i++)
            {
                if (word.Equals(word2, StringComparison.OrdinalIgnoreCase))
                {
                    if (IsLetterOrDigit(word, word2))
                    {
                        count1[word[i]]++;
                        count2[word2[i]]++;
                    }
                }

            }

            if (word.Length != word2.Length)
                return false;

            for (i = 0; i < NrOfChars; i++)
                if (count1[i] != count2[i])
                    return false;

            /*for (i = 0; i < NrOfChars; i++)
                if (word.Equals(word2, StringComparison.OrdinalIgnoreCase))
                    return true;*/


            return true;
        }

        public override string ToString()
        {
            string text = null;
            text += word + isAnagramIgnoreCaseNSpace("Cold outside?");
            return text;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Write Word: ");
            Words w1 = new Words(Console.ReadLine());
            //w1.SetWord(Console.ReadLine());

            Console.WriteLine(w1.ToString());
            w1.Replace('a', 'x');
            Console.WriteLine(w1.ToString());
            w1.Count('a');
            Console.WriteLine(w1.ToString());*/

            Words w2 = new Words("Cool IT, dudes!");
            w2.isAnagramIgnoreCase("Cold outside?");
            Console.WriteLine(w2);
        }
    }
}
