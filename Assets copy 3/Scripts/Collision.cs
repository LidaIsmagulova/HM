using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent (typeof(Rigidbody))]
public class Collision : MonoBehaviour
{
  [SerializeField] private float timeToReloadScene = 2f;
  [SerializeField] private ParticleSystem crushVFX;

    public GameObject sound;

  private void Start()
  {
    GetComponent<Rigidbody>().useGravity=false;
  }

  private void OnTriggerEnter(Collider other)
  {
    StartCrushSequence();
  }
 
  private void StartCrushSequence()
  {
    GetComponent<Player>().enabled=false;
    GetComponent<MeshCollider>().enabled=false;
    GetComponent<MeshRenderer>().enabled=false;
    crushVFX.Play();
    Invoke(nameof(ReloadLevel), timeToReloadScene);
    Instantiate(sound,transform.position,Quaternion.identity);

  }

  private void ReloadLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
