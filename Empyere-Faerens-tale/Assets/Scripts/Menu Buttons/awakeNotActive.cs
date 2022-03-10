using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeNotActive : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
}
