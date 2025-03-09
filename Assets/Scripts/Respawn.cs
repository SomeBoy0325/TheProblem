using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    //make it so when player collides with death box collider
    //the death screen ui is activated along with creating a function for
    //the respawn and quit button
    public GameObject player;
    public PlayerMovement playerMovement;
    public MouseLook mouseLook;
    public GameObject canvas;
    public GameOverScreen gameOverScreen;
    void OnTriggerEnter()
    {
        if(player.tag == "Player")
        {
            GameObject.Find("TimerUI").SetActive(false);
            canvas.GetComponent<Timer>().enabled = false;
            playerMovement.enabled = false;
            mouseLook.enabled = false;
            gameOverScreen.Setup();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
