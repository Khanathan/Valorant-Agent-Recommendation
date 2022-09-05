using System;

public class Valorant
{
    public static string[] mapsList = new string[9] { "Practice Range", "Bind", "Haven", "Split", "Ascent", "Icebox", "Breeze", "Fracture", "Pearl" };
    public static string[] recOptions = new string[2] { "gun", "agent" };

    public static void OptionSelect()
    {
        Console.WriteLine("Please select the topic you need recommendation for: ");
        for (int i = 0; i < recOptions.Length; i++)
        {
            Console.WriteLine($"    {i + 1} - Recommendation for {recOptions[i]} to choose.");
        }
        Console.WriteLine("Please enter a number from 1-2 to choose: ");
        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case 1:
                MapsInput();
                GunRec();
                break;
            case 2:
                MapsInput();
                AgentRec();
                break;
        }

    }
    public static void MapsInput()
    {
        Console.WriteLine("Please select one of the maps provided by entering a number from 1-9:");

        for (int  i = 0; i < mapsList.Length; i++)
        {
            Console.WriteLine($"    {i + 1} - {mapsList[i]}");
        }
        Console.WriteLine("Please choose the map you would like to receive recommendation for (enter a number 1-9): ");
        Console.ReadLine();
    }
    public static void GunRec()
    {
        Console.WriteLine("The recommended gun for you is Vandal.");
        Console.ReadLine();
        Console.Clear();
        OptionSelect();
    }
    public static void AgentRec()
    {
        Console.WriteLine("The recommended agent for you is Sova.");
        Console.ReadLine();
        Console.Clear();
        OptionSelect();
    }
}
