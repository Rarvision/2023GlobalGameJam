using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    
    // type 0: lighting
    // type 1: smash
    // type 2: slide
    public void Die(int type)
    {
        if (type == 0)
        {
            _anim.SetBool("IsLightningDeath", true);
        } else if (type == 1)
        {
            _anim.SetBool("IsSmashDeath", true);
        } else if (type == 2)
        {
            _anim.SetBool("IsSlipDeath", true);
        }
    }
}
