using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthModulator : MonoBehaviour
{
    int healthMax;
    public int currHealth;
    StatBlocks stat;
    Component healthBar;
    void Start()
    {
        stat = GetComponent<StatBlocks>();
        healthMax = stat.Health;
        currHealth = healthMax;
        healthBar = GetComponent("HealthBar");
       
    }
    void Update()
    {
        //healthBar.transform.localScale.Set((healthMax/currHealth),.05f ,1);
        
    }


}
