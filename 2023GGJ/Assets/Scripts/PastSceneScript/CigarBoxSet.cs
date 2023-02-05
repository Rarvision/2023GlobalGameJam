using System.Collections;
using UnityEngine;

public class CigarBoxSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.cigarBox = true;
        hasUsed = true;
        StartCigarBoxAnimation();
    }

    private void StartCigarBoxAnimation()
    {
        Debug.Log("Cigar box animation started");
        gameManager.cigarBox = true;
        StartCoroutine(SetSmokingState(5));
    }

    IEnumerator SetSmokingState(int waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        var warnerBehaviour = GameObject.Find("Warner").GetComponent<WarnerBehaviour>();
        gameManager.smokeDetected = true;
        warnerBehaviour.UpdateWarnerAnimation();
    }


}
