using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float speed;
    public void Start()
    {
        damage = 10;
        speed = 4f * GetShootDirection();
        Move();
    }
    public override void Move()
    {
        //s = speed * time
        float newX = transform.position.x + speed * Time.deltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        Debug.Log("Banana เคลื่อนที่ด้วย Tranform ด้วยความเร็วคงที่");
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }

    }
}
