using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f; //弾速[m/s]
    [SerializeField] ParticleSystem hitParticlePrehab; //着弾時演出のプレハブ

    // Start is called before the first frame update
    void Start()
    {
        //ゲームオブジェクト前方向の速度ベクトルを計算
        var velocity = speed * transform.forward;
        //Rigidbodyコンポーネントを取得
        var rigidbody = GetComponent<Rigidbody>();
        //初速を与える
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    //トリガー領域進入時に呼び出される
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit!!");
        other.SendMessage("OnHitBullet");
        Instantiate(hitParticlePrehab, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
