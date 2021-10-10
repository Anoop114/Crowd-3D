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
    public WeaponHider hider;
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
        if(hider.weaponCount == 0)
        {
            foreach(GameObject e in enemys)
            {
                enemyPath = e.GetComponent<FollowThePath>();
                enemyPath.moveSpeed = 2f;
            }
        }
        
    }
}
