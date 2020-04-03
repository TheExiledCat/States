using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    EnemyStateSystem ess;
    Enemy e;
    void Awake()
    {
       
        ess = GetComponent<EnemyStateSystem>();
        ess.Starting += AddStates;
    }
    
    void AddStates()
    {
        e = GetComponent<Enemy>();

        print(e);

        ess.states.Add("Wandering", new EnemyWandering(e.rb, e.patrolPoints[0], e.patrolPoints[1], e.speed));

    }
}
