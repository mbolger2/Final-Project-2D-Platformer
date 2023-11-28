using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBlocks : MonoBehaviour
{
    //the player's rigidbody
    public Rigidbody2D PlayerRB;


    [Header("True is Left, False is Right")]
    public bool Direction = true;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(Direction == true) // left
            {

            }
            else
        }
    }
}
