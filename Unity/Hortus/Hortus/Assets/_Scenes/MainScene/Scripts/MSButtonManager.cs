using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MSButtonManager : MonoBehaviour {
    
    public void OnBeginClick()
    {
        SceneManager.LoadScene("Description1");
    }
}
