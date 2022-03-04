using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public Button button;
    public GameObject Settings;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Pause);
        Settings.SetActive(false);
    }

    void Pause()
    {
        Time.timeScale = 0;
        Settings.SetActive(true);
    }
}
