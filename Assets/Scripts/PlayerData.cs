using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public string PlayerName;
    public int HighScore;

    private void Awake()
    {
        // Перевірка, щоб об'єкт не знищувався між сценами
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}