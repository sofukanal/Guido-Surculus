using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerWeapon
{
    // Weapon variables
    public string name = "RE48";

    public int damage = 10;
    public float range = 100f;

    public float fireRate = 0f;

    public GameObject graphics;
}
