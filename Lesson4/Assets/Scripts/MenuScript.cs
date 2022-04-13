using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Canvas exitMenuCanvas;
    public Button playButton;
    public Button optionsButton;
    public Button exitButton;

    private void Start()
    {
        exitMenuCanvas.enabled = false;
    }

    public void onExitButtonClicked()
    {
        exitMenuCanvas.enabled = true;
        playButton.enabled = false;
        optionsButton.enabled = false;
        exitButton.enabled = false;
    }

    public void onNoExitConfirmButtonClicked()
    {
        exitMenuCanvas.enabled = false;
        playButton.enabled = true;
        optionsButton.enabled = true;
        exitButton.enabled = true;
    }

    public void onYesExitConfirmButtonClicked()
    {
        if (UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }

    public void onPlayButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
