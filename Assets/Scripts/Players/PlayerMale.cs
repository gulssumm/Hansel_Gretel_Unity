using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMale : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed;
    void Update()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            direction += Vector3.forward;
        if (Input.GetKey(KeyCode.S))
            direction += Vector3.back;
        if (Input.GetKey(KeyCode.A))
            direction += Vector3.left;
        if (Input.GetKey(KeyCode.D))
            direction += Vector3.right;

        // Rigidbody hareketi
        _rb.velocity = direction.normalized * speed;

    }
}
