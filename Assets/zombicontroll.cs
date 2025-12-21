using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombicontroll : MonoBehaviour
{
    
    public float speed = 1; // スピード：Inspectorで指定
   public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
          //GameObject player = GameObject.Find("player");   // 目標オブジェクト名
    }
private void FixedUpdate() // ずっと、目標オブジェクトの方向を調べて
    {
        Vector3 dir = (player.transform.position - this.transform.position).normalized;
        // その方向へ指定した量で進む
        float vx = dir.x * speed;
        float vz = dir.z * speed;
        this.transform.Translate(vx / 50, 0,  vz / 50);
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision other)
{
    Debug.Log("死んでしまった");
}
}
