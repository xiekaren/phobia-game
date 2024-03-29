﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Test: Non flying enemies should not move if they can't reach the player.<para/>
/// Author:      <para/>
/// Notes: Attach to the enemy.
/// </summary>
public class NonFlyingEnemyTest : MonoBehaviour
{

    private Vector3 start;
    private Vector3 currentPos;

    private float nextTime;
    private float maxTime;

    private bool pass;

    void Start()
    {
        start = transform.position;
        maxTime = Time.time + 5;
        pass = false;
        Debug.Log(maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime && Time.time < maxTime)
        {
            currentPos = transform.position;
            if (currentPos != start)
            {
                IntegrationTest.Fail();
            }
            else
            {
                pass = true;
                nextTime++;
            }
        }
        if (Time.time > maxTime && pass)
        {
            IntegrationTest.Pass();
        }
    }
}
