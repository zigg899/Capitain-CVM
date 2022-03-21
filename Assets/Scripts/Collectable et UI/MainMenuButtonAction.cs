using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MainMenuButtonAction : MonoBehaviour
{
    public Button ButtonNiv2, ButtonNiv3;
    public TextMeshProUGUI totCart,totCon;
    
    void Update()
    {
        if (GameManager.Instance.PlayerData.Level > 1)
        {
            ButtonNiv2.interactable = true;
            ButtonNiv3.interactable = true;
        }
         totCart.text = GameManager.Instance.PlayerData.Cm.ToString();
         totCon.text =  GameManager.Instance.PlayerData.Cc.ToString(); 
            
    } 
    






    /// <summary>
    /// Permet d'afficher un panel transmis en paramètre
    /// </summary>
    /// <param name="PanelAOuvrir">Panel à afficher</param>
    public void AfficherPanel(GameObject PanelAOuvrir)
    {
        PanelAOuvrir.SetActive(true);
    }

    /// <summary>
    /// Permet de ferme aussi le panel actuel
    /// </summary>
    /// <param name="PanelAFermer">Panel à fermer</param>
    public void FermerPanel(GameObject PanelAFermer)
    {
        PanelAFermer.SetActive(false);
    }

    /// <summary>
    /// Permet de charger un niveau
    /// </summary>
    /// <param name="nom">Nom du niveau à charger</param>
    public void ChargerNiveau(string nom)
    {
        SceneManager.LoadScene(nom);
    }



    /// <summary>
    /// Permet de fermer l'application
    /// </summary>
    public void Quitter()
    {
        Application.Quit();
    }

}  

