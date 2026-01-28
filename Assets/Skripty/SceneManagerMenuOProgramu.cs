using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderOProgramu : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
