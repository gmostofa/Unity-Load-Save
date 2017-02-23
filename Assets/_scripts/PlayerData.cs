[System.Serializable]
public class PlayerData{
    string playerName;
    int playerHealth;

    public PlayerData(){
        playerName = "Initial Name";
        playerHealth = 0;
    }

    public string PlayerName{
        get{
            return playerName;
        }set{
            playerName = value;
        }
    }

    public int PlayerHealth{
        get{
            return playerHealth;
        }set{
            playerHealth = value;
        }
    }
}
