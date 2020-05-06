using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object at random time-intervals.
 */
public class TimedSpawner : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] hitPointsField hitPointsField;
    private bool flag = true;


    private void Update()
    {

        if (hitPointsField.getNumber() == 0 && flag)
        {
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            flag = false;
        }
    }
}
