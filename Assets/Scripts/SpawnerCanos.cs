using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCanos : MonoBehaviour
{
    [SerializeField] private float _tempoMaximo = 1.5f;
    [SerializeField] private float _Altura = 0.45f;
    [SerializeField] private GameObject _cano;
    private float _timer;
    void Start()
    {
        SpawnCanos();
    }

    void Update()
    {
        if (_timer > _tempoMaximo)
        {
            SpawnCanos();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
    // Update is called once per frame
    private void SpawnCanos()
    {
        Vector3 posicao = transform.position + new Vector3(0, Random.Range(-_Altura, _Altura), 0);
        GameObject novoCano = Instantiate(_cano, posicao, Quaternion.identity);
        Destroy(novoCano, 10);
    }   
}
