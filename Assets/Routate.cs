using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Routate : MonoBehaviour
{
    bool getFlag = false;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (getFlag)
        {
            Text cubeAngle = GameObject.Find("InputAngle/angle").GetComponent<Text>();
            Text cubeRoute = GameObject.Find("InputRout/routate").GetComponent<Text>();
            float rout = float.Parse(cubeRoute.text);
            Rout(cubeAngle.text, rout);
        }

    }

    public void Flag()
    {
        getFlag = true;
    }

    public void Rout(string angle,float rout)
    {
        /*
        if (angle == "x")
        {
            float nowRoutY = cube.localEulerAngles.y;
            float nowRoutZ = cube.localEulerAngles.z;
            var target = Quaternion.Euler(new Vector3(rout, nowRoutY, nowRoutZ));
            var now_rot = cube.rotation;
            if (Quaternion.Angle(now_rot, target) <= 1)
            {
                cube.rotation = target;
                getFlag = false;
            }
            else
            {
                cube.Rotate(new Vector3(0.5f, 0, 0));
            }
        }
        else if(angle == "y")
        {
            float nowRoutX = cube.localEulerAngles.x;
            float nowRoutZ = cube.localEulerAngles.z;
            var target = Quaternion.Euler(new Vector3(nowRoutX, rout, nowRoutZ));
            var now_rot = cube.rotation;
            if (Quaternion.Angle(now_rot, target) <= 1)
            {
                
                cube.rotation = target;
                getFlag = false;
            }
            else
            {
                cube.Rotate(new Vector3(0, 0.5f, 0));
            }
        }
        else if (angle == "z")
        {
            float nowRoutX = cube.localEulerAngles.x;
            float nowRoutY = cube.localEulerAngles.y;
            var target = Quaternion.Euler(new Vector3(nowRoutX, nowRoutY, rout));
            var now_rot = cube.rotation;
            if (Quaternion.Angle(now_rot, target) <= 1)
            {
                cube.rotation = target;
                getFlag = false;
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, 0.5f));
            }
        }
        */
        iTween.RotateTo(cube, iTween.Hash(angle, rout, "time", 4.0f));
        getFlag = false;

    }

}
