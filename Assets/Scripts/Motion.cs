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
         * 设置层数优先级
         * 层数越低，越优先显示
         * 动画遮罩
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
            //存储animator中的动画状态
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

            //动作过渡
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

            //移动
            float h = Input.GetAxis("Horizontal");     
            float v = Input.GetAxis("Vertical");

            //设置动画状态机速度和方向的初始状态
            //animator.SetFloat("Speed", h * h + v * v);
            //animator.SetFloat("Direction", h,DampTime,Time.deltaTime);
        }
    }
}
