using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Unit : MonoBehaviour
{
    private string _name;
    private float _speed;
    protected Health _health;

    [SerializeField] private Gun _currentGun;

    private void Start()
    {
        _health = GetComponent<Health>();
    }

    public virtual void Init(string name, int maxHealth, float speed)
    {
        _health = GetComponent<Health>();

        _name = name;
        _speed = speed;
        _health.Init(maxHealth);

        Debug.Log($"{name} initialized");
    }

    public virtual void Shoot()
    {
        Debug.Log("base UNIT shooting");
        _currentGun.Shoot();
    }

    public void Movement()
    { 
    }
}
