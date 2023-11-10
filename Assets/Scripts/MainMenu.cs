using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;
    public GameObject mainWindows;
    public GameObject settingsWindows;
    public GameObject creditsWindows;

    public void StartButton()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void SettingsButton()
    {
        settingsWindows.SetActive(true);
        mainWindows.SetActive(false);
    }

    public void CloseSettingsButton()
    {
        settingsWindows.SetActive(false);
        mainWindows.SetActive(true);
    }
    public void CreditsButton()
    {
        creditsWindows.SetActive(true);
        mainWindows.SetActive(false);
    }

    public void CloseCreditsButton()
    {
        creditsWindows.SetActive(false);
        mainWindows.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
