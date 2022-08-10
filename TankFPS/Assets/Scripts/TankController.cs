using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    float mouseY = 0;
    float mouseX = 0;
    public Transform tank;
    float mouseZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseRotation();
    }
    void MouseRotation()
    {
 
        mouseY += Input.GetAxis("Mouse X") * turnSpeed ;
        mouseX += Input.GetAxis("Mouse Y") * turnSpeed ;

        mouseY = Mathf.Clamp(mouseY, -70.0f, 70.0f);
        mouseX = Mathf.Clamp(mouseX, -15.0f, 40.0f );

        transform.localEulerAngles = new Vector3(-mouseX, mouseY, 0);
        
    }

    //float rx = -mouseX + tank.eulerAngles.x;
    //mouseX = Mathf.Clamp(mouseX, -40.0f , 40.0f);
}
