using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mvSpeed = 10.0f;
    public float roSpeed = 150.0f;

    public int playerNum = 1;

    public GameObject player;
    public GameObject mainCamera;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player "+playerNum);
        mainCamera = GameObject.FindGameObjectWithTag("CAM"+playerNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
