using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textBox : MonoBehaviour
{

    public InputField eventInput;
    string eventString;

    public void eventFunction()
    {

        eventString = eventInput.text;
        Debug.Log(eventString);
    }

}
