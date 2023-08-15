using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public GameObject UILink;
    
    private void OnTriggerEnter(Collider other)
    {
        UILink.GetComponent<UI>().triggerOneOn();

    }

    private void OnTriggerExit(Collider other)
    {
        UILink.GetComponent<UI>().triggerOneOff();
    }
}
