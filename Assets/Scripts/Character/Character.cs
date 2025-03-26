using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class Character : MonoBehaviour
{
    private string name { get; set; }
    private int level { get; set; }
    private int attack { get; set; }
    private int defense { get; set; }
    private int health { get; set; }
    private int critical { get; set; }
    private int gold { get; set; }
    
    public string Name { get { return name; } set { name = value; } }
    public int Level { get { return level; } set { level = value; } }
    public int Attack { get { return attack; } set { attack = value; } }
    public int Defense { get { return defense; } set { defense = value; } }
    public int Health { get { return health; } set { health = value; } }
    public int Critical { get { return critical; } set { critical = value; } }
    public int Gold { get { return gold; } set { gold = value; } }
    
    public ItemData itemData;
    public Action addItem;
    public Equipment equipment;

    private void Start()
    {
        //test 용 플레이어 정보
        name = "chad";
        level = 1;
        attack = 30;
        defense = 100;
        health = 100;
        critical = 100;
        gold = 100;
    }
}
