using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI score;
    //Called when scene opens
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        score.text = "You saved: " + GameManager.playerScore;
        if(GameManager.playerScore == 5*(1))
        {
            text.text = "You earned the Selfish ending, valueing your consciouncess or time rather then others";
        }
        else if(GameManager.playerScore == 4*(1)+1*(5))
        {
            text.text = "You tried to help only one set of individuals, showing some morality";
        }
        else if (GameManager.playerScore == 3*(1)+2*(5))
        {
            text.text = "You value both your consciouness, but also your morality balancing both sides to a decent degree";
        }
        else if (GameManager.playerScore == 2 * (1) + 3 * (5))
        {
            text.text = "You value both your consciouness, but also your morality balancing both sides to a decent degree";
        }
        else if (GameManager.playerScore == 1 * (1) + 4 * (5))
        {
            text.text = "You understand that your choice is killing people, but you would rather save more then hurt your mind";
        }
        else if (GameManager.playerScore == 5 * (5))
        {
            text.text = "You earned the Selfless ending, valueing a group over an individual no matter what";
        }
    }
    //Closes Game
    public void Quit()
    {
        Application.Quit();
    }
}
