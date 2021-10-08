using UnityEngine;

public class WeaponLoader : MonoBehaviour
{
    public Transform Pole;
    public GameObject CurrentWeaponData;
    public GameObject weaponLoaderButton;
    public GameObject EnemySpawner;
    private WaponData data;
    private FollowThePath enemyPath;
    public GameObject[] weapons;
    public GameObject[] enemys;

    public void WeaponLoad()
    {
        Vector3 pos = Pole.position;
        data = CurrentWeaponData.GetComponent<WaponData>();
        if(data.weaponName != null)
        {
            foreach (GameObject w in weapons)
            {
                if(data.weaponName == w.name)
                {
                    Instantiate(w, pos, Quaternion.identity);
                    Debug.Log("true");
                    EnemyMove();
                    EnemySpawner.SetActive(true);
                    Destroy(weaponLoaderButton);
                }else{
                    Debug.Log("false");
                }
            }
        }
        
    }
    public void EnemyMove()
    {
        foreach(GameObject e in enemys)
        {
            enemyPath = e.GetComponent<FollowThePath>();
            enemyPath.moveSpeed = 2f;
        }
    }
}
