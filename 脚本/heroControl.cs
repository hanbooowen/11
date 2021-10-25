using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroControl : MonoBehaviour
{
    public float speed = 5f;//�ƶ��ٶ�
    public int wood = 20;//ľ������
    public int maxresource = 9999;//�����Դ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");//����ˮƽ�����ƶ�ad
        float moveY = Input.GetAxisRaw("Vertical");//���ƴ�ֱ�����ƶ�ws

        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveY * speed * Time.deltaTime;
        transform.position = position;
    }

    public void ChangeWood(int amount)
    {
        wood = Mathf.Clamp(wood + amount, 0, maxresource);
    }
}
