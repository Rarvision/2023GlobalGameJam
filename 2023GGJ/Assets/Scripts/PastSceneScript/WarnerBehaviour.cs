using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnerBehaviour : MonoBehaviour
{
    public void UpdateWarnerAnimation()
    {
        if (GameManager.Instance.electricityOn && GameManager.Instance.smokeDetected)
        {
            Debug.Log("Warner ON Animation Triggered");
        }
        else
        {
            Debug.Log("Warner OFF Animation Triggered");
        }
    }
    
}
