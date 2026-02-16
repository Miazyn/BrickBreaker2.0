using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    public static Player instance;
    //Max 10 Highscores can be saved
    public int[] Scores;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
}
