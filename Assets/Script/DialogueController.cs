using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI testo1;
    public TextMeshProUGUI testo2;
    public GameObject Avanti;
    public GameObject Start;
    public void CambiaTesto()
    {
        testo1 = testo2;
        Avanti.SetActive(false);
        Start.SetActive(true);
    }
    public void CominciaGioco()
    {
        SceneManager.LoadScene("Hub");
    }

}
