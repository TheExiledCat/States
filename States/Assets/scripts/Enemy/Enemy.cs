using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3[] patrolPoints = new Vector3[2];
    public float speed;
    public float visionRadius;
    public Attack punch;
    public int attackCooldown;
    int timer;
    public  bool canAttack;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(visionRadius, visionRadius));
    }
    void Update()
    {
        timer++;

        if (timer % attackCooldown == 0)
        {
            canAttack = true;
        }
    }
}
