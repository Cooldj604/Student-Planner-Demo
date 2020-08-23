using UnityEngine.SceneManagement;
using UnityEngine;

public class backButton : MonoBehaviour
{

    public void subtract()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        Debug.Log("what");
    }


}
