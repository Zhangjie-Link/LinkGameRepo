using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAttackState : EnemyState
{
    private Enemy_One enemy;

    public OneAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, Enemy_One enemy) : base(_enemyBase, _stateMachine, _animBoolName)
    {
        this.enemy = enemy;
    }
     public override void Enter()
    {
        base.Enter();
     
    }
    public override void Update()
    {
        base.Update();
        enemy.SetZeroVelocity();
        if (triggerCalled)
            stateMachine.ChangeState(enemy.battleState);
       
    }



    public override void Exit()
    {
        base.Exit();
        enemy.lastTimeAttacked = Time.time;
    }
}
