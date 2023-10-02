using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class bullet : MonoBehaviour
{
    public float Speed;

    void OnBecameInvisible()//�Ƴ���Ļ��ɾ��
    {
        Destroy(gameObject);
    }
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);//�ӵ����Ϸ���
    }
    public void OnTriggerEnter2D(Collider2D other)//�ӵ�����������
    {
        if (other.tag == "Wall")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
