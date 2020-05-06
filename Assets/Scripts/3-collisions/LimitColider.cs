using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitColider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject effect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject newexplosion = (GameObject)Instantiate(effect, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);
            Destroy(newexplosion, 3);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
