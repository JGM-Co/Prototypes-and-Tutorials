using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 5f, rb.velocity.y);

        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }

        if (dirX > 0f)
        {
            anim.SetBool("running", true);
        } else if (dirX < 0f)
        {
            anim.SetBool("running", true);
        } else
        {
            anim.SetBool("running", false);
        }
    }

    private void UpdateAnimationUpdate()
    {

    }
}
