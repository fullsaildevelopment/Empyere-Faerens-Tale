using UnityEngine;

//this is for parralax > : D
public class ScrollingScript : MonoBehaviour
{
   //speed you scrolll
    public Vector2 speed = new Vector2(2, 2);

    //direction
    public Vector2 direction = new Vector2(-1, 0);

   
    public bool isLinkedToCamera = false;

    void Update()
    {
        // Movement
        Vector3 movement = new Vector3(
          speed.x * direction.x,
          speed.y * direction.y,
          0);

        movement *= Time.deltaTime;
        transform.Translate(movement);

        // Move the camera
        if (isLinkedToCamera)
        {
            Camera.main.transform.Translate(movement);
        }
    }
}