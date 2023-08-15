using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    public TextMeshProUGUI textTime;

    // Start is called before the first frame update
    public void triggerOneOn()
    {

        textTime.text = "Use 'wasd' to move you character. Use the mouse to look around";

    }

    public void triggerOneOff()
    {

        textTime.text = null;

    }

    public void triggerTwoOn()
    {

        textTime.text = "Press the Spacebar to Jump";

    }

    public void triggerTwoOff()
    {

        textTime.text = null;

    }

    public void triggerThreeOn()
    {

        textTime.text = "Press Shift while in the air to boost";

    }
    public void triggerThreeOff()
    {

        textTime.text = null;

    }
}
