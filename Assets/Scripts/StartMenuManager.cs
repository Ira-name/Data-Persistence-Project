using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuManager : MonoBehaviour
{
    public InputField nameInput;

    public void StartGame()
    {
        PlayerData.Instance.PlayerName = nameInput.text;
        SceneManager.LoadScene("MainGame");
    }
}