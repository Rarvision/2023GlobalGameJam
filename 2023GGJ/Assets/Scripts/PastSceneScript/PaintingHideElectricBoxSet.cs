using Unity.VisualScripting;
using UnityEngine;

public class PaintingHideElectricBoxSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.electricityOn = false;
        hasUsed = true;
        SetElectricEffect();
    }

    private void SetElectricEffect()
    {
        var anim = GetComponent<Animator>();
        anim.SetBool("ElectricSwitchTriggered", true);

        var tv = GameObject.Find("TV+plug_A");
        var tvColl = tv.GetComponent<BoxCollider2D>();
        tvColl.enabled = false;
        var tvAnim = tv.GetComponent<Animator>();
        tvAnim.SetBool("ElectricSwitchTriggered", true);
        var fanBehaviour = GameObject.Find("Fan_A").GetComponent<FanBehaviour>();
        fanBehaviour.UpdateFanAnimation();
        var warnerBehaviour = GameObject.Find("Warner_A").GetComponent<WarnerBehaviour>();
        warnerBehaviour.UpdateWarnerAnimation();
        var mopSet = GameObject.Find("Mop_A").GetComponent<MopSet>();
        mopSet.enabled = true;
    }
}