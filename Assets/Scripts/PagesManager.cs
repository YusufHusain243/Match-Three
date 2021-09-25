using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Update()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (Input.GetKey(KeyCode.Escape))
        {
            if (sceneName == "Menu")
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
