using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject Settings;
    public Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Back);
    }

    // Update is called once per frame
    void Back()
    {
        Settings.SetActive(false);
        if (Car.dead) return;
        Time.timeScale = 1;
    }
}
