using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Rigidbody")]
    public Rigidbody2D rb;
    public Transform player;

    [Header("The Name of the X Axis Input")]
    public string xAxis;

    [Header("Speed of the Payer")]
    public float speed;

    [Header("Player Movement Boundaries")]
    public Vector2 movementBoundariesMin;
    public Vector2 movementBoundariesMax;

    [Header("Potency of Jump")]
    public float jumpForce;

    [Header("Double Jump Charges")]
    public float jumpcharge = 2;
    bool onground = true;
    bool discharge = false;
    float charger = 0.0f;

    [Header("Dodge Strength")]
    public float dodgeforce=100;

    [Header("Particle Effect")]
    public ParticleSystem jump;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMov;

        xMov = Input.GetAxis(xAxis);
        
        Vector3 motion = new Vector3(xMov, 0, 0) * speed * Time.deltaTime;
       
        Vector3 finalPos = transform.position + motion;

        // Fix Movement in x
        if (finalPos.x > movementBoundariesMax.x)
        {
            finalPos.x = movementBoundariesMax.x;
        }
        if (finalPos.x < movementBoundariesMin.x)
        {
            finalPos.x = movementBoundariesMin.x;
        }

        // Fix Movement in y
        if (finalPos.y > movementBoundariesMax.y)
        {
            finalPos.y = movementBoundariesMax.y;
        }
        if (finalPos.y < movementBoundariesMin.y)
        {
            finalPos.y = movementBoundariesMin.y;
        }

        // Set the correct Final Pos
        transform.position = finalPos;


        //gonna rewrite jump to try and do double jumps
        //Original jump code
        //if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        //{
        //    rb.AddForce(Vector2.up * jumpForce * 100);
        //}
        if(Input.GetButtonDown("Jump") && jumpcharge > 0)
        {
            //if(jumpcharge == 1)
            //{
            //    this.jump.transform.position = player.transform.position;
            //    this.jump.Play();
            //}
            this.jump.transform.position = player.transform.position;
            this.jump.Play();
            rb.AddForce(Vector2.up * jumpForce * 100);
            jumpcharge--;
            onground = false;
        }

        //super jump
        if(Input.GetKey(KeyCode.W) && onground) 
        {
            charger += Time.deltaTime;
            Debug.Log("charger = " + charger);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            discharge = true;
        }
        if (discharge && onground)
        {
            rb.AddForce(Vector2.up * charger * jumpForce *100);
            onground = false;
            discharge = false;
            charger = 0.0f;
            jumpcharge--;
        }
        //current air dodge code. work in progress
        //if(Input.GetButtonDown("c") && rb.velocity.y!=0)
        //{
        //   rb.AddForce(Vector2.left* 100000);
        //}



    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpcharge = 2;
        onground = true;
        
    }

}
