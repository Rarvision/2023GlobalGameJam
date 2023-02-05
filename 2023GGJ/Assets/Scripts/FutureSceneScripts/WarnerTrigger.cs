using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnerTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (!gameManager.electricityOn || !gameManager.smokeDetected)
        {
            // animation
            // generater water
        }
    }

    protected override void ExecuteBehaviour()
    {
    }
}
