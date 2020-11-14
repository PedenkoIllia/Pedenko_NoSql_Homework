using MongoDB.Driver;
using System;
using System.Linq;
using VeterinaryClinic.Initialization;
using VeterinaryClinic.Repositories;

namespace VeterinaryClinic
{
    class Program
    {
        private static PetRepository repository;

        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("VeterinaryClinic");
            repository = new PetRepository(database);

            if (repository.Count() == 0)
                repository.InsertRange(StartData.StartPets);

            bool isEnd = false;
            while(!isEnd)
            {
                Console.Clear();
                Console.WriteLine("----Veterinary clinic----");
                Console.WriteLine("1. View pet list");
                Console.WriteLine("2. Print report");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");

                bool makeChoice = false;
                while(!makeChoice)
                {
                    makeChoice = true;
                    var choice = Console.ReadKey(true);

                    switch (choice.KeyChar)
                    {
                        case '1':
                            Console.Clear();
                            ViewPetList(5);
                            break;

                        case '2':
                            Console.Clear();
                            PrintReport();
                            break;

                        case '3':
                            isEnd = true;
                            break;

                        default: 
                            makeChoice = false; 
                            break;
                    }
                }
            }
        }

        public static void ViewPetList(int pageSize)
        {
            int currentPage = 0;
            long pageCount = repository.Count() / pageSize;
            pageCount += repository.Count() % pageSize == 0 ? 0 : 1;

            do
            {
                Console.WriteLine($"----Page {currentPage + 1} of {pageCount}----");
                Console.WriteLine();
                var result = repository.Search(currentPage, pageSize);

                foreach (var pet in result)
                {
                    Console.WriteLine(pet);
                    Console.WriteLine();
                }

                currentPage++;
                if(currentPage != pageCount)
                    Console.WriteLine("Press enter to go to the next page");
                else
                    Console.WriteLine("Press enter to exit to the main menu");
                Console.ReadLine();
            }
            while (currentPage != pageCount);
        }

        public static void PrintReport()
        {
            var data = repository.GetReportData();

            Console.WriteLine("----REPORT----");
            Console.WriteLine("Now animals are registered in the clinic:");
            Console.WriteLine();

            foreach (var record in data)
            {
                Console.WriteLine(record);
                Console.WriteLine();
            }

            Console.WriteLine("----END OF REPORT----");

            Console.WriteLine("Press enter to exit to the main menu");
            Console.ReadLine();
        }
    }
}
