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
        // Vector3 Ÿ���� ������ ����� �ӵ��� ������ ������Ʈ�� �̵��� �� �ִ�.
        // detaTime�� ��ǻ���� ���ɿ� ���� ������ �ӵ��� �����ϵ��� ������ �ð� ������ ����ȭ��Ű�� ��

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
