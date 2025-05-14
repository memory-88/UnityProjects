using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float Speed = 1500f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Speed);
    }
}
