using UnityEngine;

// Attach to Player object
public class PlayerMovement : MonoBehaviour
{
    // Game manager
    private GameManager _gameManager;

    // Components
    private Rigidbody2D _rb;

    private SpriteRenderer _sprite;
    // private Animator anim;

    // Basic movement parameters
    private float _inputX = 0.0f;
    [SerializeField] private float runSpeed = 10.0f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        // _anim = GetComponent<Animator>();
        _gameManager = GameManager.Instance;
    }

    private void Update()
    {
        if (!_gameManager.isPastSceneOn) return;

        _inputX = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(_inputX * runSpeed, _rb.velocity.y);
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (_inputX < 0)
        {
            _sprite.flipX = true;
        }
        else if (_inputX > 0)
        {
            _sprite.flipX = false;
        }
    }
}

