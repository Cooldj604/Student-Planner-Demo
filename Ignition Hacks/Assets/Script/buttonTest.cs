using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonTest: MonoBehaviour
{

    public void add()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
