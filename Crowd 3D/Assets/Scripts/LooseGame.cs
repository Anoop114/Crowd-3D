using UnityEngine;

public class LooseGame : MonoBehaviour
{
    public GameObject LooseUi;
    private int count = 3;
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "Enemy")
        {
            if(count==0)
            {
                Time.timeScale = 0;
                LooseUi.SetActive(true);
            }else{
                count--;
                Destroy(other.gameObject);
            }
        }
    }

}
