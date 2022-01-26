using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject Mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        MainmenuButton();
    }
   
     public void PlayNowButton()
      {
         //this is the button that starts the game the play button 
        //  UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
      }
    
    public void ContButton()
    {
        // Show continue to go on from save state???
        Mainmenu.SetActive(false);
        //for when we get the cont code
        //.setActive(true);
    }
    public void LoadButton()
    {
        // Show load possibly takes to new screen ?
        Mainmenu.SetActive(false);
        //for when we get the load code
        //.setActive(true);
    }
    public void OptionsButton()
    {
        // Show options for adjusting 
        Mainmenu.SetActive(false);
        //for when we get the options 
        //.setActive(true);
    }
    public void MainmenuButton()
    {

        Mainmenu.SetActive(true);
        //for the other options to set to not show yet(i.e options , load , cont)
        //.SetActive(false);
    }

    //possible quit if we need it 
    /*  public void QuitButton()
      {
          // Quit Game
          Application.Quit();
      }
    */
}
