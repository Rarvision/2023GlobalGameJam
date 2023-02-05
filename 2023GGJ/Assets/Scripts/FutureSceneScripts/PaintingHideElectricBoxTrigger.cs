using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingHideElectricBoxTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (!gameManager.electricityOn)
        {
            // use different sprite
        }
    }

    protected override void ExecuteBehaviour()
    {
    }
}
