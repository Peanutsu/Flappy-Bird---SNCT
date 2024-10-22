using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Voar : MonoBehaviour
{
    [SerializeField] private float _velocidade = 1.5f;
    [SerializeField] private float _rotacao = 10f;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasReleasedThisFrame || Mouse.current.leftButton.wasReleasedThisFrame)
        {
            _rb.velocity = Vector2.up * _velocidade;
            if (_rb.gravityScale == 0)
            {
                _rb.gravityScale = 1;
            }
        }
    }
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotacao);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.instance.GameOver();
    }
}
