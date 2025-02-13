using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
 private void OnTriggerEnter(Collider Collision)
 {
    if (Collision.GetComponent<Collider>().CompareTag("Player"))
    {
        Destroy(gameObject);
    }
 }
}
