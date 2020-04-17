using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasing : IState
{
    float speed;
    public GameObject target;
    Rigidbody2D rb;
    public EnemyChasing(Rigidbody2D _rb,GameObject _target,float _runspeed)
    {
        speed = _runspeed/100;
        target = _target;
        rb = _rb;
    }
    public void Enter()
    {
        Debug.Log("PLAYER DETECTED");
    }

    public void Execute()
    {
       rb.MovePosition( Vector2.MoveTowards(rb.position, target.transform.position, speed));
        
    }

    public void Exit()
    {
        Debug.Log("player went too far for me to chase");
    }
}
