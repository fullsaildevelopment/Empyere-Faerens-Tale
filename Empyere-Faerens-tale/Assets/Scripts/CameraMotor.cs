using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform lookatme;
    public float boundX = 0.05f;//0.15
    public float boundY = 0.05f;
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        //checks if we are in the bounds for the x axis for the camera 
        float deltaX = lookatme.position.x - transform.position.x;
        if(deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < lookatme.position.x)
            {
                delta.x = deltaX - boundX;

            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        //checks if we are in the bounds for the y axis for the camera 

        float deltaY = lookatme.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookatme.position.y)
            {
                delta.y = deltaY - boundY;

            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
