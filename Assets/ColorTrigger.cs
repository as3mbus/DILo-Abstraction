using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace.Scenes
{
    public class ColorTrigger:MonoBehaviour
    {
        private bool triggerAble = false;
        private SpriteRenderer sprite;
        
        private void Start()
        {
            sprite = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (triggerAble)
                {
                    sprite.color = new Color(Random.value,Random.value,Random.value);
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