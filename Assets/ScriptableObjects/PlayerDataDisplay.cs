using UnityEngine;
using UnityEngine.UI;

public class PlayerDataDisplay : MonoBehaviour
{
    public PlayerData_SO playerData;
    public Text infoText;

    void Start()
    {

        infoText.text = "Name: " + playerData.playerName;
        infoText.text = infoText.text + "\n Age: " + playerData.age;
        infoText.text = infoText.text + "\n Height: " + playerData.height;
        
    }
}
