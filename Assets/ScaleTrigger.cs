using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScaleTrigger: Trigger
    {
        public float scaleModifier;
        
        protected override void Interaction1()
        {
            transform.localScale *= scaleModifier;
        }

        protected override void Interaction2()
        {
            transform.localScale /= scaleModifier;
        }

    }
}