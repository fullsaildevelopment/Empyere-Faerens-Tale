using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //scene switcher handles menu scene switching
    public void GotoMainScene()
    {
        SceneManager.LoadScene("main");
    }
    //on click goes to game 
    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void GotoCombatScene()
    {
        SceneManager.LoadScene("Combat");
    }
    // these are the main menu buttons :D
    //on click go to settings 
    public void GotoSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }
    //onclick go to load scene
    public void GotoLoadScene()
    {
        SceneManager.LoadScene("Load");
    }
    //onclick go to options
    public void GotoOptions()
    {
        SceneManager.LoadScene("Options");
    }


    //these are the buttons from the main menu options to return to main
   //back button
   public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}

