using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float walkSpeed = 5.0f;
    Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(Vector2.up * 10.0f, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);

            transform.localScale = new Vector2(-0.5f, 0.5f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);


            transform.localScale = new Vector2(0.5f, 0.5f);
        }
    }
}
