using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        //OnclickStartButton();
    }


    public void OnclickStartButton()
    {
        Debug.Log("Start Button Ŭ��");
        LoadMainScene();

    }

    public void OnclickEndButton()
    {
        Debug.Log("End Button Ŭ��");

    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("01_Test_All");
    }
}
