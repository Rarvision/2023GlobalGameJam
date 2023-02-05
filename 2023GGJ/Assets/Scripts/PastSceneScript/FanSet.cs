using UnityEngine;

public class FanSet : FurnitureSet
{
    private int _usedCount = 0;
    private const int ALLOWEDUSEDTIME= 3;
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.fanTriggerOn = !gameManager.fanTriggerOn;
        _usedCount++;
        var fan = gameObject.transform.Find("Fan_A");
        fan.gameObject.GetComponent<FanBehaviour>().UpdateFanAnimation();
        if (_usedCount == ALLOWEDUSEDTIME)
        {
            hasUsed = true;
        }
    }
}