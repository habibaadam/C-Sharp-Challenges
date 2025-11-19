// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, C#!");
// Console.WriteLine("Learning from scratch");
// Console.WriteLine("Logical thinking versus pure brute memory");
// Console.WriteLine("To be disgustingly educated is the prize");
// Console.WriteLine("Who even cares?");
// Console.WriteLine("Hi " + "What is love?");

/*
Bread is ready.
Who is the bread for?
RB
Noted: RB got bread.

Objectives:
• Make a program that runs as shown above, including taking a name from the user.

Challenge The Thing Namer 3000 100 XP
    As you walk through the city of Commenton, admiring its forward-slash-based architectural buildings, a
    young man approaches you in a panic. “I dropped my Thing Namer 3000 and broke it. I think it’s mostly
    working, but all my variable names got reset! I don’t understand what they do!” He shows you the
    following program:
    Console.WriteLine("What kind of thing are we talking about?");
    string a = Console.ReadLine();
    Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
    string b = Console.ReadLine();
    string c = "of Doom";
    string d = "3000";
    Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
    “You gotta help me figure it out!”
    Objectives:
    • Rebuild the program above on your computer.
    • Add comments near each of the four variables that describe what they store. You must use at least
    one of each comment type
    • Find the bug in the text displayed and fix it.

   Challenge The Variable Shop 100 XP
   You see an old shopkeeper struggling to stack up variables in a window display. “Hoo-wee! All these
   variable types sure are exciting but setting them all up to show them off to excited new programmers
   like yourself is a lot of work for these aching bones,” she says. “You wouldn’t mind helping me set up this
   program with one variable of every type, would you?”
   Objectives:
   • Build a program with a variable of all fourteen types described in this level.
   • Assign each of them a value using a literal of the correct type.
   • Use Console.WriteLine to display the contents of each variable.


Challenge The Variable Shop Returns 50 XP
“Hey! Programmer!” It’s the shopkeeper from the Variable Shop who hobbles over to you. “Thanks to
your help, variables are selling like RAM cakes! But these people just aren’t any good at programming.
They keep asking how to modify the values of the variables they’re buying, and… well… frankly, I have no
clue. But you’re a programmer, right? Maybe you could show me so I can show my customers?”
Objectives:
• Modify your Variable Shop program to assign a new, different literal value to each of the 14 original
variables. Do not declare any additional variables.
• Use Console.WriteLine to display the updated contents of each variable.
*/


public class StartChallenges {
    public static void Bread() {
        string name;
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is the bread for?");
        name = Console.ReadLine();
        Console.WriteLine("Noted: " + name + " got bread.");
    }

    public static void ThingNamer() {
        Console.WriteLine("What kind of thing are we talking about?");
        string item = Console.ReadLine();  // stores what the item is
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string item_desc = Console.ReadLine(); // stores a description of the  trew item
        Console.WriteLine("The " + item_desc + " " + item + " " + "of Doom 3000!");
    }

    public static void VariableShop() {
        int aNormalnumber = 23;
        bool iTry = true;
        uint abigNum = 12345677U;
        ulong averyBigNum = 1000000000000UL;
        byte aByte = 34;
        sbyte anSByte = -54;
        ushort num = 23456;
        long aBigNegNum = -1000000000000;
        short aNegNum = -1234;
        char justALetter = 'l';
        float pointer = 1f;
        double dPointer = 1.2;
        string justAString = "Just chilling with #C";
        decimal ddPointer = 1245678m;

        Console.WriteLine(aNormalnumber);
        Console.WriteLine(iTry);
        Console.WriteLine(abigNum);
        Console.WriteLine(averyBigNum);
        Console.WriteLine(aByte);
        Console.WriteLine(anSByte);
        Console.WriteLine(num);
        Console.WriteLine(aBigNegNum);
        Console.WriteLine(aNegNum);
        Console.WriteLine(justALetter);
        Console.WriteLine(pointer);
        Console.WriteLine(dPointer);
        Console.WriteLine(justAString);
        Console.WriteLine(ddPointer);
    }

    public static void SideQuest() {
        string favoriteNum;
        Console.WriteLine("What is your favorite number?");
        favoriteNum = Console.ReadLine();
        int convertedFaveNum = Convert.ToInt32(favoriteNum);
        Console.WriteLine("Successfully converted your favorite number: " + convertedFaveNum);
    }
}


public static class Program {
    public static void Main()
    {
        //Challenges.TriangleFarmer();
        Challenges.FourSisters();
    }
}
