using System;

namespace MD1
{
    class Program
    {
        private static string DATA_STORE_FILE_NAME = @"C:\Temp\data_store_toms_ozols.json";
        
        static void WriteInstructions()
        {
            Console.WriteLine("Press the corresponding key to perform an action:");
            Console.WriteLine("1: Read from data store file");
            Console.WriteLine("2: Save current data store to file");
            Console.WriteLine("3: Create fake people and lectures in the data store");
            Console.WriteLine("4: Print all people and lectures currently in the data store");
            Console.WriteLine("5: Exit");
        }

        static void WriteAndWaitPressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        static void WriteDone()
        {
            Console.WriteLine("Done!");
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                WriteInstructions();
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                Console.Clear();
                if (keyPressed.KeyChar == '5')
                {
                    break;
                }

                switch (keyPressed.KeyChar)
                {
                    case '1':
                    {
                        DataStore.ReadFromFile(DATA_STORE_FILE_NAME);
                        WriteDone();
                        break;
                    }
                    case '2':
                    {
                        DataStore.WriteStoreToFile(DATA_STORE_FILE_NAME);
                        WriteDone();
                        break;
                    }
                    case '3':
                    {
                        DataStore.CreateTestPeople();
                        DataStore.CreateTestCourseAndLectures();
                        WriteDone();
                        break;
                    }
                    case '4':
                    {
                        string dataStoreInfo = DataStore.GetStoreInfoText();
                        Console.WriteLine(dataStoreInfo);
                        break;
                    }
                }

                WriteAndWaitPressAnyKey();
                Console.Clear();
            }
        }
    }
}
