using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    float mvSpeed = 10.0f;
    float roSpeed = 150.0f;

    public int playerNum = 1;
    string mvAxisName;
    string roAxisName;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
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
        /*       float vmv = Input.GetAxis(mvAxisName);
               float hro = Input.GetAxis(roAxisName);

               Vector2 vec2 = new Vector2(-hro, -vmv);
               Vector3 move = transform.forward * -1 * vec2.y + transform.right * -1 * vec2.x;

               transform.position += move * mvSpeed * Time.deltaTime;
               transform.Rotate(0, hro * roSpeed * Time.deltaTime, 0);
        */
        if (Input.GetKeyDown(KeyCode.R))
        {
            count++;
            if(count == 3)
            {
                count = 0;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.Translate(0, 0.6f, 0);
            }
        }
    }
}
