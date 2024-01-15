using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// idk if we still use this script

public class stopAnim : MonoBehaviour
{
    Animator m_animator;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(Input.GetButton("indexKey"))
        {
            m_animator.enabled = false;
        }
        
    }
    
}
