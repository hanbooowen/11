using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inCastle : MonoBehaviour
{
    public GameObject btnbuild;
    public GameObject btnlevelup;
    public GameObject btnexit;

    public GameObject levelupmenu;

    public GameObject 农民;
    public GameObject 枪兵;
    public GameObject 骑兵;
    public GameObject 弓箭手;
    public GameObject 神箭手;
    public GameObject 圣骑士;
    public GameObject 哥布林;
    public GameObject 野猪;
    public GameObject 狼;
    public GameObject 牛头人;
    public GameObject 狮鹫;
    public GameObject 九头蛇;
    public GameObject 骷髅兵;
    public GameObject 吸血鬼;
    public GameObject 绿龙;
    public GameObject 红龙;
    public GameObject 黑龙;
    public GameObject 泰坦;

    public GameObject 人市场;
    public GameObject 人魔法行会;
    public GameObject 兽市场;
    public GameObject 兽魔法行会;
    public GameObject 龙市场;
    public GameObject 龙魔法行会;

    public GameObject 皇家城堡;

    public GameObject r;
    public GameObject s;
    public GameObject l;

    public static int type = 1;

    // Start is called before the first frame update
    void Start()
    {
        btnbuild.GetComponent<Button>().onClick.AddListener(ToBuild);
        btnlevelup.GetComponent<Button>().onClick.AddListener(ToLevelup);
        btnexit.GetComponent<Button>().onClick.AddListener(Exit);

        switch(type)
        {
            case 1:
                GameObject.Find("Canvas/castletype").GetComponent<Text>().text = "人族城堡";
                r.SetActive(true);
                break;
            case 2:
                GameObject.Find("Canvas/castletype").GetComponent<Text>().text = "兽族城堡";
                s.SetActive(true);
                break;
            case 3:
                GameObject.Find("Canvas/castletype").GetComponent<Text>().text = "龙族城堡";
                l.SetActive(true);
                break;
        }

        if (type == 1)
        {
            switch (Build.bt)
            {
                case "近战兵营":
                    农民.SetActive(true);
                    枪兵.SetActive(true);
                    骑兵.SetActive(true);
                    break;
                case "远程兵营":
                    弓箭手.SetActive(true);
                    神箭手.SetActive(true);
                    break;
                case "市场":
                    人市场.SetActive(true);
                    break;
                case "魔法行会":
                    人魔法行会.SetActive(true);
                    break;
                case "圣骑士教堂":
                    圣骑士.SetActive(true);
                    break;
                case "皇家城堡":
                    皇家城堡.SetActive(true);
                    break;
            }
        }

        if (type == 2)
        {
            switch (Build.bt)
            {
                case "近战兵营":
                    哥布林.SetActive(true);
                    野猪.SetActive(true);
                    狼.SetActive(true);
                    牛头人.SetActive(true);
                    break;
                case "远程兵营":
                    狮鹫.SetActive(true);
                    break;
                case "市场":
                    兽市场.SetActive(true);
                    break;
                case "魔法行会":
                    兽魔法行会.SetActive(true);
                    break;
                case "九头蛇金字塔":
                    九头蛇.SetActive(true);
                    break;
                case "皇家城堡":
                    皇家城堡.SetActive(true);
                    break;
            }
        }

        if (type == 3)
        {
            switch (Build.bt)
            {
                case "近战兵营":
                    骷髅兵.SetActive(true);
                    吸血鬼.SetActive(true);
                    break;
                case "远程兵营":
                    绿龙.SetActive(true);
                    红龙.SetActive(true);
                    黑龙.SetActive(true);
                    break;
                case "市场":
                    龙市场.SetActive(true);
                    break;
                case "魔法行会":
                    龙魔法行会.SetActive(true);
                    break;
                case "泰坦云间城堡":
                    泰坦.SetActive(true);
                    break;
                case "皇家城堡":
                    皇家城堡.SetActive(true);
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Refreshresource();
    }

    public void ToBuild()
    {
        SceneManager.LoadScene(2);
    }
    public void ToLevelup()
    {
        levelupmenu.SetActive(true);
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Refreshresource()
    {
        GameObject.Find("Canvas/Resource/wood/woodnum").GetComponent<Text>().text = resource.wood.ToString();
        GameObject.Find("Canvas/Resource/stone/stonenum").GetComponent<Text>().text = resource.stone.ToString();
        GameObject.Find("Canvas/Resource/sulfur/sulfurnum").GetComponent<Text>().text = resource.sulfur.ToString();
        GameObject.Find("Canvas/Resource/crystal/crystalnum").GetComponent<Text>().text = resource.crystal.ToString();
        GameObject.Find("Canvas/Resource/diamond/diamondnum").GetComponent<Text>().text = resource.diamond.ToString();
        GameObject.Find("Canvas/Resource/money/moneynum").GetComponent<Text>().text = resource.money.ToString();
    }
}
