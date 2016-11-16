using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PanierBoutonManager : MonoBehaviour {

	public void ReturnClick()
    {
        SceneManager.LoadScene("RA Scene");
    }

    public void LastClick()
    {
        SceneManager.LoadScene("LastScene");
    }
}
