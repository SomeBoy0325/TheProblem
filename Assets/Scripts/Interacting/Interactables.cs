using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    private Animator animator;
    // Start is called before the first frame update
    public void Interact()
    {
        Debug.Log("Interact");
    }
    public string GetInteractText()
    {
        return interactText;
    }
    public Transform GetTransform()
    {
        return transform;
    }
}
