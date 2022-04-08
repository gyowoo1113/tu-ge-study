using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginUI : MonoBehaviour
{
    public TMP_InputField idField;
    public TMP_InputField pwField;
    public Button loginButton;
    
    public GameObject loginPanel;
    public TMP_Text panelText;

    private void Start()
    {
        loginButton.onClick.AddListener(OnLoginButtonClicks);
    }

    public void OnLoginButtonClicks()
    {
        if (idField.text == "admin" && pwField.text == "1q2w3e4r")
        {
            loginPanel.SetActive(true);
            panelText.text = "Login Success";
        }
        else
        {
            loginPanel.SetActive(true);
            panelText.text = "Login Fail";
        }
    }
}
