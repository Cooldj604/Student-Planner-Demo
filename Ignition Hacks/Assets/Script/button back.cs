using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonback: MonoBehaviour
{

    public void subtract()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
