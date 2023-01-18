string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

bool again = true;
while (again)
{


    Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-16: ");

    int student = int.Parse(Console.ReadLine());
    int i = -1;

    if (student > 0 &&  student < 17)
    {

    
        Console.WriteLine($"Student {student} is {names[student + i]}. What would you like to know? Enter hometown or favorite food: ");
        string choice = Console.ReadLine();

        if (choice == "hometown") 
        {
            Console.WriteLine($"{names[student + i]} is from {towns[student + i]}.");
        }
        else if (choice == "favorite food")
        {
            Console.WriteLine($"{names[student + i]} favorite food is {foods[student + i]}.");
        }
        else
        {
            Console.WriteLine("Please try to pay attention. Acceptable options are hometown or favorite food");
            continue;
        }
    
        
        }
        Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\":");
        string choice2 = Console.ReadLine();
        if (choice2 == "n")
        {
            again = false;
            Console.WriteLine("Goodbye");
        }
        else
        {
            again = true;
        }
    }








    





