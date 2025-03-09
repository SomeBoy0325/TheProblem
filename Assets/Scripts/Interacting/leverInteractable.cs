using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leverInteractable : MonoBehaviour, IInteractable
{
    public bool Answer = false;
    public GameObject sphere;
    public Color defaultColor = Color.white;
    public Color onColor = Color.green;
    public void SwitchAnswer()
    {
        Material sphereMaterial = sphere.GetComponent<Renderer>().material;
        Answer = !Answer;
        if (Answer == false)
        {
            sphereMaterial.SetColor("_Color", defaultColor);
        }
        else if (Answer == true)
        {
            sphereMaterial.SetColor("_Color", onColor);
        }

    }
    public string GetInteractText()
    {
        return "Switch Answer";
    }

    public void Interact()
    {
        SwitchAnswer();
    }
    public Transform GetTransform()
    {
        return transform;
    }
}
