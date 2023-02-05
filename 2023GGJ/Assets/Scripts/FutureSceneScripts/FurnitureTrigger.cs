using System;
using UnityEngine;

public abstract class FurnitureTrigger: MonoBehaviour
{
    // Game manager
    protected GameManager gameManager;
    // True if the object should do execute
    protected bool doExecute = false;
    // Set true after state set up
    private bool _hasStarted = false;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void Update()
    {
        if (!gameManager.isFutureSceneOn) return;
        if (_hasStarted) return;
        StateSetUp();
        _hasStarted = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (doExecute)
        { 
            ExecuteBehaviour();   
        }
    }

    // Set up initial state according to scene A
    protected abstract void StateSetUp();
    
    // Execute actual behaviour
    protected abstract void ExecuteBehaviour();
}
