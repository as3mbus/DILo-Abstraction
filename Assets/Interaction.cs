using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Interaction : MonoBehaviour
    {
        private Collider2D collider;
        public ContactFilter2D filter;
        public float radius = 10;

        private void Start()
        {
            collider = GetComponent<Collider2D>();
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                List<Collider2D> hit = new List<Collider2D>();
                if (Physics2D.OverlapCircle(transform.position, radius, filter, hit) > 1)
                {
                    hit.Remove(collider);
                    hit.Sort((one, two) => one.Distance(collider).distance.CompareTo(two.Distance(collider).distance));
                    hit[0].GetComponent<IInteractible1>()?.Interact1();
                }
            }
            
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                List<Collider2D> hit = new List<Collider2D>();
                if (Physics2D.OverlapCircle(transform.position, radius, filter, hit) > 1)
                {
                    hit.Remove(collider);
                    hit.Sort((one, two) => one.Distance(collider).distance.CompareTo(two.Distance(collider).distance));
                    hit[0].GetComponent<IInteractible2>()?.Interact2();
                }
            }
        }
    }
}