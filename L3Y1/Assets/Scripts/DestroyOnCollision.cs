using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
 private void OnCollisionEnter(Collision Collision)
 {
    if (Collision.collider.CompareTag("Objective"))
    {
        Destroy(Collision.gameObject);
    }
 }
}
