using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : Unit
{
    public override void Init(string name, int maxHealth, float speed)
    {
        Debug.Log("WARNING!");
        base.Init(name, maxHealth, speed);
        Debug.Log("BOSS HAS BEEN SPAWNED");
    }
}
