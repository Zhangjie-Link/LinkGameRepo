using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string animBoolName) : base(_player, _stateMachine, animBoolName)
    {
    }
    public override void Enter()
    {
        base.Enter();
        player.ZeroVelocity();
    }

    public override void Exit()
    {
        base.Exit();    
    }
    public override void Update()
    {
        base.Update();
        
        if (xInput == player.facingDir && player.IsWallDetected())
            return;
        if (xInput != 0 && !player.isBusy)
            stateMachine.ChangeState(player.moveState);
    }
}
