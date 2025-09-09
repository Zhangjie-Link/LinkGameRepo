using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneMoveState : EnemyState
{
    private Enemy_One enemy;
    public OneMoveState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, Enemy_One _enemy) : base(_enemyBase, _stateMachine, _animBoolName)
    {
        enemy = _enemy;
    }
      public override void Enter()
    {
        base.Enter();
    }
    public override void Exit()
    {
        base.Exit();
    }
    public override void Update()
    {
        base.Update();
        enemy.SetVelocity(enemy.moveSpeed* enemy.facingDir, enemy.rb.velocity.y);
        if (enemy.IsWallDetected() || !enemy.IsGroundDetected())
        {
            enemy.Flip();
            stateMachine.ChangeState(enemy.idleState);
        }
    }
}
