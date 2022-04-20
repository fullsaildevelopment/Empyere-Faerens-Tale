using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotButton : MonoBehaviour
{
    [SerializeField] public GameObject go;
    public BaseObject item;
    public void slotClick()
    {
        go.SetActive(true);
        go.GetComponent<itemContainer>().item = item as Item;
    }
}
