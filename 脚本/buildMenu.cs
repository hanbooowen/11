using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class buildMenu : MonoBehaviour
{
    public GameObject btnyes;
    public GameObject btnno;

    public GameObject mentionmenu;

    // Start is called before the first frame update
    void Start()
    {
        btnyes.GetComponent<Button>().onClick.AddListener(Yes);
        btnno.GetComponent<Button>().onClick.AddListener(No);
    }

    // Update is called once per frame
    void Update()
    {
        if (Build.bt == "近战兵营" || Build.bt == "远程兵营" || Build.bt == "市场" || Build.bt == "圣骑士教堂" || Build.bt == "九头蛇金字塔" || Build.bt == "泰坦云间城堡" || Build.bt == "皇家城堡" || Build.bt == "魔法行会")
        {
            GameObject.Find("Canvas/buildmenu/buildtext2").GetComponent<Text>().text = Build.bt;
            GameObject.Find("Canvas/buildmenu/buildtext4").GetComponent<Text>().text = Build.br;
        }
    }

    public void Yes()
    {
        if (Build.usemoney <= resource.money && Build.usewood <= resource.wood && Build.usestone <= resource.stone && Build.usesulfur <= resource.sulfur && Build.usecrystal <= resource.crystal && Build.usediamond <= resource.diamond)
        {
            resource.money -= Build.usemoney;
            resource.wood -= Build.usewood;
            resource.stone -= Build.usestone;
            resource.crystal -= Build.usecrystal;
            resource.sulfur -= Build.usesulfur;
            resource.diamond -= Build.usediamond;
            this.gameObject.SetActive(false);
            if (true)
            {
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            mentionmenu.SetActive(true);
            GameObject.Find("Canvas/mentionmenu/Text").GetComponent<Text>().text = "资源不足，无法建造";
        }

    }
    public void No()
    {
        this.gameObject.SetActive(false);
    }

}
