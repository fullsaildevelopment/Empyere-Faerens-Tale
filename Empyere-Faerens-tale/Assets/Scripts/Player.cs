using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D boxCollider;
    //keeps track of moving 
    private Vector3 moveDelta;
    private RaycastHit2D baam;
    public float milestailsprower;
    public float PlayerSpeed;
    //switches sprites accessing animator script
    public Animator animator;
    public int tmp;
    private Vector2 movedirection;
    public Rigidbody2D buff;
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        Move();
        
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        movedirection = new Vector2(x, y);
        //reset the Movedelta
        moveDelta = new Vector3(x, y,3);
        //turns left or right and up and down 
        if (moveDelta.x > 0)
            transform.localScale = new Vector3(-6, 6, 6);

        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(6, 6, 6);
        animator.SetFloat("speed", Mathf.Abs(x));

        //collision 
        baam = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("People", "Blocking"));
       //didn't hit anything
       if(baam.collider == null)
        {
            transform.Translate(0,moveDelta.y * Time.deltaTime,0);
        }
        baam = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2( moveDelta.x,0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("People", "Blocking"));
        //didn't hit anything
        if (baam.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime,0, 0);
        }
       
        UnityEngine.Quaternion rotated = transform.rotation;
        transform.Rotate(new Vector3(rotated.x,rotated.y,-rotated.z));


       
    }

   void Move()
    {
        buff.velocity = new Vector2(movedirection.x * PlayerSpeed, movedirection.y * PlayerSpeed);
    }
}
