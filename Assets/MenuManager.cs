using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public enum MenuType
{ 
    MainMenu,
    GameOver,
    Game,
    CharacterSelection,
}

public class MenuManager : Singleton<MenuManager>
{
    private List<MenuCanvas> _menus = new List<MenuCanvas>();

    private void Start()
    {
        //ShowMenu(MenuType.MainMenu);
    }

    public MenuCanvas GetCanvas(MenuType menu) 
    {
        foreach (MenuCanvas canvas in _menus)
        {
            if (canvas.Menu == menu)
            {
                return canvas;
            }
        }

        return null;
    }

    public void HideAll()
    {
        foreach (MenuCanvas canvas in _menus)
        {
            canvas.Hide();
        }
    }

    public void ShowMenu(MenuType menu)
    {
        HideAll();
        foreach (MenuCanvas canvas in _menus)
        {
            if (canvas.Menu == menu)
            {
                canvas.Show();
                break;
            }
        }
    }

    public void RegisterCanvas(MenuCanvas menu)
    { 
        _menus.Add(menu);
        menu.Hide();
    }
}
