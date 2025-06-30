using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private MenuType _menu;

    public void onPress()
    {
        MenuManager.Instance.ShowMenu(_menu);
    }
}
