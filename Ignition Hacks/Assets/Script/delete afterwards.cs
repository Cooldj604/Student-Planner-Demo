using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deleteafterwards : MonoBehaviour
{
    public InputField iField;
    string myName;

    void MyFunction()
    {
        Debug.Log(iField.text);
        myName = iField.text;

        if (myName == "MattCarter")
        {
            Debug.Log("Correct! The word  cityi iOk");
        }
        else
        {
            Debug.Log("IncorrectThe answer was 'citOk");
        }
    }
}
