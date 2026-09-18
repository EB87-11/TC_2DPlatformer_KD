using Unity.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float m_speed = 10.0f;
    Rigidbody2D m_Rigidbody;
    public float m_JumpPower = 10.0f;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float xmove = Input.GetAxisRaw("Horizontal");
        float ymove = Input.GetAxisRaw("Vertical");
        m_Rigidbody.linearVelocity = new Vector2(xmove * m_speed, m_Rigidbody.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(Vector2.up * m_JumpPower, ForceMode2D.Impulse);
        }

    }
}
