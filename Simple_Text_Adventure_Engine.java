```java
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Room currentRoom = new Room("You are in a dark room. There is a door to the north.");
        Room northRoom = new Room("You are in a bright room. There is a door to the south.");
        currentRoom.setNorth(northRoom);
        northRoom.setSouth(currentRoom);

        while (true) {
            System.out.println(currentRoom.getDescription());
            String command = scanner.nextLine();
            if (command.equals("go north")) {
                if (currentRoom.getNorth() != null) {
                    currentRoom = currentRoom.getNorth();
                } else {
                    System.out.println("You can't go that way.");
                }
            } else if (command.equals("go south")) {
                if (currentRoom.getSouth() != null) {
                    currentRoom = currentRoom.getSouth();
                } else {
                    System.out.println("You can't go that way.");
                }
            } else {
                System.out.println("I don't understand '" + command + "'.");
            }
        }
    }
}

class Room {
    private String description;
    private Room north;
    private Room south;

    public Room(String description) {
        this.description = description;
    }

    public String getDescription() {
        return description;
    }

    public Room getNorth() {
        return north;
    }

    public void setNorth(Room north) {
        this.north = north;
    }

    public Room getSouth() {
        return south;
    }

    public void setSouth(Room south) {
        this.south = south;
    }
}
```