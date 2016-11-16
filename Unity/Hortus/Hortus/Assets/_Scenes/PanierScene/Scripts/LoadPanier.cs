using UnityEngine;
using System.Collections;
using MotifsGo;
using UnityEngine.UI;

public class LoadPanier : MonoBehaviour {

    public GameObject panelImage0;
    public GameObject panelImage1;
    public GameObject panelImage2;
    public GameObject panelImage3;
    public GameObject panelImage4;
    public GameObject panelImage5;
    public GameObject panelImage6;
    public GameObject panelImage7;
    public GameObject panelImage8;
    public GameObject panelImage9;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public Sprite sprite12;
    public Sprite sprite13;
    public Sprite sprite14;
    public Sprite sprite15;
    public Sprite sprite16;
    public Sprite sprite17;
    public Sprite sprite18;
    public Sprite sprite19;
    public Sprite sprite20;
    public Sprite sprite21;
    public Sprite sprite22;
    public Sprite sprite23;
    public Sprite sprite24;
    public Sprite sprite25;
    public Sprite sprite26;
    public Sprite sprite27;
    public Sprite sprite28;
    public Sprite sprite29;
    public Sprite sprite30;
    public Sprite sprite31;
    public Sprite sprite32;
    public Sprite sprite33;

    // Use this for initialization
    void Start () {
        int compteur = 0;
	    foreach (string item in SaveList.Instance.listSave){
            if (compteur == 0)
            {
                //panelImage0.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage0);
            }
            else if (compteur == 1)
            {
                //panelImage1.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage1);
            }
            else if (compteur == 2)
            {
                //panelImage2.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage2);
            }
            else if (compteur == 3)
            {
                //panelImage3.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage3);
            }
            else if (compteur == 4)
            {
                //panelImage4.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage4);
            }
            else if (compteur == 5)
            {
                //panelImage5.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage5);
            }
            else if (compteur == 6)
            {
                //panelImage6.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage6);
            }
            else if (compteur == 7)
            {
                //panelImage7.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage7);
            }
            else if (compteur == 8)
            {
                //panelImage8.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage8);
            }
            else if (compteur == 9)
            {
                //panelImage0.GetComponentInChildren<Text>().text = item;
                GetImage(item, panelImage9);
            }
            compteur++;
        }
    }

    private void GetImage(string text, GameObject image)
    {
        if (text == "Cartel-01")
        {
            image.GetComponent<Image>().sprite = sprite1;
        }
        else if (text == "Cartel-02")
        {
            image.GetComponent<Image>().sprite = sprite2;

        }
        else if (text == "Cartel-03")
        {
            image.GetComponent<Image>().sprite = sprite3;

        }
        else if (text == "Cartel-04")
        {
            image.GetComponent<Image>().sprite = sprite4;

        }
        else if (text == "Cartel-05")
        {
            image.GetComponent<Image>().sprite = sprite5;

        }
        else if (text == "Cartel-06")
        {
            image.GetComponent<Image>().sprite = sprite6;

        }
        else if (text == "Cartel-07")
        {
            image.GetComponent<Image>().sprite = sprite7;

        }
        else if (text == "Cartel-08")
        {
            image.GetComponent<Image>().sprite = sprite8;

        }
        else if (text == "Cartel-09")
        {
            image.GetComponent<Image>().sprite = sprite9;
        }
        else if (text == "Cartel-10")
        {
            image.GetComponent<Image>().sprite = sprite10;

        }
        else if (text == "Cartel-11")
        {
            image.GetComponent<Image>().sprite = sprite11;

        }
        else if (text == "Cartel-12")
        {
            image.GetComponent<Image>().sprite = sprite12;

        }
        else if (text == "Cartel-13")
        {
            image.GetComponent<Image>().sprite = sprite13;

        }
        else if (text == "Cartel-14")
        {
            image.GetComponent<Image>().sprite = sprite14;

        }
        else if (text == "Cartel-15")
        {
            image.GetComponent<Image>().sprite = sprite15;

        }
        else if (text == "Cartel-16")
        {
            image.GetComponent<Image>().sprite = sprite16;

        }
        else if (text == "Cartel-17")
        {
            image.GetComponent<Image>().sprite = sprite17;

        }
        else if (text == "Cartel-18")
        {
            image.GetComponent<Image>().sprite = sprite18;

        }
        else if (text == "Cartel-19")
        {
            image.GetComponent<Image>().sprite = sprite19;

        }
        else if (text == "Cartel-20")
        {
            image.GetComponent<Image>().sprite = sprite20;

        }
        else if (text == "Cartel-21")
        {
            image.GetComponent<Image>().sprite = sprite21;

        }
        else if (text == "Cartel-22")
        {
            image.GetComponent<Image>().sprite = sprite22;
        }
        else if (text == "Cartel-23")
        {
            image.GetComponent<Image>().sprite = sprite23;
        }
        else if (text == "Cartel-24")
        {
            image.GetComponent<Image>().sprite = sprite24;
        }
        else if (text == "Cartel-25")
        {
            image.GetComponent<Image>().sprite = sprite25;
        }
        else if (text == "Cartel-26")
        {
            image.GetComponent<Image>().sprite = sprite26;
        }
        else if (text == "Cartel-27")
        {
            image.GetComponent<Image>().sprite = sprite27;
            
        }
        else if (text == "Cartel-28")
        {
            image.GetComponent<Image>().sprite = sprite28;
            
        }
        else if (text == "Cartel-29")
        {
            image.GetComponent<Image>().sprite = sprite29;
            
        }
        else if (text == "Cartel-30")
        {
            image.GetComponent<Image>().sprite = sprite30;
            
        }
        else if (text == "Cartel-31")
        {
            image.GetComponent<Image>().sprite = sprite31;
            
        }
        else if (text == "Cartel-32")
        {
            image.GetComponent<Image>().sprite = sprite32;
            
        }
        else if (text == "Cartel-33")
        {
            image.GetComponent<Image>().sprite = sprite33;
            
        }
    }
}
