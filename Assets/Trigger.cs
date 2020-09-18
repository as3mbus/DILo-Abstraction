using UnityEngine;

namespace DefaultNamespace
{
    public abstract class Trigger : MonoBehaviour
    {
        private bool triggerAble = false;
        
        
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (triggerAble)
                {
                    Interaction1();
                }
            }
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                if (triggerAble)
                {
                    Interaction2();
                }
            }
       
        }

        protected abstract void Interaction1();
        protected abstract void Interaction2();
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