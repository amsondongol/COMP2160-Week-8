using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerMovement p))
        {
            Scorekeeper.instance.Pickup(p.PlayerType);
            Destroy(gameObject);
        }
    }
}
