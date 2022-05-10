using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    // :D Inventory for player!!!

    public InventoryObject inventory;

    // for pickups / inventory
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var item = collision.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(collision.gameObject);
        }
    }
    //clears the inventory 
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
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
            transform.localScale = new Vector3(-3, 3, 6);

        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(3, 3, 6);
        animator.SetFloat("speed", Mathf.Abs(x));
        //whether to go to the facing away anim or not
        animator.SetFloat("vertical", Mathf.Abs(y));

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
       
        //rotate back if soemthing hits the player 
        UnityEngine.Quaternion rotated = transform.rotation;
        transform.Rotate(new Vector3(rotated.x,rotated.y,-rotated.z));
        


       
    }
    //save and loading for the inventory :) 
    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            inventory.Save();
            Debug.Log("saving");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            inventory.Load();
            Debug.Log("loading");
        }*/
    }
   void Move()
    {
        buff.velocity = new Vector2(movedirection.x * PlayerSpeed, movedirection.y * PlayerSpeed);
    }

    //saving and loading 

    public void  SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        inventory.Save();
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
       Scene scene = SceneManager.GetActiveScene();
        inventory.Load();
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }
   
    

}
