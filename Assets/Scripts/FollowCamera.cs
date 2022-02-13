using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public float distance_away;
    public float distance_up;
    public Vector3 TargetPosition;
    public float smooth;
    Transform follow;

    void Start()
    {
        //获取玩家的初始位置
        follow = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        //获取玩家后上方某一点的位置
        TargetPosition = follow.position + Vector3.up * distance_up - follow.forward * distance_away;
        //插值实现摄像机抵达定点
        transform.position = Vector3.Lerp(transform.position, TargetPosition, Time.deltaTime*smooth);
        //摄像机实现跟踪玩家
        transform.LookAt(follow);
    }
}
