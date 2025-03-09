using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
   public GameObject escUI;
    public PlayerMovement playerMovement;
    public MouseLook mouseLook;
    public GameObject gameOverObject;

    public void Leave()
    {
        Application.Quit();
    }
   public void Stay()
    {
        escUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        playerMovement.enabled = true;
        mouseLook.enabled = true;
    }

    

}
