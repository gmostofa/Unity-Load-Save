using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameController : MonoBehaviour {
    static GameController controller;

    const string playerDataDat = "/playerData.dat";

    PlayerData playerData;

    void Awake(){
        if (controller == null)
            controller = this;

        DontDestroyOnLoad(this);
    }
    
    void Start(){
        playerData = new PlayerData();
    }

    public void SaveData(){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + playerDataDat);
        bf.Serialize(file, playerData);
        file.Close();

    }

    public void LoadData(){
        BinaryFormatter bf = new BinaryFormatter();

        if (File.Exists(Application.persistentDataPath + playerDataDat)){
            FileStream file = File.Open(Application.persistentDataPath + playerDataDat, FileMode.Open);
            playerData = (PlayerData)bf.Deserialize(file);
            file.Close();
        }
    }


    public static GameController Controller(){
        return controller;
    }
    public PlayerData PlayerData{
        get{
            return playerData;
        }
    }
}
