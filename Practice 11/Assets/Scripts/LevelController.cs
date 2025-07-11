using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public void OnClick()
    {
        GameObject clickedObject = EventSystem.current.currentSelectedGameObject;
        string buttonText = clickedObject.GetComponentInChildren<Text>().text;
        SceneManager.LoadScene($"Level{buttonText}");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
