using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpHeight = 5f;
    public Transform footPosition;
    public LayerMask groundLayer;
    public float speed;

    private Rigidbody2D _rigidbody;
    private Vector2 _playerInput;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    private bool _isGround;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerInput = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

        if (_rigidbody.velocity.x > 0) _spriteRenderer.flipX = false;
        else _spriteRenderer.flipX = true;

        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x,jumpHeight);
        }
    }

    private void FixedUpdate() 
    {
        _rigidbody.velocity = new Vector2(_playerInput.x* Time.fixedDeltaTime * speed,_rigidbody.velocity.y);   
        _animator.SetFloat("move_speed", Mathf.Abs(_rigidbody.velocity.x));

        var hit2D = Physics2D.BoxCast(footPosition.position,new Vector2(0.1f,0.02f), 0f,Vector2.down,0,groundLayer);
        _isGround = (hit2D.collider != null);
    }
}
