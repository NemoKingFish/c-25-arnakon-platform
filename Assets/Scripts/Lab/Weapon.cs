using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    protected IShootAble shooter;
    //abstract methods
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootAble _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }

    public int GetShootDirection() //to be modify
    {
        float shootDir = shooter.BulletSpawnPoint.transform.position.x - shooter.BulletSpawnPoint.transform.position.x;
        if (shootDir < 0)
            return -1; //หันซ้าย
        else
            return 1; //หันขวา
    }

    private void OnTriggerEnter2D(Collider2D other) //add later
    {
        OnHitWith(other.GetComponent<Character>() );
        Destroy( this.gameObject, 5f );
    }

}
