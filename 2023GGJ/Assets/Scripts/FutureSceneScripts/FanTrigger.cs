using System.Collections;
using UnityEngine;

public class FanTrigger : FurnitureTrigger
{
    private float _chaseSpeed = 20.0f;
    protected override void StateSetUp()
    {
        var anim = GetComponent<Animator>();
        if (!gameManager.electricityOn || !gameManager.fanTriggerOn)
        {
            doExecute = false;
            anim.SetBool("IsStopped", true);
        }
        else
        {
            // Set animation
            doExecute = true;
            anim.SetBool("IsStopped", false);
        }
    }

    protected override void ExecuteBehaviour()
    {
        StartCoroutine(ChasePlayer());

    }

    IEnumerator ChasePlayer()
    {
        var player = GameObject.Find("Player_B").transform;
        while (true)
        {
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position,
                player.position, _chaseSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, player.position) <=
                _chaseSpeed * Time.deltaTime)
            {
                Destroy(gameObject);
                player.gameObject.GetComponent<PlayerDeath>().Die(1);
            }

        }
    }
}
