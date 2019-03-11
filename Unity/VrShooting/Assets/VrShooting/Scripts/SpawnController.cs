using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] float spawnInterval = 3f; //敵の出現間隔

    EnemySpawner[] spawners; //EnemySpawnerのリスト

    float timer = 0f; //出現時間判定用のタイマー設定

    void Start()
    {
        //子オブジェクトに存在するEnenySpawnerのリストを取得
        spawners = GetComponentsInChildren<EnemySpawner>();

    }

    // Update is called once per frame
    void Update()
    {
        //タイマー更新
        timer += Time.deltaTime;

        //出現間隔の判定
        if(spawnInterval < timer)
        {
            //ランダムにEnemySpawnerを選択して敵を出現させる
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();
            timer = 0f;
        }
    }
}
