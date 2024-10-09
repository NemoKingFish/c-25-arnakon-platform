using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float speed;
    public void Start()
    {
        damage = 30;
        speed = 4;
        Move();
    }
    public override void Move()
    {
        Debug.Log("Banana เคลื่อนที่ด้วย Tranform ด้วยความเร็วคงที่");
    }
    public override void OnHitWith(Character idk)
    {

    }
}
