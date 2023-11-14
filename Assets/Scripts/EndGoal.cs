using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    // The tag of the player
    public string playerTag;

    // The name of the winning scene
    public string winScene;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == playerTag)
        {
            SceneManager.LoadScene(winScene);
        }
    }
}
