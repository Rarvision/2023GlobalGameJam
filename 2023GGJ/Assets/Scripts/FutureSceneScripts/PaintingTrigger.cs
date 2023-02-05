using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (gameManager.painting)
        {
            Destroy(gameObject);
        }
    }

    protected override void ExecuteBehaviour()
    {
    }
}
