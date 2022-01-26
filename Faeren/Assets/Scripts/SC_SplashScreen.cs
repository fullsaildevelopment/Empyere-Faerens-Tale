using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class SC_SplashScreen : MonoBehaviour
{
    Image backgroundImage;
    AsyncOperation loadingOperation;
    RectTransform rt;
    float ratio;
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        backgroundImage = GetComponent<Image>();
        rt = backgroundImage.rectTransform;
        ratio = backgroundImage.sprite.bounds.size.x / backgroundImage.sprite.bounds.size.y;
        loadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);

    }
   
    // Update is called once per frame
    void Update()
    {
        if (!rt)
            return;

        //Scale image proportionally to fit the screen dimensions, while preserving aspect ratio
        if (Screen.height * ratio >= Screen.width)
        {
            rt.sizeDelta = new Vector2(Screen.height * ratio, Screen.height);
        }
        else
        {
            rt.sizeDelta = new Vector2(Screen.width, Screen.width / ratio);
        }
       // UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
