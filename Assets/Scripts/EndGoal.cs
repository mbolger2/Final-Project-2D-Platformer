using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    // The tag of the player
    public string playerTag;

    // the win menu name
    public string winMenu;

    // The object with the win menu
    //public GameObject winMenu;

    // A static variable to keep track of whether the game
    // is paused
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        //isPaused = false;

        //winMenu = GameObject.FindGameObjectWithTag("WinMenu");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == playerTag)
        {
            SceneManager.LoadScene(winMenu);
        }
    }

    // The function will "pause" the game
    public void Pause()
    {
        //winMenu.SetActive(true);
        //Time.timeScale = 0f;
        //isPaused = true;
    }
}
