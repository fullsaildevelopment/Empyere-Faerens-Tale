using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteManager : MonoBehaviour
{
    [SerializeField] public List<Sprite> BackgroundSprites;
    [SerializeField] public List<Sprite> BattleSprites;

    private void Awake()
    {
        int i = new System.Random().Next(0, BackgroundSprites.Count);
        GameObject.Find("Background").GetComponent<Image>().sprite = BackgroundSprites[i];
        Debug.Log(i);
    }
}
