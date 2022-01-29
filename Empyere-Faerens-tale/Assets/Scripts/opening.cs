using UnityEngine;
using UnityEngine.SceneManagement;

public class opening : MonoBehaviour
{
    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Title");
    }
}
