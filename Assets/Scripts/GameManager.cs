
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameOverScreen gameOverScreen;
    public GameObject gameOverObject;
    public GameObject pauseMenu;
    public static int playerScore = 0;
    public PlayerMovement playerMovement;
    public MouseLook mouseLook;

    public void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Esc[] pauseMenus = FindObjectsOfType<Esc>(true);
        if (pauseMenus.Length > 0)
        {
            pauseMenu = pauseMenus[0].gameObject;
        }
        else
        {
            Debug.LogWarning("PauseMenu (Esc) not found in the scene!");
        }

        // Find GameOverScreen (Make sure it's not empty)
        GameOverScreen[] gameOverScreens = FindObjectsOfType<GameOverScreen>(true);
        if (gameOverScreens.Length > 0)
        {
            gameOverScreen = gameOverScreens[0];
            gameOverObject = gameOverScreens[0].gameObject;
        }
        else
        {
            Debug.LogWarning("GameOverScreen not found in the scene!");
        }

        // Find PlayerMovement
        playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement == null)
        {
            Debug.LogWarning("PlayerMovement not found in the scene!");
        }

        // Find MouseLook
        mouseLook = FindObjectOfType<MouseLook>();
        if (mouseLook == null)
        {
            Debug.LogWarning("MouseLook not found in the scene!");
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
   public void EscapeMenu()
   {
        pauseMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        playerMovement.enabled = false;
        mouseLook.enabled = false;
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !(gameOverObject.activeInHierarchy))
        {
            EscapeMenu();
        }
    }

}
