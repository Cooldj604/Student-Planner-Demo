using UnityEngine.SceneManagement;
using UnityEngine;


public class Backtostart : MonoBehaviour
{
    public void toStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
        Debug.Log("back");
    }


}
