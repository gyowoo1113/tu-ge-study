using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingUi : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public TMP_Dropdown qualityDropdown;

    void Start()
    {
        resolutionDropdown.ClearOptions();
        qualityDropdown.ClearOptions();

        resolutionDropdown.AddOptions(Screen.resolutions.Select(Resolution => $"{res.width} X {res.height}").ToList());

        resolutionDropdown.onValueChanged.AddListener(UserResolutionSelected);
        qualityDropdown.ClearOptions();
        qualityDropdown.AddOptions(
            QualitySettings.names.ToList()
        );
        qualityDropdown.onValueChanged.AddListener(UserQualitySelected);
    }

    private void UserResolutionSelected(int index)
    {
        var resolution = Screen.resolutions[index];
        Screen.SetResolution(resolution.width,resolution.height,true);
    }

    private void UserQualitySelected(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

}
