using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopBackButton : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(GoBack);
    }

    void GoBack()
    {
        ShopObjects.ObjectLevels.Clear();
        SceneManager.LoadScene("Start");
    }
}
