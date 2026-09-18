using UnityEngine;

public class Coin : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int m_Value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Only trigger if the player catches the coin
        if (collision.CompareTag("Player"))
        {
            //Find the score manager and add points
            Score Score = FindObjectOfType<Score>();

            if(Score != null)
            {
                Score.AddScore(m_Value);
            }

            //Destroy the coin so it disappears
            Destroy(gameObject);
        }
    }
}
