using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textBox : MonoBehaviour
{

    public GameObject eventInput;
    public static string eventString;
    public static GameObject eventDisplay;



    public void eventFunction()
    {
        eventString = eventInput.GetComponent<Text>().text;
        eventDisplay.GetComponent<Text>().text = eventString;

    }

}
