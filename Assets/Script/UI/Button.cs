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
        Debug.Log("Start Button 클릭");
        LoadMainScene();

    }

    public void OnclickEndButton()
    {
        Debug.Log("End Button 클릭");

    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("01_Test_All");
    }
}
