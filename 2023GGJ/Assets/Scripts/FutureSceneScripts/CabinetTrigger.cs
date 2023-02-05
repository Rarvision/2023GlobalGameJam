using UnityEngine;

public class CabinetTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (!gameManager.cabinet)
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
