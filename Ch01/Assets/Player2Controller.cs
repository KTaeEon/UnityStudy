using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Rigidbody playerRd;

    float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 타입은 벡터의 방향과 속도를 가지고 오브젝트를 이동할 수 있다.
        // detaTime은 컴퓨터의 성능에 따라 프레임 속도를 일정하도록 프레임 시간 간격을 동기화시키는 값

        if (Input.GetKey(KeyCode.D) == true)
        {
            playerRd.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            playerRd.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            playerRd.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            playerRd.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            playerRd.AddForce(0f, 3f, 0f);
        }
    }
}
