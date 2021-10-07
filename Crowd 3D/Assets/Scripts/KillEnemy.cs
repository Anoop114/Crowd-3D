using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
