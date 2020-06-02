using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBullet : MonoBehaviour
{
    public GameObject bulletFactory;        //총알 프리팹
    public GameObject firePoint;            //총알 발사위치

    bool isStart = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isStart)
        {
            StartCoroutine("Fire");
        }

    }

    IEnumerator Fire()
    {
        isStart = false;
        GameObject bullet = Instantiate(bulletFactory);
        bullet.transform.position = firePoint.transform.position;

        yield return new WaitForSeconds(0.2f);
        isStart = true;
    }

 
}
