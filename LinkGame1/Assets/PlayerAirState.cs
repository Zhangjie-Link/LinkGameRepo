using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerState
{
    public PlayerAirState(Player _player, PlayerStateMachine _stateMachine, string animBoolName) : base(_player, _stateMachine, animBoolName)
    {
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
        if (player.IsGroundDetected())
            stateMachine.ChangeState(player.idleState);
    }
}
