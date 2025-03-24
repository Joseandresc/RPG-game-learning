using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(PlayerStateMachine _playerStateMachine, Player _player, string aniBoolName) 
     : base(_playerStateMachine, _player, aniBoolName)
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
        if (Input.GetKeyDown(KeyCode.N))
        {
            playerStateMachine.ChangeState(player.moveState);
        }
        }
}
