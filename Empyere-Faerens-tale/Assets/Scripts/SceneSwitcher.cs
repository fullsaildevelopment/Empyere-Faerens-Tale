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
    public void GotoMenuScene()// this has the first village in it/ courtyard and etc 
    {
        SceneManager.LoadScene("Capital");
    }
    public void Gototitan()
    {
        SceneManager.LoadScene("giant");
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
    //goes to character menu 
    public void GotoChrcmenu()
    {
        SceneManager.LoadScene("Chrmenu");
    }
    public void GotoCastle()
    {
        SceneManager.LoadScene("innercastle");
    }
    public void GottoNar()
    {
        SceneManager.LoadScene("Opening Narration");
    }
   
   
    //these are the buttons from the main menu options to return to main
   //back button
   public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
   
    
}

