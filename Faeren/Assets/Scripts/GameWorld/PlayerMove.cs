using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float playSpeed = .15f;
    [SerializeField] Animator animations;
    void Start()
    {
        transform.position.Set(0,0,0);
        animations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float isRunning = Input.GetAxis("Fire3");
        if (isRunning !=0)
        {
            playSpeed = 4.25f;
        }
        else 
        {
            playSpeed = 2.75f;
        }
        float movementHorizontal = Input.GetAxis("Horizontal")*Time.deltaTime*playSpeed;
        transform.Translate(movementHorizontal, 0, 0);
        float movementVertical = Input.GetAxis("Vertical")*Time.deltaTime*playSpeed;
        transform.Translate(0, movementVertical, 0);
        if(movementHorizontal <0)
        {
            
            animations.SetBool("Move left", true);

            animations.SetBool("move right", false);
            animations.SetBool("Move Down", false);
            animations.SetBool("Move Up", false);

        }
        else if (movementHorizontal >0){
            
            animations.SetBool("move right", true);

            animations.SetBool("Move left", false);
            animations.SetBool("Move Down", false);
            animations.SetBool("Move Up", false);

        }
        
        
        if(movementVertical <0)
        {
            
            animations.SetBool("Move Down", true);

            animations.SetBool("Move left", false);
            animations.SetBool("move right", false);
            animations.SetBool("Move Up", false);

        }
        else if (movementVertical >0){
            animations.SetBool("Move Up", true);
            animations.SetBool("Move left", false);
            animations.SetBool("move right", false);
            animations.SetBool("Move Down", false);
        }
        if(movementVertical ==0&&movementHorizontal==0)
        {
                        animations.SetBool("Move Up", false);
            animations.SetBool("Move left", false);
            animations.SetBool("move right", false);
            animations.SetBool("Move Down", false);
        }
        UnityEngine.Quaternion rotated = transform.rotation;
        transform.Rotate(new Vector3(rotated.x,rotated.y,-rotated.z));
    }
}
