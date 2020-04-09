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
    
    // Start is called before the first frame update
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

    }
}
