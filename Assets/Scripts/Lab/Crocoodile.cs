using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Crocoodile : Enemy, IShootAble
{
    [SerializeField] private float attackRange;
    public Player player;
    [field : SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint {  get; set; }
    [field: SerializeField] public float BulletSpawnTime {  get; set; }
    [field: SerializeField] public float BulletTimer {  get; set; }

    void FixedUpdate()
    {
        BulletTimer -= Time.deltaTime;

        Behavior();
    }
    public override void Behavior()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (BulletTimer <= 0)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rock = obj.gameObject.GetComponent<Rock>();
            rock.Init(20, this);

            BulletTimer = BulletSpawnTime;
        }
    }
}
