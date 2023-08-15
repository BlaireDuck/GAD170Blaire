using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {

        Debug.Log("you can press e");

        if (Input.GetKeyDown("e"))
        {

            Debug.Log("you pressed e");

        }


    }






}
