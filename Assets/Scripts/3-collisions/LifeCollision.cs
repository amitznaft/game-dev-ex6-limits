using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCollision : MonoBehaviour
{
    [SerializeField] hitPointsField hitPointsField;
    [SerializeField] float maxXDistance;
    [SerializeField] float maxYDistance;
    [SerializeField] GameObject prefabToSpawn;
    private bool flag = true;

    private void Update()
    {
        if (hitPointsField.getNumber() == 0 && flag)
        {
            StartCoroutine(getlife());
            flag = false;
        }

    }
    IEnumerator getlife()
    {

        Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
                transform.position.y + Random.Range(-maxXDistance, +maxYDistance),
                transform.position.z);
        GameObject newexplosion = (GameObject)Instantiate(prefabToSpawn.gameObject,
        positionOfSpawnedObject, Quaternion.identity);
        Destroy(newexplosion, 5);
        yield return new WaitForSeconds(5f);
        flag = true;

    }
}


