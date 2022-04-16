using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemychases : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator enemyanim;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



    }
    private void FixedUpdate()
    {
        //enemy is tracking the player  and moves in on them ! 
        Vector3 direction = player.position - transform.position;
        /* float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
         rb.rotation = angle;*/
        direction.Normalize();
        movement = direction;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        //turns enemy left or right 

        if (direction.x > 0)
            transform.localScale = new Vector3(-30, 37, 1);

        else if (direction.x < 0)
            transform.localScale = new Vector3(30, 37, 1);

        //changing the enemy animations :P
        enemyanim.SetFloat("enemyspeed", Mathf.Abs(x));
        enemyanim.SetFloat("enemyvert", Mathf.Abs(y));

        moveCharacter(movement);

        //rotate the character back 

        UnityEngine.Quaternion rotated = transform.rotation;
        transform.Rotate(new Vector3(rotated.x, rotated.y, -rotated.z));
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }


}