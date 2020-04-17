using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : IState
{
    int startup;
    int damage;
    Health t;
    GameObject e;
    public EnemyAttacking(Health target, Attack a,GameObject _e)
    {
        e = _e;
        t = target;
        startup = a.startup;
        damage = a.damage;
    }
    public void Enter()
    {
        t.StartCoroutine(hit());
    }

    public void Execute()
    {
     
    }

    public void Exit()
    {
       
    }

    IEnumerator hit()
    {
        for(int i = 0; i < startup; i++)
        {
            yield return new WaitForEndOfFrame();
        }
        t.LoseHealth(damage);
        e.GetComponent<Enemy>().canAttack = false;
        e.GetComponent<EnemyStateSystem>().smc.ChangeState(e.GetComponent<EnemyStateSystem>().smc.prevState);
        yield return null;
    }
}
