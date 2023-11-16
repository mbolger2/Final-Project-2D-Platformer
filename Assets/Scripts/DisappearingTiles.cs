using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingTiles : MonoBehaviour
{

    //disappearing blocks. ver 1 proof of concept
    private void OnCollisionEnter2D(Collision2D collision)
    {
       Destroy(this.gameObject);
    }
}
