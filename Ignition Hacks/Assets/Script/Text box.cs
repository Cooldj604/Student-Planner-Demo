using UnityEngine.UI;
using UnityEngine;

public class Textbox : MonoBehaviour
{


    public InputField eventBox;
    public InputField timeBox;

    public string eventText;
    public string timeText;

    void typing()
    {
        Debug.Log(eventBox.text);
    }







}
