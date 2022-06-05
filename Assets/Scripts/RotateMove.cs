using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    [SerializeField] private GameObject _rotateObject;
    private Vector3 _rotAngles;
    private Vector3 _firstInputPosition, _lastInputPosition;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _firstInputPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            _lastInputPosition = Input.mousePosition;
        }

        _rotAngles = _lastInputPosition - _firstInputPosition;

        _rotateObject.transform.rotation = Quaternion.Euler(0, _rotAngles.x, 0);
    }
}
