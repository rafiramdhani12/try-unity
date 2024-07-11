using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private void Start(){
        StartCoroutine(LifeTime());
    }

    IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

   private void OnCollisionEnter(Collision collision) {
    if (collision.transform.CompareTag("Enemy")){
        collision.gameObject.GetComponent<Light>().enabled = false;
        collision.gameObject.SetActive(false);
    }
   }
}
