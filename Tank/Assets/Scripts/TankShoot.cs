using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody prefabShell;
    public Transform shellGenerator;
    public float shoot = 20.0f;

    public int playerNum = 1;
    string FireName;

    // Start is called before the first frame update
    void Start()
    {
        FireName = "Fire" + playerNum;
    }   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(FireName))
        {
            Fire();
        }
    }

    public void Fire()
    {
        Rigidbody shellinstance = Instantiate(prefabShell, shellGenerator.position, shellGenerator.rotation);
        shellinstance.velocity = shoot * shellGenerator.forward;
    }
}
