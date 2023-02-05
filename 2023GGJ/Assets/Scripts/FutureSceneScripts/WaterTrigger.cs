using UnityEngine;

public class WaterTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (gameManager.mop)
        {
            Destroy(gameObject);
            return;
        }

        doExecute = true;
    }

    protected override void ExecuteBehaviour()
    {
        if (gameManager.electricityOn)
        {
            // electric animation
        }
        else
        {
            // slid animation
        }
    }
}
