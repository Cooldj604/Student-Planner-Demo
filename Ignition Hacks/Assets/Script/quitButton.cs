using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitButton : MonoBehaviour
{

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");

    }


}
