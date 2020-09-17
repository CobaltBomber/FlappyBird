using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("coin"))
        {
            AudioSource.PlayClipAtPoint(coinSound, other.transform.position);
            Destroy(other.gameObject);
            GameControl.instance.BirdScored();
        }
    }


}
