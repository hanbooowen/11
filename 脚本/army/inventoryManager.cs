using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{
    static inventoryManager instance;

    public inventory castlearmy;
    public GameObject slotgrid;
    public slot slotprefab;

    void Awake()
    {
        if(instance!=null)
        {
            Destroy(this);
        }
        instance = this;
    }

    public static void CreateNewArmy(army army)
    {
        slot newArmy = Instantiate(instance.slotprefab, instance.slotgrid.transform.position, Quaternion.identity);
        newArmy.gameObject.transform.SetParent(instance.slotgrid.transform);
        newArmy.slotarmy = army;
        newArmy.slotimage.sprite = army.armysprite;
        newArmy.slotnum.text = army.armynum.ToString();
    }

    public static void AddArmy()
    {
        for(int i=0;i<instance.slotgrid.transform.childCount;i++)
        {
            if(instance.slotgrid.transform.childCount==0)
            {
                break;
            }
            Destroy(instance.slotgrid.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < instance.castlearmy.armylist.Count; i++)
        {
            CreateNewArmy(instance.castlearmy.armylist[i]);
        }
    }
}
