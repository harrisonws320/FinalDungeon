using MyDungeonLibrary;
namespace MyDungeonApp
{
    internal class Program
    {
        private static string[] demonNames = { "Stavrogin", "Pope Bacon X", "Zarathustra", "Pynchon", "Milton", /* Add more demon names */ };

        private static Room[] rooms = new Room[4];

        static void Main(string[] args)
        {
            // Generate seven random rooms
            GenerateRandomRooms();

            // Display the rooms and associated demons
            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine($"Room {i + 1}: {rooms[i].DemonName}");
            }
        }

        static void GenerateRandomRooms()
        {
            Random random = new Random();

            for (int i = 0; i < rooms.Length; i++)
            {
                Room room = new Room();
                int randomIndex = random.Next(0, demonNames.Length);
                room.DemonName = demonNames[randomIndex];
                rooms[i] = room;
            }
        }
    }
}