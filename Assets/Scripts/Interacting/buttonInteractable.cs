using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonInteractable : MonoBehaviour, IInteractable
{
    public leverInteractable Lever;
    public void LockInAnswer()
    {
        Debug.Log(Lever.Answer);
        if(Lever.Answer == false)
        {
            GameManager.playerScore = GameManager.playerScore + 1;
        }
        else if (Lever.Answer == true)
        {
            GameManager.playerScore = GameManager.playerScore + 5;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public string GetInteractText()
    {
        return "Lock in Answer";
    }

    public void Interact()
    {
        LockInAnswer();
    }
    public Transform GetTransform()
    {
        return transform;
    }
}
