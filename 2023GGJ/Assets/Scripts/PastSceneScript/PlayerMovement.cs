using UnityEngine;

// Attach to Player object
public class PlayerMovement : MonoBehaviour
{
    // Game manager
    private GameManager _gameManager;

    // Components
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;
    private Animator _anim;
    
    // Animation parameter
    private int _animInt = 0;

    // Basic movement parameters
    private float _inputX = 0.0f;
    [SerializeField] private float runSpeed = 250.0f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
        _gameManager = GameManager.Instance;
    }

    private void Update()
    {
        if (!_gameManager.isPastSceneOn) return;

        _inputX = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(_inputX * runSpeed * Time.deltaTime, _rb.velocity.y);
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (_inputX < 0)
        {
            _sprite.flipX = true;
            _animInt = 1;
        }
        else if (_inputX > 0)
        {
            _sprite.flipX = false;
            _animInt = 1;
        }
        else
        {
            _animInt = 0;
        }
        _anim.SetInteger("Player_A_State", _animInt);

        if (_gameManager.cigarBox)
        {
            _anim.SetBool("IsSmoking", true);
        }
    }
}

