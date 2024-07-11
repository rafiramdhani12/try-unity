using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public int damage = 150;
    public float range = 300.875f;
    public string weaponName = "operator";
    public string [] contohList;

    // Start is called before the first frame update
    void Start()
    {
        if (weaponName == "operator"){
            Debug.Log("senjata kamu adalah operator");
        } else {
            Debug.Log("senjatamu bukan operator");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // jika mouse kiri di click maka akan menjalankan shooting (0) = kiri (1) = kanan
       if(Input.GetMouseButtonDown(0))
       {
        Shooting();
       }
       else if (Input.GetMouseButtonDown(1)){
        Scooping();
       }
       else if (Input.GetKeyDown(KeyCode.R))
       {
        Reload();
       }
      
    }

    void Shooting()
    {
        Debug.Log("create bullet");
        Debug.Log("add force to bullet");
        Debug.Log("spawn muzzle flash");
    }
    void Reload()
    {
        Debug.Log("kurangi magazine");
        Debug.Log("isi ulang peluru menjadi maximal");
    
    }
    void Scooping()
    {
        Debug.Log("zoom in jika mouse scroll keatas ");
        Debug.Log("zoom out jika mouse scroll ke bawah");
    }
}
