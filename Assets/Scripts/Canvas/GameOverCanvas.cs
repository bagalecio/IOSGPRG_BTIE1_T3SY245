using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCanvas : MenuCanvas
{
    public void GoToMainMenu()
    {
        MenuManager.Instance.ShowMenu(MenuType.MainMenu);
    }
}
