using DefaultNamespace;
using UnityEngine;

public class TriggerDetection : MonoBehaviour, IInteractible1
{
    public void Interact1() 
        => Debug.Log($"{name} is triggered");
}
