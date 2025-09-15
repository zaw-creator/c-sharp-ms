// variables that support data entry
int maxPets = 8;
int petCount = 0;   // <-- moved here, available everywhere
string? readResult;
string menuSelection = "";

// array used to store runtime data
string[,] ourAnimals = new string[maxPets, 6];

do
{
    // display the top-level menu options
    Console.Clear();
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        case "1":
            // List all pets
            for (int i = 0; i < maxPets; i++)
            {
                if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            break;

        case "2":
            // Add a new pet
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit of pets.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                break;
            }

            bool validEntry = false;
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // Get species
            do
            {
                Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry:");
                readResult = Console.ReadLine();
                if (!string.IsNullOrEmpty(readResult))
                {
                    animalSpecies = readResult.ToLower();
                    validEntry = (animalSpecies == "dog" || animalSpecies == "cat");
                }
            } while (!validEntry);

            // Build ID
            animalID = animalSpecies.Substring(0, 1) + (petCount + 1);

            // Get age
            do
            {
                Console.WriteLine("Enter the pet's age or ? if unknown:");
                readResult = Console.ReadLine();
                if (!string.IsNullOrEmpty(readResult))
                {
                    animalAge = readResult;
                    validEntry = (animalAge == "?" || int.TryParse(animalAge, out _));
                }
            } while (!validEntry);

            // Get physical description
            Console.WriteLine("Enter a physical description:");
            animalPhysicalDescription = Console.ReadLine() ?? "tbd";
            if (animalPhysicalDescription == "") animalPhysicalDescription = "tbd";

            // Get personality
            Console.WriteLine("Enter a personality description:");
            animalPersonalityDescription = Console.ReadLine() ?? "tbd";
            if (animalPersonalityDescription == "") animalPersonalityDescription = "tbd";

            // Get nickname
            Console.WriteLine("Enter a nickname:");
            animalNickname = Console.ReadLine() ?? "tbd";
            if (animalNickname == "") animalNickname = "tbd";

            // Save to array
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            petCount++;

            Console.WriteLine("Pet added successfully! Press Enter to continue.");
            Console.ReadLine();
            break;

        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back later.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            break;
    }

} while (menuSelection != "exit");
