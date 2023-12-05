using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBlocks : MonoBehaviour
{
    public Transform playerTF;
    private Vector2 temp;

    [Header("True is Left, False is Right")]
    public bool Direction = true;



    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("I have collided");
        if(collision.gameObject.tag == "ConveyorBlockLeft")
        {
            Debug.Log("I go left");
            //PlayerRB.AddForce(Vector2.left * strength);
            temp = playerTF.position;
            temp.x -= 0.1f;
            playerTF.position = temp;
        }
        if(collision.gameObject.tag == "ConveyorBlockRight")
        {
            Debug.Log("I right");
            //PlayerRB.AddForce(Vector2.right * strength);
            temp = playerTF.position;
            temp.x += 0.1f;
            playerTF.position = temp;
        }
    }
}
