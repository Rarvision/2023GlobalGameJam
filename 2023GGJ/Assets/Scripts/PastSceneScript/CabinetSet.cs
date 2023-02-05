using UnityEngine;

public class CabinetSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.cabinet = true;
        hasUsed = true;
        StartCabinetBoxAnimation();
    }

    private void StartCabinetBoxAnimation()
    {
        var anim = GetComponent<Animator>();
        anim.SetBool("PushCabinet", true);
    }
}
