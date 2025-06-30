using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenuCanvas : MenuCanvas
{
    public void StartGame()
    {
        MenuManager.Instance.ShowMenu(MenuType.CharacterSelection);
    }
}
