// Jenni
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour {

    // Script for button to exit current microgame and return to main game menu
    public void ToMainMenu() {
        EventManager.Instance.BroadcastAppExit();
        SceneManager.LoadScene("SwipeMenu", LoadSceneMode.Single);
    }
}