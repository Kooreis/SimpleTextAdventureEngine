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
}