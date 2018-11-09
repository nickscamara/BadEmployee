using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfEnter : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BeltMovement.move = false;
        BeltMovement.destroy = true;
        Destroy(collision.gameObject);
    }
}
