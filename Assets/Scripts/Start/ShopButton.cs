using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Shop);
    }

    // Update is called once per frame
    void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
}
