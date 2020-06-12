using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    public GameObject explosion;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        ShowEffeft();
    }

    private void ShowEffeft()
    {
        GameObject fx = Instantiate(explosion);
        fx.transform.position = transform.position;
        Destroy(fx, 1.0f);
    }
}
