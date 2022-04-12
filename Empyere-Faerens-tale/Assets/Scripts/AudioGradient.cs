using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGradient : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject object1;
    [SerializeField] GameObject object2;
    [SerializeField] GameObject player;
    float objectDistance;
    void Start()
    {
        objectDistance = Distance(object1,object2);
        Debug.Log(objectDistance);
    }

    // Update is called once per frame
    void Update()
    {
        object1.GetComponent<AudioSource>().volume = ((Distance(player,object2))/objectDistance);
        object2.GetComponent<AudioSource>().volume = ((Distance(player,object1))/objectDistance);

        object1.GetComponent<AudioSource>().volume = object1.GetComponent<AudioSource>().volume/4;
        object2.GetComponent<AudioSource>().volume = object2.GetComponent<AudioSource>().volume/4;
    }
    float Distance(GameObject object1, GameObject object2)
    {
        return Mathf.Sqrt(Mathf.Pow(object1.transform.position.x-object2.transform.position.x,2)+Mathf.Pow(object1.transform.position.y-object2.transform.position.y,2) );
    }
}
