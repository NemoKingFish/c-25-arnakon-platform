using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public interface IShootAble
{
    GameObject Bullet { get; set; }
    Transform BulletSpawnPoint { get; set; }
    float BulletSpawnTime { get; set; }
    float BulletTimer { get; set; }
    
    void Shoot();

}
