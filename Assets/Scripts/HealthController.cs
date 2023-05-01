using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int playerHealth = 3;
    [SerializeField] private Image[] hearts;
    [SerializeField] private DamageController _damageController;

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        if (playerHealth <= 0) // Kiedy posta� straci wszystkie �ycia.
        {
            //Restart the game
            //or
            //Freeze the game etc

            //this.gameObject.GetComponent<skryptdosterowania>.enabled = false;

            Time.timeScale = 0;

            Debug.Log("GAME OVER");
        }


        {
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < playerHealth)
                {
                    hearts[i].color = Color.red;
                }
                else
                {
                    hearts[i].color = Color.black;
                }
            }
        }
    }
}
