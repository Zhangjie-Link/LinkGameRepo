using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    public PlayerGroundedState(Player _player, PlayerStateMachine _stateMachine, string animBoolName) : base(_player, _stateMachine, animBoolName)
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
        if (Input.GetKey(KeyCode.Mouse0))
            stateMachine.ChangeState(player.primaryAttack);

        if (!player.IsGroundDetected())
                stateMachine.ChangeState(player.airState);
        if (Input.GetKeyDown(KeyCode.Space) && player.IsGroundDetected())
            stateMachine.ChangeState(player.jumpState);
    }
    
}
