using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody blockRd;
    Vector3 startPos;

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
        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;                     // �Ի簢
            Vector3 normalVec = collision.contacts[0].normal;          // ��������(��������)
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec); // �ݻ簢

            reflectVec = reflectVec.normalized; // �ݻ簢 ����ȭ

            blockRd.AddForce(reflectVec * speed);

            // �浹�� �ش� �� ����
            Destroy(collision.gameObject);
        }

        startPos = transform.position;
    }
}
