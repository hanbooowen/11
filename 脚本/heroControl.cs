using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroControl : MonoBehaviour
{
    public float speed = 5f;//移动速度
    public int wood = 20;//木材数量
    public int maxresource = 9999;//最大资源数量

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");//控制水平方向移动ad
        float moveY = Input.GetAxisRaw("Vertical");//控制垂直方向移动ws

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
