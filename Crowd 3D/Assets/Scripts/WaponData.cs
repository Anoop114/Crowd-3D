using UnityEngine;
using System;
using System.Collections;
public class WaponData : MonoBehaviour
{
    [SerializeField]private GameObject weaponHider;
    [SerializeField]private WeaponHider hider;
    public string weaponName="";

    public void SetData(string name)
    {
        weaponName = name;
    }
    public void CheckForHide()
    {
        StartCoroutine(Hide(hider.weaponCount));
          
    }
    private IEnumerator Hide(int hideCount)
    {
        yield return new WaitForSeconds(0.1f);
        if(hider.weaponCount == 0)
        {
            weaponHider.SetActive(false);
        }
    }

}
