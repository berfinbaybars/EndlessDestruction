using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Button button;
    public bool sound;
    public Text text;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(ToggleSound);
        SetSound();
        SetButton();
}

    void ToggleSound()
    {
        SetSound();
        sound = !sound;
        if (sound)
        {
            PlayerPrefs.SetInt("Sound", 1);
            SetButton();
        }
        else
        {
            PlayerPrefs.SetInt("Sound", 0);
            SetButton();
        }
    }

    void SetSound()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            sound = true;
        }
        else
        {
            sound = false;
        }
    }

    void SetButton()
    {
        if (sound)
        {
            text.text = "ON";
            button.GetComponent<Image>().color = new Color(0f, 255f, 0f);
        }
        else
        {
            text.text = "OFF";
            button.GetComponent<Image>().color = new Color(255f, 0f, 0f);
        }
    }
}
