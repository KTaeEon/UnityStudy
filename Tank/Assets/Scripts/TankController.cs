using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{

    float mvSpeed = 10.0f;
    float roSpeed = 150.0f;

    public int playerNum = 1;
    string mvAxisName;
    string roAxisName;

    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("CAM" + playerNum);
        mvAxisName = "Vertical" + playerNum;
        roAxisName = "Horizontal" + playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis(mvAxisName) * mvSpeed * Time.deltaTime;
        float ro = Input.GetAxis(roAxisName) * roSpeed * Time.deltaTime;

        transform.Translate(0, 0, mv);
        transform.Rotate(0, ro, 0);

        mainCamera.transform.rotation = transform.rotation;
        mainCamera.transform.position = transform.position;

        mainCamera.transform.Translate(0, 2.2f, 0);
        if (transform.position.y < 0)
        {
            transform.Translate(0, 0.2f, 0);
        }
    }
}
