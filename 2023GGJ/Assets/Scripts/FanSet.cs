using UnityEngine;

public class FanSet : FurnitureSet
{
    private int _usedCount = 0;
    private const int ALLOWEDUSEDTIME= 3;
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.fanTrigger = !gameManager.fanTrigger;
        _usedCount++;
        var fan = gameObject.transform.Find("Fan");
        fan.gameObject.GetComponent<FanBehaviour>().StartFunAnimation();
        if (_usedCount == ALLOWEDUSEDTIME)
        {
            hasUsed = true;
        }
    }
}