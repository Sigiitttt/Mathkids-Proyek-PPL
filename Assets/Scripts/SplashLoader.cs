using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    void Start()
    {
        Invoke("GoToHome", 2f);
    }

    void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
