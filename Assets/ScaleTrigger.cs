using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScaleTrigger: MonoBehaviour, IInteractible1, IInteractible2
    {
        public float scaleModifier;
        
        public void Interact1()
        {
            transform.localScale *= scaleModifier;
        }

        public void Interact2()
        {
            transform.localScale /= scaleModifier;
        }

    }
}