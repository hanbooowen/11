using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armyProduce : MonoBehaviour
{
    public army thisarmy;
    public inventory castleinventory;

    public void AddNewArmy()
    {
        if(!castleinventory.armylist.Contains(thisarmy))
        {
            castleinventory.armylist.Add(thisarmy);
        }
        else
        {
            thisarmy.armynum += 1;
        }
        inventoryManager.AddArmy();
    }
}
