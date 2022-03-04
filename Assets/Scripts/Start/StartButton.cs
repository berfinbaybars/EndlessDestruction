using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
