using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private Animator m_Animator;
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        // print("ini start");
    }


    void Update()
    {
        // print("ini update");
        if (Input.GetKey(KeyCode.Space))
        {
            // print("ini spasi diklik!");
            m_Animator.SetTrigger("goAttack");
        }
    }
}
