using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWandering : IState
{
    Rigidbody2D rb;
    Vector3 patrolA;
    Vector3 patrolB;
    bool movingToA;
    float speed;
    public EnemyWandering(Rigidbody2D _rb,Vector3 A,Vector3 B,float _speed)
    {
        rb = _rb;
        patrolA = A;
        patrolB = B;
        speed = _speed/100;
    }
    public void Enter()
    {
        movingToA = true;
    }

    public void Execute()
    {
        Debug.Log("MOVING");
        Vector2 pos=rb.transform.position;
        if (movingToA)
        {
            
            pos = Vector2.MoveTowards(pos, patrolA, speed);
        }
            
        else
        {
            pos = Vector2.MoveTowards(pos, patrolB, speed);
        }
        
        rb.transform.position=pos;

        if (Vector2.Distance(rb.transform.position, patrolA) <= 1 && movingToA)
        {
            movingToA = false;
        }else if (Vector2.Distance(rb.transform.position, patrolB) <= 1 && !movingToA)
        {
            movingToA = true;
        }
    }

    public void Exit()
    {
        
    }
}
