using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Detection_script : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask BasketLayer;
    [SerializeField] private LayerMask groundLayer;

  

    public float RadNum = 0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //the code for if the bomb is on top of the player
        if (PlayerCaught())
        {
            //moves all the fish and bombs off screen to indicate that the game is over
            
            //removes the score in the top right and displays your final score and the game over screen
            
        }
        //the code for if the bomb hits the floor
        if (PlayerMissed())
        {
            //spawns the corresponding fish and returns the bomb back to the waiting area
            RadNum = Random.Range(-10, 10);
            rb.velocity = Vector3.zero;
            this.transform.position = new Vector3(RadNum, 7, 0);

        }
    }

    //creates a little circle below the bomb to detect the player net underneath
    private bool PlayerCaught()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, BasketLayer);
    }

    //creates another little circle below the bomb to detect if the ground is underneath
    private bool PlayerMissed()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
