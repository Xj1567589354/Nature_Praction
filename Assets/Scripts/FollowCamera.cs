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
        //��ȡ��ҵĳ�ʼλ��
        follow = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        //��ȡ��Һ��Ϸ�ĳһ���λ��
        TargetPosition = follow.position + Vector3.up * distance_up - follow.forward * distance_away;
        //��ֵʵ��������ִﶨ��
        transform.position = Vector3.Lerp(transform.position, TargetPosition, Time.deltaTime*smooth);
        //�����ʵ�ָ������
        transform.LookAt(follow);
    }
}
