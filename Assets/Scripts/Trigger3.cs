using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public GameObject UILink;

    private void OnTriggerEnter(Collider other)
    {
        UILink.GetComponent<UI>().triggerThreeOn();

    }

    private void OnTriggerExit(Collider other)
    {
        UILink.GetComponent<UI>().triggerThreeOff();
    }
}
