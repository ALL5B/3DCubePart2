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
            Text InputRoutX = GameObject.Find("InputRoutX/routateX").GetComponent<Text>();
            Text InputRoutY = GameObject.Find("InputRoutY/routateY").GetComponent<Text>();
            Text InputRoutZ = GameObject.Find("InputRoutZ/routateZ").GetComponent<Text>();
            float RoutX = float.Parse(InputRoutX.text);
            float RoutY = float.Parse(InputRoutY.text);
            float RoutZ = float.Parse(InputRoutZ.text);
            Rout(RoutX,RoutY,RoutZ);


        }
        float NowRoutX = cube.transform.rotation.eulerAngles.x;
        float NowRoutY = cube.transform.rotation.eulerAngles.y;
        float NowRoutZ = cube.transform.rotation.eulerAngles.z;
        Text TextX = GameObject.Find("NowRoutX").GetComponent<Text>();
        Text TextY = GameObject.Find("NowRoutY").GetComponent<Text>();
        Text TextZ = GameObject.Find("NowRoutZ").GetComponent<Text>();
        TextX.text = Math.Round(NowRoutX).ToString() + "°";
        TextY.text = Math.Round(NowRoutY).ToString() + "°";
        TextZ.text = Math.Round(NowRoutZ).ToString() + "°";

    }

    public void Flag()
    {
        getFlag = true;
    }

    public void InitialPosition()
    {
        iTween.RotateTo(cube, iTween.Hash("x", 0, "y", 0, "z", 0, "time", 1.0f));
    }

    public void Rout(float RoutX = 0,float RoutY = 0,float RoutZ = 0)
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
        iTween.RotateTo(cube, iTween.Hash("x", RoutX,"y",RoutY,"z",RoutZ, "time", 4.0f));
        getFlag = false;

    }

}
