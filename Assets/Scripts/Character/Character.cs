﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Character
{
    public Sprite Image;
    public string name;
    public int health;
    public int health_per_lv;
    public int attack;
    public int attack_per_lv;

    public int Exp;
    public int MaxExp;
    public static int LvlExp = 100;
    public static int LvlExpPerLv = 20;
    public int Level;
    public bool Unlocked;
    public int Price;

    public List<Skill> Skills; // Danh sách kỹ năng của nhân vật
    public float GetMaxHealth()
    {
        return (health+(health_per_lv*Level));
    }
    
    public float GetMaxAttack()
    {
        return (attack+(attack_per_lv*Level));
    }
    public int GetExpLevel()
    {
        return (LvlExp+LvlExpPerLv*Level);
    }
}
