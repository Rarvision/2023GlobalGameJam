using UnityEngine;

public class FanBehaviour : MonoBehaviour
{
    private bool _funSpinning = true;
    
    public void UpdateFanAnimation()
    {
        var anim = GetComponent<Animator>();
        if (!GameManager.Instance.electricityOn)
        {
            _funSpinning = false;
        }
        else
        {
            _funSpinning = !_funSpinning;
        }
        
        anim.SetBool("IsStopped", !_funSpinning);

    }
}
