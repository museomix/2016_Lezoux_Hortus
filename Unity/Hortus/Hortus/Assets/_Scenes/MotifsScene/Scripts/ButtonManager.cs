using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MotifsGo;

public class ButtonManager : MonoBehaviour {

    public void OnReturnClick()
    {
        SceneManager.LoadScene("RA Scene");
    }

    public void OnSaveClick()
    {
        string motif = PlayerPrefs.GetString("motif");
        if (!SaveList.Instance.listSave.Contains(motif))
        {
            SaveList.Instance.listSave.Add(motif);
        }
        SceneManager.LoadScene("PanierScene");
    }
}

