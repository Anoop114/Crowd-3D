using UnityEngine;
using System.Collections;
public class ActiveDeactivePlane : MonoBehaviour
{
    public GameObject plane;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Hammer")
        {
            plane.SetActive(true);
            StartCoroutine(DeactivatePlane());
        }
    }
    private IEnumerator DeactivatePlane()
    {
        yield return new WaitForSeconds(1f);
        plane.SetActive(false);
    }
}
