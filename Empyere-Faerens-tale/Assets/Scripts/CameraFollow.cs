using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] GameObject thingToFollow;
    [SerializeField] Vector3 CameraDistance = new Vector3(0,0,-5);

    [SerializeField]float leftlim;
    [SerializeField]float rightlim;
    [SerializeField]float uplim;
    [SerializeField]float downlim;
    //this makes camera follow a thing

    // LateUpdate is called once per frame at the end to ensure ease of control
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + CameraDistance;
    }
}
