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


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(Direction == true) // left
            {
                PlayerRB.AddForce(Vector2.left * strength);
            }
            else // right
            {
                PlayerRB.AddForce(Vector2.right * strength);
            }
        }
    }
}
