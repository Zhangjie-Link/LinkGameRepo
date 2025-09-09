using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_One : Enemy
{
    #region  State
public OneIdleState idleState { get; private set; }
public OneMoveState moveState { get; private set; }
    #endregion

    protected override void Awake()
    {
        base.Awake();
        idleState = new OneIdleState(this, stateMachine, "Idle", this);
        moveState = new OneMoveState(this, stateMachine, "Move", this);
    }
    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);
    }
    protected override void Update()
    {
        base.Update();
    }
}
