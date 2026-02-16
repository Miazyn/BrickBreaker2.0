using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState CurrentGameState { get; private set; }

    //How to call a delegate
    //public delegate void OnPlayerHealthChange(int maxhealth, int curhealth);
    //public OnPlayerHealthChange onPlayerHealthChangeCallback;

    public enum GameState
    {
        GameStart,
        GamePause,
        GameEnd
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Debug.Log("Game started");

        CurrentGameState = GameState.GameStart;
    }
}
