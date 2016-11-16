using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RAButtonManager : MonoBehaviour {

	public void OnPanierClick()
    {
        SceneManager.LoadScene("PanierScene");
    }
}
