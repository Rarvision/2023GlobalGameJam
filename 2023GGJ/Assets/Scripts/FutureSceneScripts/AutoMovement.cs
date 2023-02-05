using System.Collections;
using UnityEngine;

// Attach to the "future" player object
public class AutoMovement : MonoBehaviour
{
    // Component
    private Rigidbody2D _rb;
    // _anim = GetComponent<Animator>();
    
    // Basic movement parameter
    [SerializeField] private float runSpeed = 100.0f;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!GameManager.Instance.isFutureSceneOn) return;
        _rb.velocity = new Vector2(runSpeed * Time.deltaTime, _rb.velocity.y);
    }
}
