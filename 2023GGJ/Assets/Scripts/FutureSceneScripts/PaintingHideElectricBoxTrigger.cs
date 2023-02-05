using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingHideElectricBoxTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (!gameManager.electricityOn)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    protected override void ExecuteBehaviour()
    {
    }
}
