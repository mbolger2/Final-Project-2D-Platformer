using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Rb of the Player")]
    public Rigidbody2D playerRB;

    [Header("The Name of the X Axis Input")]
    public string xAxis;

    [Header("Speed of the Payer")]
    public float speed;

    void Start()
    {
        playerRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Right input
        if (Input.GetAxisRaw(xAxis) > 0)
        {
            MovePlayer("right");
        }
        // Left input
        if (Input.GetAxisRaw(xAxis) < 0)
        {
            MovePlayer("left");
        }

    }

    void MovePlayer(string direction)
    {
        if (direction == "right")
        {
            playerRB.transform.position = new Vector2(
                transform.position.x + speed,
                transform.position.y);
        }
        if (direction == "left")
        {
            playerRB.transform.position = new Vector2(
                transform.position.x - speed,
                transform.position.y);
        }
    }

}
