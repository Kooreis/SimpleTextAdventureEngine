```CSharp
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}

public class Game
{
    private Room currentRoom;
    private Player player;

    public void Start()
    {
        player = new Player();
        currentRoom = new Room("You are in a dark room. There is a door to the north.");

        while (true)
        {
            Console.WriteLine(currentRoom.Description);
            string input = Console.ReadLine();
            HandleInput(input);
        }
    }

    private void HandleInput(string input)
    {
        string[] parts = input.Split(' ');
        string command = parts[0].ToLower();

        if (command == "go")
        {
            string direction = parts[1].ToLower();
            Room nextRoom = currentRoom.GetExit(direction);

            if (nextRoom == null)
            {
                Console.WriteLine("You can't go that way.");
            }
            else
            {
                currentRoom = nextRoom;
            }
        }
        else if (command == "quit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I don't understand that command.");
        }
    }
}

public class Room
{
    public string Description { get; private set; }
    private Dictionary<string, Room> exits;

    public Room(string description)
    {
        Description = description;
        exits = new Dictionary<string, Room>();
    }

    public void AddExit(string direction, Room room)
    {
        exits.Add(direction, room);
    }

    public Room GetExit(string direction)
    {
        if (exits.ContainsKey(direction))
        {
            return exits[direction];
        }
        else
        {
            return null;
        }
    }
}

public class Player
{
    public string Name { get; set; }
}
```