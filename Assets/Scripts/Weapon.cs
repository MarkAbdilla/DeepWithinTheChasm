using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float weaponDamage = 10f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(fpCamera.transform.position, fpCamera.transform.forward, out hit, range);
        if (hasHit)
        {
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            target.TakeDamage(weaponDamage);
        }
    }
}
