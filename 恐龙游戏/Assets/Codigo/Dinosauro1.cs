using UnityEngine;

public class Donosauro1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float fallSpeed;
    bool isFalling;
    public GameManager gm;
    float minY = -2.098552f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isFalling = false;
    }

    void Update()
    {
        // 如果按下向下键且不在下落中
        if (Input.GetKeyDown(KeyCode.DownArrow) && !isFalling)
        {
            // 直接设置速度为下落速度
            rb.velocity = new Vector2(rb.velocity.x, -fallSpeed);
            isFalling = true;
        }

        // 检查 y 坐标是否小于最小值
        if (transform.position.y < minY)
        {
            // 重置角色位置到 minY
            Vector3 newPosition = transform.position;
            newPosition.y = minY;
            transform.position = newPosition;
            // 停止下落
            isFalling = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isFalling = false;

        if (collision.gameObject.tag == "Cactus")
        {
            gm.GameOver();
        }
    }
}