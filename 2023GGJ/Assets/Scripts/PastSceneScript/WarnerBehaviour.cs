using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnerBehaviour : MonoBehaviour
{
    public void UpdateWarnerAnimation()
    {
        var warning = gameObject.transform.Find("Warning_A");
        if (GameManager.Instance.electricityOn && GameManager.Instance.smokeDetected)
        {
            warning.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            warning.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    
}
