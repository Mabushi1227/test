using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy enemyPrehab; //出現させる敵のプレハブ

    Enemy enemy; //出現させる敵の保持

    public void Spawn()
    {
        //出現中でなければ敵を出現
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrehab, transform.position, transform.rotation);
        }
    }
}
