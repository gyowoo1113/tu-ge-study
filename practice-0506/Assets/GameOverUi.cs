using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUi : MonoBehaviour
{
    public void SetGameOVer()
    {
        EventManager.Instance.Emit("game_over");
    }
}
