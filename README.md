# Python Documentation

# Python Text-Based Adventure Game

This Python script is a simple text-based adventure game. The player navigates through a series of rooms by entering commands for the directions they wish to move in. The game continues until the player decides to quit.

## Script Explanation

The script does not import any libraries, so there are no imported libraries to explain.

The script defines two classes: `Room` and `Player`.

### Room Class

The `Room` class represents a room in the game. Each room has a description and six possible directions a player can move in from that room: north, south, east, west, up, and down. If a direction is set to `None`, it means the player cannot move in that direction from the current room.

### Player Class

The `Player` class represents the player in the game. Each player has a `current_room` attribute, which is the room the player is currently in. The player class also has a `move` method, which takes a direction as an argument and moves the player to the room in that direction, if possible.

### Game Loop

The game loop is an infinite loop that continues until the player enters the command "quit". In each iteration of the loop, the game prints the description of the current room, then prompts the player to enter a command. If the command is a valid direction, the player moves in that direction. If the command is "quit", the game ends. If the command is anything else, the game prints "Invalid command."

## Room List

The `room_list` is a list of all the rooms in the game. Each room is an instance of the `Room` class, and the list is indexed so that the player can move between rooms by changing their `current_room` attribute to the index of the new room in the `room_list`.

## Player Initialization

The player is initialized at the start of the game with `player = Player(room_list[0])`, which sets the player's `current_room` to the first room in the `room_list`.

---

# C# Documentation

# C# Text-Based Adventure Game

This is a simple text-based adventure game written in C#. The game places the player in a dark room and allows them to navigate through the game world by entering commands such as "go north". The game continues until the player decides to quit.

## Script Explanation

The script is divided into four classes: `Program`, `Game`, `Room`, and `Player`.

- `Program`: This is the main entry point of the application. It creates a new instance of the `Game` class and starts the game.

- `Game`: This class controls the game loop. It initializes the player and the starting room, then enters a loop where it continually displays the current room's description and waits for the player to enter a command. The command is then processed and the game state is updated accordingly.

- `Room`: This class represents a room in the game. Each room has a description and a dictionary of exits, where the keys are directions and the values are the rooms that those directions lead to.

- `Player`: This class represents the player. Currently, it only has a `Name` property, but it could be expanded to include other properties such as inventory or health.

## Imported Libraries

- `System`: This namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

- `System.Collections.Generic`: This namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.

## How to Run

To run the game, you need to have .NET Core installed. Once you have it installed, you can run the game by navigating to the directory containing the script and running the command `dotnet run`.

---

# Java Documentation

# Java Room Navigation Script

This Java script is a simple text-based navigation program. It creates a scenario where the user is in a room and can navigate to other rooms by entering commands. The user can move north or south, and the program will respond with a description of the new room or a message indicating that the move is not possible.

## Script Overview

The script begins by importing the `java.util.*` package, which provides the `Scanner` class used for reading user input.

The `main` method initializes a `Scanner` object for reading user input and creates two `Room` objects, `currentRoom` and `northRoom`, each with a unique description. The `currentRoom` is set to have a door leading north to the `northRoom`, and the `northRoom` is set to have a door leading south back to the `currentRoom`.

The script then enters an infinite loop, where it continually prints the description of the `currentRoom` and waits for user input. If the user enters "go north" or "go south", the script attempts to move the user to the corresponding room. If the move is not possible (because there is no room in that direction), the script prints a message indicating this. If the user enters anything else, the script prints a message indicating that it does not understand the command.

## Room Class

The `Room` class represents a room in the game. Each `Room` object has a description and may have doors leading north and south to other `Room` objects.

The `Room` class provides getter and setter methods for its fields. The `getDescription` method returns the room's description, and the `getNorth` and `getSouth` methods return the rooms to the north and south, respectively. The `setNorth` and `setSouth` methods allow the north and south rooms to be set.

## Imported Libraries

- `java.util.*`: This package is a part of Java's core library and includes various utility classes and interfaces. In this script, it is used to import the `Scanner` class, which is used to read user input from the console.

---
