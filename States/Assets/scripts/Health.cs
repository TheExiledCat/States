using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Health : MonoBehaviour
{
    [SerializeField]
    int health, maxHealth;
 
  
    public event Action OnHealthChange;
    public event Action OnDie;
    public int GetHealth()
    {
        return health;
    }
   
    public void LoseHealth(int amount)
    {
        
        health -= amount;
        if (health == 0)
        {
            Die();
        }
        if(OnHealthChange!=null)
        OnHealthChange();


    }
   
    public void SetHealth(int amount)
    {
        maxHealth = amount;
        health = maxHealth;
        
    }
    void Start()
    {

        SetHealth(maxHealth);
        
        
    }
    
    void Die()
    {
        if(OnDie!=null)
        OnDie();
        print("dead");
        GetComponent<BoxCollider2D>().enabled = false;
        //Destroy(gameObject);
        
    }
}
