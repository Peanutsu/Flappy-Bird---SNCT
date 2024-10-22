using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopGround : MonoBehaviour
{
   [SerializeField] private float _velocidade = 1f;
   [SerializeField] private float _largura = 6f;
    private Vector2 _tamanhoInicial;
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.drawMode = SpriteDrawMode.Tiled;
        _tamanhoInicial = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }
    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _velocidade * Time.deltaTime, _spriteRenderer.size.y);
        if (_spriteRenderer.size.x > _largura)
        {
            _spriteRenderer.size = _tamanhoInicial;
        }
    }
}

