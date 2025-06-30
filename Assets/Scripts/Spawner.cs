using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Singleton<Spawner>
{
    [SerializeField] private GameObject _meleeEnemy;
    [SerializeField] private GameObject _rangedEnemy;
    [SerializeField] private GameObject _bossEnemy;

    private List<Unit> _enemies = new List<Unit>();

    public void SpawnStartingEnemies()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnEnemy(_meleeEnemy, "Kiko", 100, 5);
            SpawnEnemy(_rangedEnemy, "Elle", 50, 7);
        }
        SpawnEnemy(_bossEnemy, "Josh", 500, 3);
    }

    private void SpawnEnemy(GameObject prefab, string name, int health, float speed)
    {
        GameObject enemyGO = Instantiate(prefab, transform.position + (Vector3.one * Random.Range(-5, 5)), Quaternion.identity);
        Unit newUnit = enemyGO.GetComponent<Unit>();

        newUnit.Init(name, health, speed);
        _enemies.Add(newUnit);
    }
}
