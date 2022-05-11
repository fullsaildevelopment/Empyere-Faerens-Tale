using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadinv : MonoBehaviour
{
    public void loadin()
    {
        SceneManager.LoadScene(11, LoadSceneMode.Single);
    }
}
