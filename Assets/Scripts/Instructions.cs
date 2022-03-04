using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public GameObject BackButtonObj;
    public Button BackButton;
    public GameObject InstructionsObj;

    public float timePassed = 0;
    void Start()
    {
        InstructionsObj.gameObject.SetActive(false);
        BackButton = BackButtonObj.GetComponent<Button>();
        BackButton.onClick.AddListener(Back);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("IsInstructed") != 1 && timePassed > 0.5f)
        {
            InstructionsObj.SetActive(true);
            Time.timeScale = 0;
        }

        timePassed++;
    }

    void Back()
    {
        InstructionsObj.SetActive(false);
        PlayerPrefs.SetInt("IsInstructed", 1);
        Time.timeScale = 1;
    }

}
