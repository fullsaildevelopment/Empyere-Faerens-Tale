using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform player;
    public float followspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = player.position;
        transform.position = Vector3.Lerp(a, b, followspeed);
    }
}
