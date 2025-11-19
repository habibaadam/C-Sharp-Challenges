/*
- will contain new challenge solutions soon
Challenge The Triangle Farmer 100 XP
As you pass through the fields near Arithmetica City, you encounter P-Thag, a triangle farmer, scratching
numbers in the dirt.
“What is all of that writing for?” you ask.
“I’m just trying to calculate the area of all of my triangles. They sell by their size. The bigger they are, the
more they are worth! But I have many triangles on my farm, and the math gets tricky, and I sometimes
make mistakes. Taking a tiny triangle to town thinking you’re going to get 100 gold, only to be told it’s
only worth three, is not fun! If only I had a program that could help me….” Suddenly, P-Thag looks at you
with fresh eyes. “Wait just a moment. You have the look of a Programmer about you. Can you help me
write a program that will compute the areas for me, so I can quit worrying about math mistakes and get
back to tending to my triangles? The equation I’m using is this one here,” he says, pointing to the formula,
etched in a stone beside him:
𝐴𝐴𝐴𝐴𝐴𝐴𝐴𝐴=
𝑏𝑏𝑏𝑏𝑏𝑏𝑏𝑏 × ℎ𝑒𝑒𝑒𝑒𝑒𝑒ℎ𝑡𝑡
2
Objectives:
• Write a program that lets you input the triangle’s base size and height.
• Compute the area of a triangle by turning the above equation into code.
• Write the result of the computation.


Challenge The Four Sisters and the Duckbear 100 XP
Four sisters own a chocolate farm and collect chocolate eggs laid by chocolate chickens every day. But
more often than not, the number of eggs is not evenly divisible among the sisters, and everybody knows
you cannot split a chocolate egg into pieces without ruining it. The arguments have grown more heated
over time. The town is tired of hearing the four sisters complain, and Chandra, the town’s Arbiter, has
finally come up with a plan everybody can agree to. All four sisters get an equal number of chocolate
eggs every day, and the remainder is fed to their pet duckbear. All that is left is to have some skilled
Programmer build a program to tell them how much each sister and the duckbear should get.
Objectives:
• Create a program that lets the user enter the number of chocolate eggs gathered that day.
• Using / and %, compute how many eggs each sister should get and how many are left over for the
duckbear.
• Answer this question: What are three total egg counts where the duckbear gets more than each
sister does? You can use the program you created to help you find the answer. = 6, 7, 11,
*/


public static class Challenges
{
    public static void TriangleFarmer()
    {
        Console.WriteLine(" === Triangle Farmer Challenge ====");
        Console.WriteLine(" Kindly Input the base of the triangle ");
        double triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" Now input the height of the triangle ");

        double height = Convert.ToDouble(Console.ReadLine());

        double area = (triangleBase * height) / 2;
        Console.WriteLine("The area of the triangle is " + area);
    }

    public static void FourSisters ()
    {
        Console.WriteLine(" === The Four Sisters And The Duckbear ===");
        Console.WriteLine(" Sisters, kindly input the number of chocolate eggs collected today!");

        int totalEggs = Convert.ToInt32(Console.ReadLine());
        int eachSisterEggs = totalEggs / 4;
        Console.WriteLine($"Each sister gets {eachSisterEggs} for today!");

        int duckBearEggs = totalEggs % 4;
        Console.WriteLine($"The duckbear gets {duckBearEggs} for today!");

        if (duckBearEggs > eachSisterEggs)
        {
            Console.WriteLine("Duckbear got more eggs this time!");
        }
    }

}
