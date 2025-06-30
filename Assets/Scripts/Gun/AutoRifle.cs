using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRifle : Gun
{
    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("AutoRifle Shoot");
    }
}
