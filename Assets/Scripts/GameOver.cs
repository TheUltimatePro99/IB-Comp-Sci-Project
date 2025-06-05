using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : Interactable
{
    protected override void Interact()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("scene");
    }
}
