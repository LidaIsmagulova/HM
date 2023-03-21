using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
   [SerializeField] private GameObject crushVRX;
   private void OnParticleCollision(GameObject other)
   {
    GameObject boom=Instantiate(crushVRX,transform.position, transform.rotation);
    Destroy(boom,2f);
    Destroy(gameObject);

   }
}
