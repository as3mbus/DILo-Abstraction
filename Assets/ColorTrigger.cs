using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace.Scenes
{
    public class ColorTrigger : Trigger
    {
        private SpriteRenderer sprite;

        private void Start()
        {
            sprite = GetComponent<SpriteRenderer>();
        }

        protected override void Interaction1()
        {
            sprite.color = new Color(Random.value, Random.value, Random.value);
        }

        protected override void Interaction2()
        {
            // do nothing
        }
    }
}