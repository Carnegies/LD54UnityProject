using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class bullet : MonoBehaviour
{
    public float Speed;

    void OnBecameInvisible()//移出屏幕后删除
    {
        Destroy(gameObject);
    }
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);//子弹向上发射
    }
    public void OnTriggerEnter2D(Collider2D other)//子弹碰到了物体
    {
        if (other.tag == "Wall")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
