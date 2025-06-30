using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public Player Player
    {
        get => _player;
    }

    private Player _player;

    private void Start()
    {
        LoadMainMenu();
    }

    public void StartGame()
    { 
        Spawner.Instance.SpawnStartingEnemies();
        // Initialize Level
    }

    public void GameOver()
    {
        MenuManager.Instance.ShowMenu(MenuType.GameOver);
    }

    public void RegisterPlayer(Player player)
    {
        if (_player == null)
        { 
            _player = player;
        }

        Health playerHealth = _player.GetComponent<Health>();
        if (playerHealth != null)
        {
            playerHealth._onDeath += GameOver;
            GameCanvas gameCanvas = (GameCanvas)MenuManager.Instance.GetCanvas(MenuType.Game);
            playerHealth._onHealthChanged += gameCanvas.UpdateHealthBar;
        }
    }

    private void LoadMainMenu()
    {
        StartCoroutine(CO_LoadSceneAsych(() => {
            MenuManager.Instance.ShowMenu(MenuType.MainMenu);
        }));
    }

    private IEnumerator CO_LoadSceneAsych(Action onCallback)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        asyncOperation.allowSceneActivation = false;

        while (asyncOperation.progress < 0.8)
        {
            yield return null;
        }

        onCallback.Invoke();
        asyncOperation.allowSceneActivation = true;
    }
}
