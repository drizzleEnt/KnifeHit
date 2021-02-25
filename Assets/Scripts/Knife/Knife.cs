using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Knife : MonoBehaviour
{
    [SerializeField] private KnifeMover _knifeMover;

    private BoxCollider2D _collider;

    public event UnityAction<Knife> RanIntoKnife;
    public event UnityAction<Knife> RanIntoLog;
    public event UnityAction RanIntoApple;

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Log log))
        {
            RanIntoLog?.Invoke(this);
            _knifeMover.StopMovement();
            gameObject.transform.parent = log.transform;
            _knifeMover.enabled = false;
        }

        if (collision.TryGetComponent(out Apple apple))
            RanIntoApple?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Knife knife))
        {
            RanIntoKnife?.Invoke(this);
            _knifeMover.OnOtherKnifeEneter();
            _collider.enabled = false;
            _knifeMover.enabled = false;
        }
    }

    public void SetStartPosition(Vector3 position)
    {
        _knifeMover.MoveToStartPosition(position);
    }

    public void OnLevelComplite()
    {
        _knifeMover.TurnOnGravity();
    }
}
