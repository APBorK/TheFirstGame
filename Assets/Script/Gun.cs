using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject projectile;
    public float fireDelta = 0.5F;
    public float activeDistance = 0.5F;
    
    private Vector3 _target;
    private float _nextFire = 0.5F;
    private GameObject _newProjectile;
    private float _myTime = 0.0F;
    private bool _isTarget;

    void Update()
    {
        _target = NPCInfo.bot.position;
        float dis = Vector3.Distance (transform.position, NPCInfo.bot.position);
        
        if(dis < activeDistance)
        {
            _isTarget = true;
        }
        
        _myTime += Time.deltaTime;

        if (_isTarget == true && _myTime > _nextFire)
        {
            _nextFire = _myTime + fireDelta;
            _newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            

            _nextFire -= _myTime;
            _myTime = 0.5F;
        }
    }
}
