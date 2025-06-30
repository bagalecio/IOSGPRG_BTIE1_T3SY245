using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    private void Start()
    {
        _health = GetComponent<Health>();
        _health.Init(3);

        GameManager.Instance.RegisterPlayer(this);
    }

    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("Player Shooting");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
}
