using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This file describes the animations of bending 
fingers, as well as bending them all into a fist
with a single button

More information in Animator, where the animations 
are laid out in layers

You can find addictional keys in project manager
(Input manager)

Logic of grabbing an object in the PickUp file
*/


public class fingerControl : MonoBehaviour
{
    public GameObject myhand;

    Animator m_animator;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        m_animator.SetBool("IsThungActive", false);
        m_animator.SetBool("IsIndexActive", false);
        m_animator.SetBool("IsMiddleActive", false);
        m_animator.SetBool("IsRingActive", false);
        m_animator.SetBool("IsPinkyActive", false);

        if (Input.GetButton("indexKey"))
        {
            m_animator.Play("Armature|index");
            m_animator.SetBool("IsIndexActive", true);
            
        } 
        if(Input.GetButton("middleKey"))
        {
            m_animator.Play("Armature|middle");
            m_animator.SetBool("IsMiddleActive", true);
        }
        if(Input.GetButton("ringKey"))
        {
            m_animator.Play("Armature|ring");
            m_animator.SetBool("IsRingActive", true);
        } 
        if(Input.GetButton("pinkyKey"))
        {
            m_animator.Play("Armature|pinky");
            m_animator.SetBool("IsPinkyActive", true);
        }
        if(Input.GetButton("thumbKey"))
        {
            m_animator.Play("Armature|thung");
            m_animator.SetBool("IsThungActive", true);
        }

        if (Input.GetButton("fistKey"))
        {
            m_animator.Play("Armature|thung");
            m_animator.SetBool("IsThungActive", true);
            m_animator.Play("Armature|pinky");
            m_animator.SetBool("IsPinkyActive", true);
            m_animator.Play("Armature|ring");
            m_animator.SetBool("IsRingActive", true);
            m_animator.Play("Armature|middle");
            m_animator.SetBool("IsMiddleActive", true);
            m_animator.Play("Armature|index");
            m_animator.SetBool("IsIndexActive", true);
        }

    }
}

