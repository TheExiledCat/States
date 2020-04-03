using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWandering : IState
{
    Rigidbody2D rb;
    Vector3 patrolA;
    Vector3 patrolB;
    bool movinToA;
    float speed;
    public EnemyWandering(Rigidbody2D _rb,Vector3 A,Vector3 B,float _speed)
    {
        rb = _rb;
        patrolA = A;
        patrolB = B;
        speed = _speed;
    }
    public void Enter()
    {
        movinToA = true;
    }

    public void Execute()
    {
        Vector2 pos=rb.transform.position;
        if (movinToA)
            pos = Vector2.MoveTowards(pos,patrolA,speed);
        else
        {
            pos = Vector2.MoveTowards(pos, patrolB, speed);
        }
        rb.transform.position = pos;
    }

    public void Exit()
    {
        
    }
}
