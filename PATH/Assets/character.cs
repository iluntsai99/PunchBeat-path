﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = wayPoints.points[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }
    void GetNextWayPoint()
    {
        if (wavepointIndex >= wayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
            

        wavepointIndex++;
        target = wayPoints.points[wavepointIndex];
    }
}
