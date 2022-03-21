using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class FinDeNiveau : MonoBehaviour
{
    public int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Félicitation, le niveau est terminé.");
            GameManager.Instance.PlayerData.NiveauFini();
            GameManager.Instance.SaveData();
            if (GameManager.Instance.PlayerData.Level.Equals(3))
            {
                nextSceneLoad = 0;

            }
            SceneManager.LoadScene(nextSceneLoad);
        }
    }
}
