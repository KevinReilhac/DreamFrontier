using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class TouchRace : MonoBehaviour
{

    public bool isRacePressed = false;
    public bool isbrakePressed = false;

 
    void Update()
    {
        if (isRacePressed)
        {
            //Your code Here
        }

        else if (!isRacePressed)
        {

            //Your Code Here
        }
    }
    public void onPointerDownRaceButton()
    {
        isRacePressed = true;
    }
    public void onPointerUpRaceButton()
    {
        isRacePressed = false;
    }
}

