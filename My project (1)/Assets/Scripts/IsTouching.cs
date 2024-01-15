using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This file describes the logic of switching on and off the 
light sources in the palm drawing (upper left corner), 
defined in the lightSwitch file

A lot of Boolean variables can be replaced
by one in theory, but it worked weird that way. 
I don't know why

This script is attached to all hand triggers 
(see the hierarchy in the project) and requires 
the Projection object to be attached in the inspector
*/

public class IsTouching : MonoBehaviour
{
    public LightSwitch lightSwitch;
    bool tl = false;
    bool tm = false;
    bool tr = false;

    bool ml = false;
    bool c = false;
    bool mr = false;

    bool ll = false;
    bool lm = false;
    bool lr = false;
    
    bool ti = false;
    bool mi = false;
    bool li = false;

    bool um = false;
    bool mm = false;
    bool Lm = false;

    bool rt = false;
    bool rm = false;
    bool rl = false;

    bool tp = false;
    bool mp = false;
    bool lp = false;

    bool tt = false;
    bool lt = false;
    

    //if objects interact with hand - switch on the light
    //every light source is connected to special trigger on the hand
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("objects"))
        {
            Debug.Log(gameObject.name + " touched the object " + other.name);
            switch (gameObject.name)
            {
                //palm
                case "topLeft":
                    lightSwitch.topLeft.enabled = !tl;
                    break;
                case "topMid":
                    lightSwitch.topMid.enabled = !tm;
                    break;
                case "topRight":
                    lightSwitch.topRight.enabled = !tr;
                    break;

                case "midLeft":
                    lightSwitch.midLeft.enabled = !ml;
                    break;
                case "center":
                    lightSwitch.center.enabled = !c;
                    break;
                case "midRight":
                    lightSwitch.midRight.enabled = !mr;
                    break;

                case "lowLeft":
                    lightSwitch.lowLeft.enabled = !ll;
                    break;
                case "lowMid":
                    lightSwitch.lowMid.enabled = !lm;
                    break;
                case "lowRight":
                    lightSwitch.lowRight.enabled = !lr;
                    break;

                //pinky
                case "Bone.004":
                    lightSwitch.topPinky.enabled = !tp;
                    break;
                case "Bone.003":
                    lightSwitch.midPinky.enabled = !mp;
                    break;
                case "Bone.002":
                    lightSwitch.lowPinky.enabled = !lp;
                    break;

                //ring
                case "Bone.008":
                    lightSwitch.topRing.enabled = !rt;
                    break;
                case "Bone.007":
                    lightSwitch.midRing.enabled = !rm;
                    break;
                case "Bone.006":
                    lightSwitch.lowRing.enabled = !rl;
                    break;

                //mid
                case "Bone.012":
                    lightSwitch.topMiddle.enabled = !um;
                    break;
                case "Bone.011":
                    lightSwitch.midMiddle.enabled = !mm;
                    break;
                case "Bone.010":
                    lightSwitch.lowMiddle.enabled = !Lm;
                    break;

                //index
                case "Bone.016":
                    lightSwitch.topIndex.enabled = !ti;
                    break;
                case "Bone.015":
                    lightSwitch.midIndex.enabled = !mi;
                    break;
                case "Bone.014":
                    lightSwitch.lowIndex.enabled = !li;
                    break;

                //thumb
                case "Bone.019":
                    lightSwitch.topThumb.enabled = !tt;
                    break;
                case "Bone.018":
                    lightSwitch.lowThumb.enabled = !lt;
                    break;

                default:
                    lightSwitch.AllOffline();
                    break;
            }
        }
    }


    //if not, there are no lights
    public void OnTriggerExit(Collider other)
    {
        lightSwitch.AllOffline();
    }
}
