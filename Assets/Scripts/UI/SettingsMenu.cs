using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject startMenu;
    // use these to access if subtitles are on and your sensitivity. (Not complete)
    public GameObject sensitivity;
    public GameObject subtitles;
    private void Update()
    {
        // lets you exit back to main menu
        if (Input.GetKeyDown(KeyCode.Escape) && (SceneManager.GetActiveScene().buildIndex == 0))
        {
            GameObject.Find("SettingsMenu").SetActive(false);
            startMenu.SetActive(true);
        }

    }
}     
   

