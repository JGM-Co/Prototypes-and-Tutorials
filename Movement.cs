using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D characterRb;
    public Vector2 diagonalUpRightForce, diagonalUpLeftForce, diagonalDownRightForce, diagonalDownLeftForce, rightForce, leftForce, upForce, downForce;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w") && Input.GetKey("d"))
        {
            characterRb.AddForce(diagonalUpRightForce);
        }
        else if(Input.GetKey("w") && Input.GetKey("a"))
        {
            characterRb.AddForce(diagonalUpLeftForce);
        }
        else if (Input.GetKey("s") && Input.GetKey("d"))
        {
            characterRb.AddForce(diagonalDownRightForce);
        }
        else if (Input.GetKey("s") && Input.GetKey("a"))
        {
            characterRb.AddForce(diagonalDownLeftForce);
        }
        else if (Input.GetKey("d"))
        {
            characterRb.AddForce(rightForce);
        } 
        else if(Input.GetKey("a"))
        {
            characterRb.AddForce(leftForce);
        } 
        else if(Input.GetKey("w"))
        {
            characterRb.AddForce(upForce);
        } 
        else if(Input.GetKey("s"))
        {
            characterRb.AddForce(downForce);
        }
    }
}
