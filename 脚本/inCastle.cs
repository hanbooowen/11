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

    public GameObject ũ��;
    public GameObject ǹ��;
    public GameObject ���;
    public GameObject ������;
    public GameObject �����;
    public GameObject ʥ��ʿ;
    public GameObject �粼��;
    public GameObject Ұ��;
    public GameObject ��;
    public GameObject ţͷ��;
    public GameObject ʨ��;
    public GameObject ��ͷ��;
    public GameObject ���ñ�;
    public GameObject ��Ѫ��;
    public GameObject ����;
    public GameObject ����;
    public GameObject ����;
    public GameObject ̩̹;

    public GameObject ���г�;
    public GameObject ��ħ���л�;
    public GameObject ���г�;
    public GameObject ��ħ���л�;
    public GameObject ���г�;
    public GameObject ��ħ���л�;

    public GameObject �ʼҳǱ�;

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
                GameObject.Find("Canvas/castletype").GetComponent<Text>().text = "����Ǳ�";
                r.SetActive(true);
                break;
            case 2:
                GameObject.Find("Canvas/castletype").GetComponent<Text>().text = "����Ǳ�";
                s.SetActive(true);
                break;
            case 3:
                GameObject.Find("Canvas/castletype").GetComponent<Text>().text = "����Ǳ�";
                l.SetActive(true);
                break;
        }

        if (type == 1)
        {
            switch (Build.bt)
            {
                case "��ս��Ӫ":
                    ũ��.SetActive(true);
                    ǹ��.SetActive(true);
                    ���.SetActive(true);
                    break;
                case "Զ�̱�Ӫ":
                    ������.SetActive(true);
                    �����.SetActive(true);
                    break;
                case "�г�":
                    ���г�.SetActive(true);
                    break;
                case "ħ���л�":
                    ��ħ���л�.SetActive(true);
                    break;
                case "ʥ��ʿ����":
                    ʥ��ʿ.SetActive(true);
                    break;
                case "�ʼҳǱ�":
                    �ʼҳǱ�.SetActive(true);
                    break;
            }
        }

        if (type == 2)
        {
            switch (Build.bt)
            {
                case "��ս��Ӫ":
                    �粼��.SetActive(true);
                    Ұ��.SetActive(true);
                    ��.SetActive(true);
                    ţͷ��.SetActive(true);
                    break;
                case "Զ�̱�Ӫ":
                    ʨ��.SetActive(true);
                    break;
                case "�г�":
                    ���г�.SetActive(true);
                    break;
                case "ħ���л�":
                    ��ħ���л�.SetActive(true);
                    break;
                case "��ͷ�߽�����":
                    ��ͷ��.SetActive(true);
                    break;
                case "�ʼҳǱ�":
                    �ʼҳǱ�.SetActive(true);
                    break;
            }
        }

        if (type == 3)
        {
            switch (Build.bt)
            {
                case "��ս��Ӫ":
                    ���ñ�.SetActive(true);
                    ��Ѫ��.SetActive(true);
                    break;
                case "Զ�̱�Ӫ":
                    ����.SetActive(true);
                    ����.SetActive(true);
                    ����.SetActive(true);
                    break;
                case "�г�":
                    ���г�.SetActive(true);
                    break;
                case "ħ���л�":
                    ��ħ���л�.SetActive(true);
                    break;
                case "̩̹�Ƽ�Ǳ�":
                    ̩̹.SetActive(true);
                    break;
                case "�ʼҳǱ�":
                    �ʼҳǱ�.SetActive(true);
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
