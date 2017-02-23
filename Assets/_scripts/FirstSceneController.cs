using System;
using UnityEngine;
using UnityEngine.UI;

public class FirstSceneController : MonoBehaviour {
    [Header("Save UI")]
    public InputField nameField;
    public InputField healthField;
    public Button saveButton;
    [Space(10)]
    [Header("Load UI")]
    public Text loadedName;
    public Text loadedHealth;
    public Button loadButton;


    GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = GameController.Controller();
        

        loadButton.onClick.AddListener(delegate{
            LoadData();
        });

        saveButton.onClick.AddListener(delegate{
            gameController.PlayerData.PlayerName = nameField.text;
            gameController.PlayerData.PlayerHealth = Convert.ToInt32(healthField.text);

            gameController.SaveData();
        });
	}

    void LoadData(){
        gameController.LoadData();
        loadedName.text = gameController.PlayerData.PlayerName;
        loadedHealth.text = gameController.PlayerData.PlayerHealth.ToString();
    }
}
