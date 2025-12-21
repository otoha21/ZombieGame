using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrole : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        // Wキー（前方移動）
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }
 
        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = - transform.forward * speed;
        }
 
        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
 
        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
    }
 //座標の変数定義
Vector3 pos;
}
