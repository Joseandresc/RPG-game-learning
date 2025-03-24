using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerStateMachine playerStateMachine { get; private set; }
    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }


    private void Awake()
    {
        playerStateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(playerStateMachine, this, "idle");
        moveState = new PlayerMoveState(playerStateMachine, this, "move");
    }
    private void Start()
    {
        playerStateMachine.Initialize(idleState);
    }
    private void Update()
    {
        playerStateMachine.currentState.Update();
        
    }
}
