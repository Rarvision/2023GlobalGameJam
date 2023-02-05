using System.Collections;
using UnityEngine;

public class CigarBoxSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        hasUsed = true;
        StartCigarBoxAnimation();
    }

    private void StartCigarBoxAnimation()
    {
        StartCoroutine(SetSmokingState(5));
    }

    IEnumerator SetSmokingState(int waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameManager.cigarBox = true;
        var warnerBehaviour = GameObject.Find("Warner_A").GetComponent<WarnerBehaviour>();
        gameManager.smokeDetected = true;
        warnerBehaviour.UpdateWarnerAnimation();
    }


}
