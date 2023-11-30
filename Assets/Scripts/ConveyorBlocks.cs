using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBlocks : MonoBehaviour
{
    //the player's rigidbody
    public Rigidbody2D PlayerRB;
    public float strength = 50.0f;

    [Header("True is Left, False is Right")]
    public bool Direction = true;



    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("I have collided");
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Ihave collided with player");
            if(Direction == true) // left
            {
                Debug.Log("I go left");
                PlayerRB.AddForce(Vector2.left * strength);
            }
            else // right
            {
                Debug.Log("I right");
                PlayerRB.AddForce(Vector2.right * strength);
            }
        }
    }
}
