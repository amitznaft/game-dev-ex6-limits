using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] hitPointsField hitPointsField;
    [SerializeField] GameObject effect;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.tag == "Player" && other.tag == "Life")
        {
            hitPointsField.SetNumber(hitPointsField.getNumber() + 1);
            Destroy(other.gameObject);
        }
        else if (other.tag == "Enemy" && enabled)
        {
            if (hitPointsField.getNumber() > 0)
            {
                hitPointsField.SetNumber(hitPointsField.getNumber() - 1);
            }
            else
            {
                GameObject newexplosion = (GameObject)Instantiate(effect, this.gameObject.transform.position, this.gameObject.transform.rotation);
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                Destroy(newexplosion, 3);

            }
        }
        else if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }


    }
}
