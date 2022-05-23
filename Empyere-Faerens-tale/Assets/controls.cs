using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controls : MonoBehaviour
{
    public GameObject Panel;  
    public void PanelOpener() {  
        if (Panel != null) {  
            bool isActive = Panel.activeSelf;  
            Panel.SetActive(!isActive);  
        }  
    }  
}
