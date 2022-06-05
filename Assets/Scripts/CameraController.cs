using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _ball;
    private Vector3 _offset;
    [SerializeField] private float _smoothSpeed;
    void Start()
    {
        _offset = transform.position - _ball.position;
    }

   
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _offset + _ball.position, _smoothSpeed);
        transform.position = newPos;
    }
}
