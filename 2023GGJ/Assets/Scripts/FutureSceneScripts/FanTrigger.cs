using UnityEngine;

public class FanTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (!gameManager.electricityOn || !gameManager.fanTriggerOn)
        {
            doExecute = false;
        }
        else
        {
            // Set animation
            doExecute = true;
        }
    }

    protected override void ExecuteBehaviour()
    {
        // Set animation
    }
}
