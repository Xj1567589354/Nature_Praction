using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    protected Animator animator;
    public float DampTime = 0.25f;
    public bool Gravity = true;
     void Start()
    {
        animator = GetComponent<Animator>();
        /*
         * ���ò������ȼ�
         * ����Խ�ͣ�Խ������ʾ
         * ��������
         */
        //if (animator.layerCount>-2)
        //{
        //    animator.SetLayerWeight(1, 1);
        //}
    }
    private void Update()
    {
        if (animator)
        {
            //�洢animator�еĶ���״̬
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

            //��������
            if (stateInfo.IsName("Base Layer.Walk"))
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    animator.SetBool("Jump", true);
                }
                else
                {
                    animator.SetBool("Jump", false);
                }
            }

            //�ƶ�
            float h = Input.GetAxis("Horizontal");     
            float v = Input.GetAxis("Vertical");

            //���ö���״̬���ٶȺͷ���ĳ�ʼ״̬
            //animator.SetFloat("Speed", h * h + v * v);
            //animator.SetFloat("Direction", h,DampTime,Time.deltaTime);
        }
    }
}
