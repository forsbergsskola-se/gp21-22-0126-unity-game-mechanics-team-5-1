using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    [SerializeField] private float SpinSpeed;
    
    void Update()
    {
        transform.Rotate(0f,SpinSpeed * Time.deltaTime,0f, Space.Self);
    }
}
