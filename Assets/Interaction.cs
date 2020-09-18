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
            if (Input.GetKeyUp(KeyCode.Space)) SpaceInteraction();
            if (Input.GetKeyUp(KeyCode.Tab)) TabInteraction();
        }

        private void TabInteraction()
        {
            List<Collider2D> nearby = GetCloseObject();
            nearby?[0].GetComponent<IInteractible2>()?.Interact2();
        }
        private void SpaceInteraction()
        {
            List<Collider2D> nearby = GetCloseObject();
            nearby[0].GetComponent<IInteractible1>()?.Interact1();
        }
        private List<Collider2D> GetCloseObject()
        {
            List<Collider2D> hit = new List<Collider2D>();
            Physics2D.OverlapCircle(transform.position, radius, filter, hit);
            if (hit.Count <= 1) return null;
            hit.Remove(collider);
            hit.Sort((one, two) => one.Distance(collider).distance.CompareTo(two.Distance(collider).distance));
            return hit;
        }
    }
}