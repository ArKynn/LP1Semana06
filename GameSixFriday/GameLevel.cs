namespace GameSixFriday;

public class GameLevel
{
    private Foe[] RoomArray { get; }
    private Difficulty LevelDifficulty { get; }

    public GameLevel(int roomNumber, Difficulty levelDifficulty)
    {
        this.RoomArray = new Foe[roomNumber];
        
        this.LevelDifficulty = levelDifficulty;
    }

    public void SetFoeInRoom(int roomNumber, Foe foe)
    {
        this.RoomArray[roomNumber] = foe;
    }

    public int GetNumRooms() => this.RoomArray.Length;
    public Difficulty GetDifficulty() => this.LevelDifficulty;

    public int GetNumFoes()
    {
        int enemyNum = 0;
        for (int room = 0; room < RoomArray.Length; room++)
        {
            if (RoomArray[room] != null) enemyNum++;
        }

        return enemyNum;
    }

    public void PrintFoes()
    {
        for (int room = 0; room < RoomArray.Length; room++)
        {
            if (RoomArray[room] != null)
                Console.WriteLine($"Room {room}: {RoomArray[room].GetName()} ");
        }
    }
    
}