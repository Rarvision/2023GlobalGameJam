using UnityEngine;

public class WaterFloorBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        col.GetComponent<PlayerDeath>().Die(0);
    }
}
