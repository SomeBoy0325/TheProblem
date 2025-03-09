using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float radius = 6;
  
    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
                IInteractable interactable = GetInteractableObject();
                if (interactable != null)
                     {
                        interactable.Interact();
                     }        
        }
    }
    public IInteractable GetInteractableObject()
    {
        List<IInteractable> interactablesList = new List<IInteractable>();
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out IInteractable interactable))
            {
                interactablesList.Add(interactable);
            }
        }

        IInteractable closestInteractable = null;
        foreach(IInteractable interactable in interactablesList)
        {
            if(closestInteractable == null)
            {
                closestInteractable = interactable;
            }
            else
            {
                if(Vector3.Distance(transform.position, interactable.GetTransform().position) <
                    Vector3.Distance(transform.position, closestInteractable.GetTransform().position))
                {
                    closestInteractable = interactable;
                }
            }
        }
        return closestInteractable;
    }
    
}
