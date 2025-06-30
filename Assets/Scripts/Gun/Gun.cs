using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GunType
{ 
    Pistol,
    Shotgun,
    AutomaticRifle
}

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _bulletPrefab;

    [Header("Options")]
    [SerializeField] private float _fireRate;
    [SerializeField] private int _currentAmmo;
    [SerializeField] private int _maxClip;
    [SerializeField] private int _damage;
    [SerializeField] private GunType _type;
    [SerializeField] private float _reloadTime;

    public virtual void Shoot()
    {
        Debug.Log("Base GUN Shoot");
    }
}
