using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] float _speed = 3f;

    void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
