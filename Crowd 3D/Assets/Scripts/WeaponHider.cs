using UnityEngine;
using UnityEngine.UI;
using System;
public class WeaponHider : MonoBehaviour
{
    public int weaponCount = 1;
    Text txt;
    [SerializeField]private GameObject weaponCou;
    void Start ()
    {
        txt = weaponCou.GetComponent<Text>(); 
        txt.text="Weapon Count : " + weaponCount;
    }
    public void DecreaseWeaponCount()
    {
        weaponCount--;
        txt.text="Weapon Count : " + weaponCount;
    }
}
