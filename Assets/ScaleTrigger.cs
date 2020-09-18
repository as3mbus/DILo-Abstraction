using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScaleTrigger: MonoBehaviour
    {
        private bool triggerAble = false;
        public float scaleModifier;
        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (triggerAble)
                {
                    transform.localScale = transform.localScale * scaleModifier;
                }
            }
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                if (triggerAble)
                {
                    transform.localScale = transform.localScale / scaleModifier;
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
}