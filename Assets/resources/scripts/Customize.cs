using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customize : MonoBehaviour
{
    private void OnGUI()
    {
        CustomiseOnGUI();

    }
    private void CustomiseOnGUI()
    {
        //skin
        if (GUI.Button(new Rect(10, 50, 100, 20), "<"))
        {
            Debug.Log("Left");
        }
        GUI.Label(new Rect(45, 50, 60, 20), "Skin");
        if (GUI.Button(new Rect(10, 50, 100, 20), ">"))
        {
            Debug.Log("right");
        }

        //hair
        if (GUI.Button(new Rect(10, 80, 100, 20), "<"))
        {
            Debug.Log("Left");
        }
        GUI.Label(new Rect(45, 80, 60, 20), "Hair");
        if (GUI.Button(new Rect(10, 80, 100, 20), ">"))
        {
            Debug.Log("right");
        }

        //mouth
        if (GUI.Button(new Rect(10, 110, 100, 20), "<"))
        {
            Debug.Log("Left");
        }
        GUI.Label(new Rect(45, 110, 60, 20), "Mouth");
        if (GUI.Button(new Rect(10, 110, 100, 20), ">"))
        {
            Debug.Log("right");
        }




    }






}
