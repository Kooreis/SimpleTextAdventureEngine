```python
class Room:
    def __init__(self, description, north, south, east, west, up, down):
        self.description = description
        self.north = north
        self.south = south
        self.east = east
        self.west = west
        self.up = up
        self.down = down

class Player:
    def __init__(self, current_room):
        self.current_room = current_room

    def move(self, direction):
        global room_list
        new_room = getattr(self.current_room, direction)
        if new_room is None:
            print("You can't go that way.")
        else:
            self.current_room = room_list[new_room]

room_list = []
room_list.append(Room("You are in the entrance of a cave.", None, 4, None, None, None, None))
room_list.append(Room("You are in a narrow passage.", None, 5, 2, None, None, None))
room_list.append(Room("You are in a treasure chamber.", None, None, None, 1, None, None))
room_list.append(Room("You are in a winding passage.", 1, None, None, 4, None, None))
room_list.append(Room("You are in a large cavern.", 0, 7, 3, None, None, None))
room_list.append(Room("You are in a small chamber.", 1, None, None, None, None, None))
room_list.append(Room("You are in a dark passage.", 7, None, None, None, None, None))
room_list.append(Room("You are in a dark cave.", 4, 6, None, None, None, None))

player = Player(room_list[0])

while True:
    print("\n" + player.current_room.description)
    command = input("> ")
    if command.lower() in ["north", "south", "east", "west", "up", "down"]:
        player.move(command.lower())
    elif command.lower() == "quit":
        break
    else:
        print("Invalid command.")
```