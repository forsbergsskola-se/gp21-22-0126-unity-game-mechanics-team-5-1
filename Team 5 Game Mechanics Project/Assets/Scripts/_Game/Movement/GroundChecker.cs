using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool IsGrounded { get; private set; }
    [SerializeField] private float groundCheckLength = 1f;
    [SerializeField] private float groundCheckRadius = 0.5f;
    [SerializeField] private LayerMask groundLayers;

    private void Update()
    {
        var ray = new Ray(transform.position, Vector3.down);
        IsGrounded = Physics.SphereCast(ray, groundCheckRadius, groundCheckLength, groundLayers);

        // Debug.DrawRay(transform.position, Vector3.down * groundCheckLength, Color.magenta);
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawSphere(transform.position + Vector3.down * groundCheckLength, groundCheckRadius);
    //}
}
