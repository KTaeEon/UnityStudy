using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ParticleSystem targetExplosion;

    ResultCommand result = new ResultCommand();
    public int ht = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "SHELL")
        {
            ht--;
            if (ht <= 0)
            {
                ParticleSystem fire = Instantiate(targetExplosion, transform.position, transform.rotation);
                fire.Play();
                Destroy(gameObject);
                Destroy(fire.gameObject, 2.0f);
            }
        }
    }
}
