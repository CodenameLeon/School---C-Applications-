using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_Count___REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt User
            Console.WriteLine("Novel Choices:\n Around_the_World_in_Eighty_Days\n Gettysburg_Address\n Moby_Dick\n " );
            Console.WriteLine("Please Enter the Name of the Novel below:");
            //Get user input
            string userInput = Console.ReadLine();

            int wordCount = 0;

            string[] words;

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader($"Novels/{userInput}.txt"))
                {

                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while (!sr.EndOfStream)
                    {
                        //Reads data on SteamReader object 'sr' and returns the data as a string
                        string line = sr.ReadLine();

                        //take off any leading and/or trailing whitespace
                        line.Trim();

                        //Split on Single space - add to char array, then Remove Empty Entries
                        words = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        //and just add how many of them there is
                        wordCount += words.Length;

                    }

                    //close File after finish/end
                    sr.Close();

                    //Display total word count
                    Console.WriteLine($"\nTotal amount of words is: {wordCount:n0}");
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}