using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    [HideInInspector]
    public MenuType Menu
    { 
        get => _menuType;
    }

    [SerializeField] private MenuType _menuType;

    private void Start()
    {
        MenuManager.Instance.RegisterCanvas(this);
    }

    public void Hide()
    {
        if (gameObject.activeSelf)
        { 
            gameObject.SetActive(false);
        }
    }

    public void Show()
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
    }
}
