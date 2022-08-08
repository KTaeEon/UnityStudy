using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public TargetController gt;
    public Text count1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gt.gameObject == null)
        {
            count1.text = "You Lose";
        }
        else
        {
            count1.text = "count : " + gt.ht;

        }
    }
}
