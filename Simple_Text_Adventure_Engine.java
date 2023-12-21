Room currentRoom = new Room("You are in a dark room. There is a door to the north.");
Room northRoom = new Room("You are in a bright room. There is a door to the south.");
currentRoom.setNorth(northRoom);
northRoom.setSouth(currentRoom);