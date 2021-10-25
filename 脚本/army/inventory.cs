using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName ="inventory/New Inventory")]
public class inventory : ScriptableObject
{
    public List<army> armylist = new List<army>();
}
