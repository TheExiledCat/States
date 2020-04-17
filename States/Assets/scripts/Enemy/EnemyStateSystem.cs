using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyStateSystem : StateSystem
{
    public  event Action Starting;
    [HideInInspector]
    
    public Dictionary<string, IState> states = new Dictionary<string, IState>();
    [SerializeField]
    Collider2D[] detection;
    Enemy e;
    public LayerMask player;
    // Start is called before the first frame update
    void Awake()
    {
        e = GetComponent<Enemy>();
    }
    void Start()
    {
        
        if(Starting!=null)
        Starting();

        if (states.Count > 0)
            if(states["Wandering"]!=null)
        smc.ChangeState(states["Wandering"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        smc.Update();
        //transitions
        if (Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) > (GetComponent<Enemy>().visionRadius * 2))
        {
            smc.ChangeState(states["Wandering"]);
        }
        detection = Physics2D.OverlapBoxAll(transform.position,new Vector2( e.visionRadius,e.visionRadius),0,player);
        if (detection.Length > 0&&smc.currentState!=states["Attacking"] )
        {
            
            smc.ChangeState(states["Chasing"]);
        }
        if (Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < (GetComponent<Enemy>().visionRadius / 3)&&e.canAttack)
        {
            smc.ChangeState(states["Attacking"]);
           
        }


    }
   
}
