using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCanos : MonoBehaviour
{
    [SerializeField] private float _velocidade = 0.65f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _velocidade * Time.deltaTime;
    }
}
