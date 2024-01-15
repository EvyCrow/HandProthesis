using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This file defines the light sources in the
palm picture (top left corner of the screen)
Interaction is defined in the IsTouching file

This script is attached to all light sources 
and requires them to be attached properly in 
the inspector to work correctly (note the names 
of the light sources)
 */

public class LightSwitch : MonoBehaviour
{
    //palm
    //top
    public Light topLeft;
    public Light topMid; 
    public Light topRight;

    //middle
    public Light midLeft;
    public Light center;
    public Light midRight;

    //low
    public Light lowLeft;
    public Light lowMid;
    public Light lowRight;

    //fingers
    //index
    public Light topIndex;
    public Light midIndex;
    public Light lowIndex;

    //middle
    public Light topMiddle;
    public Light midMiddle;
    public Light lowMiddle;

    //ring
    public Light topRing;
    public Light midRing;
    public Light lowRing;

    //pinky
    public Light topPinky;
    public Light midPinky;
    public Light lowPinky;

    //thumb
    public Light topThumb;
    public Light lowThumb;



    void Start()
    {
        AllOffline();
    }
    

    //addictional function that switches all off
    public void AllOffline()
    {
        topLeft.enabled = false;
        topMid.enabled = false;
        topRight.enabled = false;
        midLeft.enabled = false;
        center.enabled = false;
        midRight.enabled = false;
        lowLeft.enabled = false;
        lowMid.enabled = false;
        lowRight.enabled = false;
        topIndex.enabled = false;
        midIndex.enabled = false;
        lowIndex.enabled = false;
        topMiddle.enabled = false;
        midMiddle.enabled = false;
        lowMiddle.enabled = false;
        topRing.enabled = false;
        midRing.enabled = false;
        lowRing.enabled = false;
        topPinky.enabled = false;
        midPinky.enabled = false;
        lowPinky.enabled = false;
        topThumb.enabled = false;
        lowThumb.enabled = false;
    }
}
