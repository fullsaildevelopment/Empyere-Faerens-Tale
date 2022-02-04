using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("main");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void GotoCombatScene()
    {
        SceneManager.LoadScene("Combat");
    }
}

