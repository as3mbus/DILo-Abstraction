using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace.Scenes
{
    public class ColorTrigger : MonoBehaviour, IInteractible1
    
    {
        private SpriteRenderer sprite;

        private void Start()
        {
            sprite = GetComponent<SpriteRenderer>();
        }

        public  void Interact1()
        {
            sprite.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}