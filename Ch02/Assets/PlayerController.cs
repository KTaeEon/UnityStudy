using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRD;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRD = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRD.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRD.AddForce(speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRD.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRD.AddForce(0, 0, -speed);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Player 충돌 Enter : " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Player 충돌 Exit : " + collision.gameObject.name);
    }
}
