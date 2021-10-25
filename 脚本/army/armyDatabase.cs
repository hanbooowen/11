using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class armyDatabase : MonoBehaviour
{
    public static armyDatabase instance;
    public List<Army> armylist = new List<Army>();

    public Dictionary<ArmyType, int> aggressivitylookup;
    public Dictionary<ArmyType, int> defensivitylookup;
    public Dictionary<ArmyType, int> speedlookup;
    public Dictionary<ArmyType, int> movelookup;
    public Dictionary<ArmyType, Sprite> spritelookup;
    public Dictionary<ArmyType, GameObject> armylookup;
    public Dictionary<ArmyType, int> moneylookup;
    public Dictionary<ArmyType, int> crystallookup;
    public Dictionary<ArmyType, int> diamondlookup;
    public Dictionary<ArmyType, int> sulfurlookup;

    private void Awake()
    {
        instance = this;

        aggressivitylookup = new Dictionary<ArmyType, int>();
        for (int i = 0;i < armylist.Count; i++)
        {
            aggressivitylookup.Add(armylist[i].armytype, armylist[i].aggressivity);
        }
        defensivitylookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            defensivitylookup.Add(armylist[i].armytype, armylist[i].defensivity);
        }
        speedlookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            speedlookup.Add(armylist[i].armytype, armylist[i].speed);
        }
        movelookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            movelookup.Add(armylist[i].armytype, armylist[i].move);
        }
        spritelookup = new Dictionary<ArmyType, Sprite>();
        for (int i = 0; i < armylist.Count; i++)
        {
            spritelookup.Add(armylist[i].armytype, armylist[i].sprite);
        }
        armylookup = new Dictionary<ArmyType, GameObject>();
        for (int i = 0; i < armylist.Count; i++)
        {
            armylookup.Add(armylist[i].armytype, armylist[i].armyobj);
        }
        moneylookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            moneylookup.Add(armylist[i].armytype, armylist[i].money);
        }
        crystallookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            crystallookup.Add(armylist[i].armytype, armylist[i].crystal);
        }
        diamondlookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            diamondlookup.Add(armylist[i].armytype, armylist[i].diamond);
        }
        sulfurlookup = new Dictionary<ArmyType, int>();
        for (int i = 0; i < armylist.Count; i++)
        {
            sulfurlookup.Add(armylist[i].armytype, armylist[i].sulfur);
        }
    }
    // Start is called before the first frame update
}

[Serializable]
public class Army
{
    public ArmyType armytype; 
    public int aggressivity;
    public int defensivity;
    public int blood;
    public int speed;
    public int move;
    public int money;
    public int diamond;
    public int sulfur;
    public int crystal;
    public Sprite sprite;
    public GameObject armyobj;
}

public enum ArmyType
{
    Å©Ãñ,Ç¹±ø,Æï±ø,
    ¹­¼ýÊÖ,Éñ¼ýÊÖ,
    Ê¥ÆïÊ¿,
    ¸ç²¼ÁÖ,Ò°Öí,ÀÇ,Å£Í·ÈË,
    Ê¨ðÕ,
    ¾ÅÍ·Éß,
    ÷¼÷Ã±ø,ÎüÑª¹í,
    ÂÌÁú,ºìÁú,ºÚÁú,
    Ì©Ì¹¾ÞÈË,
}