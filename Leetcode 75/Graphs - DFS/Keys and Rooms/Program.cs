namespace Keys_and_Rooms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            HashSet<int> keys = new HashSet<int>();

            for (int i = 0; i < rooms[0].Count; i++)
            {
                keys.Add(rooms[0][i]);
            }

            int visitedRooms = 1;
            while (visitedRooms != rooms.Count)
            {
                bool isEnterRoom = false;

                for (int i = 1; i < rooms.Count; i++)
                {                   
                    if (keys.Contains(i))
                    {
                        if (rooms[i] == null)
                        {
                            continue;
                        }

                        isEnterRoom = true;
                        visitedRooms++;
                        for (int j = 0; j < rooms[i].Count; j++)
                        {
                            keys.Add(rooms[i][j]);
                        }
                        rooms[i] = null;
                    }
                }

                if (!isEnterRoom)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
