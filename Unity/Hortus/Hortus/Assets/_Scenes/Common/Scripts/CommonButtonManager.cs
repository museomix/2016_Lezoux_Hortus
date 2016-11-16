using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class CommonButtonManager : MonoBehaviour {

    public void OnDescription1Click()
    {
        SceneManager.LoadScene("Description2");
    }

    public void OnDescription2SuivClick()
    {
        SceneManager.LoadScene("Description3");
    }

    public void OnDescription2PrecClick()
    {
        SceneManager.LoadScene("Description1");
    }

    public void OnDescription3SuivClick()
    {
        SceneManager.LoadScene("RA Scene");
    }

    public void OnDescription3PrecClick()
    {
        SceneManager.LoadScene("Description2");
    }
}
