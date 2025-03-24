using UnityEditor.AnimatedValues;
using UnityEngine;

public class PlayerState 
{
   protected PlayerStateMachine playerStateMachine;
   protected Player player;
   string animBoolName;

    public PlayerState(PlayerStateMachine _playerStateMachine, Player _player, string _animBoolName)
    {
       this.playerStateMachine = _playerStateMachine;
       this.player = _player;
       this.animBoolName = _animBoolName;
    }

    public virtual void Enter()
    {
        Debug.Log("I enter " + animBoolName);

        
    }
    public virtual void Update()
    {
        // Update logic for the state
        Debug.Log("I update " + animBoolName);
    }
    public virtual void Exit()
    {
        Debug.Log("I exit " + animBoolName);
    }
}
