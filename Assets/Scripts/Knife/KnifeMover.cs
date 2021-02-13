using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof (Rigidbody2D))]
public class KnifeMover : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _troughDeley;
    
    private PlayerInput _playerInput;
    private Rigidbody2D _rigidbody;
    private float _elapsedTime;
    private float _reflectForce = 20;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
        _playerInput.Player.ThruoghKnife.performed += ctx => Move();
    }

    private void OnDisable()
    {
        _playerInput.Player.ThruoghKnife.performed -= ctx => Move();
        _playerInput.Disable();
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
    }

    private void Move()
    {
        if (_elapsedTime <= _troughDeley)
            return;
        _rigidbody.AddForce(new Vector2(0, _force), ForceMode2D.Impulse);
        _elapsedTime = 0f;
    }

    public void StopMovement()
    {
        _rigidbody.velocity = new Vector2(0,0);
        _rigidbody.bodyType = RigidbodyType2D.Static;
    }

    public void OnOtherKnifeEneter()
    {
        _rigidbody.velocity = new Vector2(0, 0);
        _rigidbody.velocity = new Vector2(0, -_reflectForce);
        _rigidbody.gravityScale = 1f;
    }

    public void MoveToStartPosition(Vector3 position)
    {
        transform.DOMove(position, .1f).SetEase(Ease.Linear);
    }

    public void TurnOnGravity()
    {
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
        _rigidbody.AddForce(new Vector2(0, -_force * 10));
    }
}
