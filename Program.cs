//Set the console to white and text to black
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("'Hello, World!' - A tiny story by TutorialsEU");
Console.WriteLine("Press any key to progress, and either 'a' or 'b' when prompted");

Console.WriteLine("\n You are walking through a dense forest where visibility is limited to a mere few meters. Time is passing by, and it feels like hours have passed since you last saw anything that wasn't just trees.");
Console.ReadKey();
Console.WriteLine("\n What seems like a clearing opens up in front of you as you desperately try to approach it. Revealing a path that splits into two, which path may you choose? path 'a' or 'b'?");

var path = Console.ReadKey().Key;
if (path == ConsoleKey.A)
{
    Console.WriteLine("\n You decide to follow path 'a'. The path leads you to a sign stating 'west'. If you are heading west, you hope to find a way out of the forest. Suddenly, a rumbling sound comes from the mountainside.");
    Console.ReadKey();
    Console.WriteLine("\n As it appears to be a landslide, you try to avoid it by going down the right side of the path towards what appears to be a safe zone.");
    Console.ReadKey();
    Console.WriteLine("\n It seems as you avoided the disaster, you look towards the path you are on now and see a sign, it says 'north'.");
    Console.ReadKey();
    Console.WriteLine("\n Seeing as you cannot go back anymore, you decide to continue this way.");
}
else
{
    Console.WriteLine("\n You decide to follow path 'b'. The path leads you to a sign stating 'north'. Meaning that you are heading north you hope to find a way out of the forest. Suddenly, you hear a distant rumble.");
    Console.ReadKey();
    Console.WriteLine("\n Further up dust clouds seem to form, being far enough from the danger, it seems like you are safe. You continue on your path");
}
Console.ReadKey();
Console.WriteLine("\n Following the path north, you encounter a young person looking directly at you with a friendly face. Nonetheless, you feel the need to be cautious.");
Console.ReadKey();
Console.WriteLine("\n 'Hello, traveler! Fret not, for you now save!' Says the friendly figure. 'Should I trust him?' You ask yourself. What do you do? Trust him 'a', or not 'b'?");

path = Console.ReadKey().Key;
if (path == ConsoleKey.A)
{
    Console.WriteLine("\n You decide to trust him, following him to an opening that reveals the escape you sought after for so long. It was good to trust him! He lead you to freedom!");
    Console.ReadKey();
    Console.WriteLine("\n 'Hello, World!' He exclaims. Are you safe now?");
    Console.ReadKey();
    Console.WriteLine("\n You look back, and he is gone, together with the forest. Only a vast open space is what is visible from your point of view. Are you safe now? You do not know the answer.");
}
else
{
    Console.WriteLine("\n You decide to not trust him, going back the way you came from. Although something is changed. It does not seem like you truly are going back. The path is not the same anymore. But a clearing appears, making you run towards it in hopes of finding an escape.");
    Console.ReadKey();
    Console.WriteLine("\n You find yourself at the edge of the forest, to your left you to hear someone exclaim 'Hello, World!'. It seems to be the young person from earlier. How could he get here so fast? Are you safe now?");
    Console.ReadKey();
    Console.WriteLine("\n You look to the front, and you see what seem to be infinite plains with no tree or building in sight. You look back, and the person is gone, together with the forest. Only a vast open space is what is visible from your point of view. Are you safe now? You do not know the answer.");
}
Console.ReadKey();

Console.Clear();
Console.WriteLine("'Hello, World!' - A tiny story by TutorialsEU");
