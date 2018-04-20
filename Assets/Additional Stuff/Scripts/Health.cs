using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;

    public GameObject GameOverText;
    public GameObject ScreenFader;
    public GameObject PlayAgain;
    public GameObject Exit;

    private GameObject target;
    private GameObject[] spiders;
    public GameObject spawner;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead!");

            target = GameObject.FindGameObjectWithTag("Player");
            Destroy(target);
            Destroy(spawner);

            DestroyAllSpiders();

            GameOverText.SetActive(true);
            ScreenFader.SetActive(true);
            PlayAgain.SetActive(true);
            Exit.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


        }


    }

    void DestroyAllSpiders()
    {
        spiders = GameObject.FindGameObjectsWithTag("Spider");

        for (var i = 0; i < spiders.Length; i++)
        {
            Destroy(spiders[i]);
        }
    }
}
