using UnityEngine;

public class FanBehaviour : MonoBehaviour
{
    private bool _funSpinning = true;
    public void UpdateFanAnimation()
    {
        if (!GameManager.Instance.electricityOn)
        {
            _funSpinning = false;
        }
        else
        {
            _funSpinning = !_funSpinning;
        }

        if (_funSpinning)
        {
            Debug.Log("Fun ON Animation Triggered");
        }
        else
        {
            Debug.Log("Fun OFF Animation Triggered");
        }
    }
}
