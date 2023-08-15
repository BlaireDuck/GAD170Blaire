using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{

    public GameObject UILink;

    private void OnTriggerEnter(Collider other)
    {
        UILink.GetComponent<UI>().triggerTwoOn();

    }

    private void OnTriggerExit(Collider other)
    {
        UILink.GetComponent<UI>().triggerTwoOff();
    }






}
   
    
