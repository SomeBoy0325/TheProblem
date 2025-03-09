
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject tutorialMenu;
    // Start is called before the first frame update
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void TutorialMenuOpen()
    {
        GameObject.Find("StartMenu").SetActive(false);
        tutorialMenu.SetActive(true);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
