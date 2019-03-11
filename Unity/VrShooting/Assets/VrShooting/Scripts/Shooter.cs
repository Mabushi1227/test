using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrehab; //銃のプレハブ
    [SerializeField] Transform gunBarrelEnd; //銃口
    [SerializeField] ParticleSystem gunParticle; //発射時演出
    [SerializeField] AudioSource gunAudioSource;

    // Update is called once per frame
    void Update()
    {
        //入力に応じて弾を発射する
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //プレハブを元に、シーンの上に弾を生成
        Instantiate(bulletPrehab, gunBarrelEnd.position, gunBarrelEnd.rotation);

        //発射時演出を再生
        gunParticle.Play();
        gunAudioSource.Play();
    }
}
