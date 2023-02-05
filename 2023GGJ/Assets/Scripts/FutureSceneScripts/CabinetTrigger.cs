using System.Collections;
using UnityEngine;

public class CabinetTrigger : FurnitureTrigger
{
    public Sprite fallCabinet;
    protected override void StateSetUp()
    {
        if (!gameManager.cabinet)
        {
            doExecute = true;
        }
        else
        {
            GetComponent<Animator>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = fallCabinet;
            doExecute = false;
        }
    }

    protected override void ExecuteBehaviour()
    {
        GetComponent<Animator>().SetTrigger("Fall");
        StartCoroutine(SetPlayerDie(0.7f));
    }

    IEnumerator SetPlayerDie(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        var player= GameObject.Find("Player_B");
        player.GetComponent<PlayerDeath>().Die(1);
    }

}
