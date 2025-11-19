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
*/


public class Challenges
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

    
}
