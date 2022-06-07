
Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");

// store int
int numPeople = int.Parse(Console.ReadLine());

if(numPeople > 6)
{
    Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
}
else if(numPeople > 0 && numPeople <= 6)
{
    Console.WriteLine("A table for " + numPeople + " Please follow me and take a seat. Let's get everyone started with some drinks. Weve got water or coffee.");

    //store amounts of waters/coffee's

    int waters = 0;

    int coffees = 0;

    for (int i = 1; i <= numPeople; i++)
    {
        Console.WriteLine("Alright, Person number " + i + " water or coffee?");
        string choice = Console.ReadLine().Trim();
        if(choice == "water")
        {
            Console.WriteLine(choice + ", good choice!");
            waters += 1;
        }
        else if (choice == "coffee")
        {
            Console.WriteLine(choice + ", good choice!");
            coffees += 1;
        }
        else
        {
            Console.WriteLine("We don't have that. No drink for you!");
        }

        

    }
    //  calculate total
    double buffetAmt = numPeople * 9.99;
    double coffeeAmt = coffees * 2.00;
    double totalCost = buffetAmt + coffeeAmt;

    Console.WriteLine("Okay, so that's " + coffees + " coffees and " + waters + " waters. I'll be right back. Feel free to grab your food!");
    Console.WriteLine("Here's your bill! Total price: $"+ totalCost);

}