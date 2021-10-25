using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Build : MonoBehaviour
{
    public GameObject btnback;
    public GameObject btnaddnum;

    public GameObject btnmarket;
    public GameObject btnlong;
    public GameObject btnshort;
    public GameObject btnboss;
    public GameObject btnmagic;

    public GameObject btnmarkett;
    public GameObject btnlongg;
    public GameObject btnshortt;
    public GameObject btnbosss;
    public GameObject btnmagicc;

    public GameObject btnmarkettt;
    public GameObject btnlonggg;
    public GameObject btnshorttt;
    public GameObject btnbossss;
    public GameObject btnmagiccc;

    public GameObject buildmenu;

    public static int usewood;
    public static int usestone;
    public static int usesulfur;
    public static int usecrystal;
    public static int usediamond;
    public static int usemoney;

    public static string bt;
    public static string br;


    // Start is called before the first frame update
    void Start()
    {
        btnback.GetComponent<Button>().onClick.AddListener(Back);
        btnaddnum.GetComponent<Button>().onClick.AddListener(Addnum);

        btnmarket.GetComponent<Button>().onClick.AddListener(Market);
        btnlong.GetComponent<Button>().onClick.AddListener(Long);
        btnshort.GetComponent<Button>().onClick.AddListener(Short);
        btnboss.GetComponent<Button>().onClick.AddListener(Boss);
        btnmagic.GetComponent<Button>().onClick.AddListener(Magic);

        btnmarkett.GetComponent<Button>().onClick.AddListener(Market);
        btnlongg.GetComponent<Button>().onClick.AddListener(Long);
        btnshortt.GetComponent<Button>().onClick.AddListener(Short);
        btnbosss.GetComponent<Button>().onClick.AddListener(Bosss);
        btnmagicc.GetComponent<Button>().onClick.AddListener(Magic);

        btnmarkettt.GetComponent<Button>().onClick.AddListener(Market);
        btnlonggg.GetComponent<Button>().onClick.AddListener(Long);
        btnshorttt.GetComponent<Button>().onClick.AddListener(Short);
        btnbossss.GetComponent<Button>().onClick.AddListener(Bossss);
        btnmagiccc.GetComponent<Button>().onClick.AddListener(Magic);

    }

    // Update is called once per frame
    void Update()
    {
        if (inCastle.type == 1)
        {
            if(levelupmenu.level == 1 )
            {
                GameObject.Find("Canvas/build/shortrange").SetActive(true);
                GameObject.Find("Canvas/build/longrange").SetActive(true);
                GameObject.Find("Canvas/build/boss").SetActive(true);
            }
            if (levelupmenu.level >= 2)
            {
                GameObject.Find("Canvas/build/shortrange").SetActive(true);
                GameObject.Find("Canvas/build/longrange").SetActive(true);
                GameObject.Find("Canvas/build/boss").SetActive(true);
                GameObject.Find("Canvas/build/magic").SetActive(true);
                GameObject.Find("Canvas/build/market").SetActive(true);
            }
        }

        if (inCastle.type == 2)
        {
            if (levelupmenu.level == 1)
            {
                GameObject.Find("Canvas/build/shortrangee").SetActive(true);
                GameObject.Find("Canvas/build/longrangee").SetActive(true);
                GameObject.Find("Canvas/build/bosss").SetActive(true);
            }
            if (levelupmenu.level >= 2)
            {
                GameObject.Find("Canvas/build/shortrangee").SetActive(true);
                GameObject.Find("Canvas/build/longrangee").SetActive(true);
                GameObject.Find("Canvas/build/bosss").SetActive(true);
                GameObject.Find("Canvas/build/magicc").SetActive(true);
                GameObject.Find("Canvas/build/markett").SetActive(true);
            }
        }

        if (inCastle.type == 3)
        {
            if (levelupmenu.level == 1)
            {
                GameObject.Find("Canvas/build/shortrangeee").SetActive(true);
                GameObject.Find("Canvas/build/longrangeee").SetActive(true);
                GameObject.Find("Canvas/build/bossss").SetActive(true);
            }
            if (levelupmenu.level >= 2)
            {
                GameObject.Find("Canvas/build/shortrangeee").SetActive(true);
                GameObject.Find("Canvas/build/longrangeee").SetActive(true);
                GameObject.Find("Canvas/build/bossss").SetActive(true);
                GameObject.Find("Canvas/build/magiccc").SetActive(true);
                GameObject.Find("Canvas/build/markettt").SetActive(true);
            }
        }

        if(levelupmenu.level == 3)
        {
            GameObject.Find("Canvas/build/addnum").SetActive(true);
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }
    public void Short()
    {
        bt = "��ս��Ӫ";
        br = "ľͷ*10 ʯͷ*10 ���*2000";
        usewood = 10;
        usestone = 10;
        usesulfur = 0;
        usecrystal = 0;
        usediamond = 0;
        usemoney = 2000;
        buildmenu.SetActive(true);
    }
    public void Long()
    {
        bt = "Զ�̱�Ӫ";
        br = "ľͷ*10 ʯͷ*10 ���*3000";
        usewood = 10;
        usestone = 10;
        usesulfur = 0;
        usecrystal = 0;
        usediamond = 0;
        usemoney = 3000;
        buildmenu.SetActive(true);
    }
    public void Market()
    {
        bt = "�г�";
        br = "ľͷ*5 ʯͷ*5 ���*1000";
        usewood = 5;
        usestone = 5;
        usesulfur = 0;
        usecrystal = 0;
        usediamond = 0;
        usemoney = 1000;
        buildmenu.SetActive(true);
    }
    public void Boss()
    {
        bt = "ʥ��ʿ����";
        br = "ľͷ*20 ʯͷ*20 ��ʯ*10 ���*3000";
        usewood = 20;
        usestone = 20;
        usesulfur = 0;
        usecrystal = 0;
        usediamond = 10;
        usemoney = 3000;
        buildmenu.SetActive(true);
    }
    public void Bosss()
    {
        bt = "��ͷ�߽�����";
        br = "ľͷ*15 ʯͷ*25 ˮ��*8 ���*2500";
        usewood = 15;
        usestone = 25;
        usecrystal = 8;
        usesulfur = 0;
        usediamond = 0;
        usemoney = 2500;
        buildmenu.SetActive(true);
    }
    public void Bossss()
    {
        bt = "̩̹�Ƽ�Ǳ�";
        br = "ľͷ*20 ʯͷ*30 ���*15 ���*3500";
        usewood = 20;
        usestone = 30;
        usesulfur = 15;
        usecrystal = 0;
        usediamond = 0;
        usemoney = 3500;
        buildmenu.SetActive(true);
    }
    public void Magic()
    {
        bt = "ħ���л�";
        br = "ľͷ*5 ʯͷ*5 ˮ��*5 ���*5 ��ʯ*5 ���*500";
        usewood = 5;
        usestone = 5;
        usesulfur = 5;
        usecrystal = 5;
        usediamond = 5;
        usemoney = 500;
        buildmenu.SetActive(true);
    }
    public void Addnum()
    {
        bt = "�ʼҳǱ�";
        br = "ľͷ*10 ʯͷ*10 ���*2000";
        usewood = 10;
        usestone = 10;
        usesulfur = 0;
        usecrystal = 0;
        usediamond = 0;
        usemoney = 2000;
        buildmenu.SetActive(true);
    }
}
