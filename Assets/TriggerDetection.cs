using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    private bool triggerAble = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (triggerAble)
            {
                Debug.Log($"{name} is triggered");
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerAble = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        triggerAble = false;
    }
}
