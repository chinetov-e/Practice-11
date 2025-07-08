using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void SelectLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SelectLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void SelectLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void SelectLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void SelectLevel5()
    {
        SceneManager.LoadScene("Level5");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
