using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(RestartGame);
    }

    void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
