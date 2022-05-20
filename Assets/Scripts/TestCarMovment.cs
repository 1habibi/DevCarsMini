using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCarMovment : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float moveHorizontal;
    private float moveVertical;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(moveHorizontal > 0.1f || moveHorizontal < 0.1f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }
        if (moveVertical > 0.1f || moveHorizontal < 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * moveSpeed), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Square (1)")
        {
            if (moveHorizontal > 0.1f || moveHorizontal < 0.1f)
            {
                rb2D.AddForce(new Vector2(-moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
            }
            if (moveVertical > 0.1f || moveHorizontal < 0.1f)
            {
                rb2D.AddForce(new Vector2(0f, -moveVertical * moveSpeed), ForceMode2D.Impulse);
            }
        }
    }
}
