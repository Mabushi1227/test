using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField] float angularVelocity = 30f;
    float horizontalAngle = 0f;
    float verticalAngle = 0f;
#if UNITY_EDITOR
    // Update is called once per frame
    void Update()
    {
        //入力による回転量を取得
        var horizontalRotation = Input.GetAxis("Horizontal") * angularVelocity * Time.deltaTime;
        var verticalRotation = -Input.GetAxis("Vertical") * angularVelocity * Time.deltaTime;

        //回転量を更新
        horizontalAngle += horizontalRotation;
        verticalAngle += verticalRotation;

        //垂直方向は回転し過ぎないように制限
        verticalAngle = Mathf.Clamp(verticalAngle, -80f, 80f);
        //Transformコンポーネントに回転量を適用する
        transform.rotation = Quaternion.Euler(verticalAngle, horizontalAngle, 0f);
    }
#endif
}
