using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ActionSchemeDisplayText : MonoBehaviour
{
    public PlayerInput playerInput;
    private TMP_Text _text;

    private void Awake() 
    {
        _text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        _text.text = playerInput.currentControlScheme;
    }
}
