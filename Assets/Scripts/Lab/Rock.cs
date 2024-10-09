using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public void Start()
    {
        damage = 40;
        Move();
    }

    private Rigidbody2D rb2D;
    private Vector2 force;

    public override void Move()
    {
        Debug.Log("Rock เคลื่อนที่ด้วย RigidBody: force");
    }
    public override void OnHitWith(Character idk)
    {

    }
}
