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
        var player= GameObject.Find("Player_B");
        if (gameManager.electricityOn)
        {
            player.GetComponent<PlayerDeath>().Die(0);
        }
        else
        {
            player.GetComponent<PlayerDeath>().Die(2);
        }
    }
}
