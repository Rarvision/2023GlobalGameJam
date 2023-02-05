using UnityEngine;

public class WarnerTrigger : FurnitureTrigger
{
    protected override void StateSetUp()
    {
        if (gameManager.electricityOn && gameManager.smokeDetected)
        {
            var warning = gameObject.transform.Find("Warning_B");
            warning.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            var waterFloor = GameObject.Find("WaterFloor_B");
            waterFloor.GetComponent<Collider2D>().enabled = true;
            waterFloor.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    protected override void ExecuteBehaviour()
    {
    }
}
