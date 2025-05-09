using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    [SerializeField] Transform _point;
    [SerializeField] float _speed = 3f;

    void Update()
    {
        transform.RotateAround(_point.position, Vector3.forward, _speed * Time.deltaTime);
    }
}
