using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadScene : MonoBehaviour {

    private string text;
    public GameObject image;
    public GameObject textGo;

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

    }
	
	// Update is called once per frame
	void Update () {
        text = PlayerPrefs.GetString("motif");
        if (text == "Cartel-01")
        {
            image.GetComponent<Image>().sprite = sprite1;
            textGo.GetComponent<Text>().text = "Chien\nLe potier Titos est notamment connu pour son amour des chiens, dont on retrouve beaucoup de représentations sur les sigillées issues de son atelier.\nCe motif est représentée sur un fragment de coupe, datée des années 50 - 60 après J.-C.";
        }
        else if (text == "Cartel-02")
        {
            image.GetComponent<Image>().sprite = sprite2;
            textGo.GetComponent<Text>().text = "Dauphin\nN'est-il pas magnifique ce dauphin stylisé, représenté sur un pot daté des années 170-210 ?";
        }
        else if (text == "Cartel-03")
        {
            image.GetComponent<Image>().sprite = sprite3;
            textGo.GetComponent<Text>().text = "Coq\nOui, c'est bien un coq de profil, dont on reconnaît aisément la tête (bec et crête) ainsi que l'aile et la patte à ergot. Le pot date des années 140 - 170.";
        }
        else if (text == "Cartel-04")
        {
            image.GetComponent<Image>().sprite = sprite4;
            textGo.GetComponent<Text>().text = "Sanglier\nCe sanglier, animal caractéristique des scènes de chasse, sert de motif iconographique pour cette céramique datée des années 90 - 110.";
        }
        else if (text == "Cartel-05")
        {
            image.GetComponent<Image>().sprite = sprite5;
            textGo.GetComponent<Text>().text = "Amour ailé\nPersonnage associé à Cupidon, cet Amour fait partie de son cortège et se caractérise par sa paire d'ailes et sa nudité. Ce pot appartient à la production du potier Cinnamus, que l'on date du milieu du 2ème siècle après J.-C.";
        }
        else if (text == "Cartel-06")
        {
            image.GetComponent<Image>().sprite = sprite6;
            textGo.GetComponent<Text>().text = "Masque de satyre ou vieillard\nOn reconnaît bien à sa calvitie et à sa barbe clairsemée le vieillard ou peut - être un satyre, ce personnage mythologique du cortège de Bacchus ou de Pan.\nCe pot provient de la production de l'atelier du potier Libertus ; on le date du début du 2ème siècle après J.-C.";
        }
        else if (text == "Cartel-07")
        {
            image.GetComponent<Image>().sprite = sprite7;
            textGo.GetComponent<Text>().text = "Mars Ultor\nIl faut imaginer le dieu Mars en armes, portant un casque ainsi qu'une lance. Il s'agit ici du motif du Mars Vengeur.\nCe pot provient de l'atelier du potier Marcus, on le date de la 1ère moitié du 3ème siècle après J.-C.";
        }
        else if (text == "Cartel-08")
        {
            image.GetComponent<Image>().sprite = sprite8;
            textGo.GetComponent<Text>().text = "Minerve\nFigure de femme, casquée, armurée et avec bouclier, aucun doute, il s'agit bien de Minerve, fille de Jupiter et Métis, sortie toute en armes de la tête de son père.\nCe pot fait partie de la production du potier Cinnamus, on le date du milieu du 2ème siècle après J.-C.";
        }
        else if (text == "Cartel-09")
        {
            image.GetComponent<Image>().sprite = sprite9;
            textGo.GetComponent<Text>().text = "Feuille d'Acanthe\nLa feuille d'acanthe est un élément de décoration très utilisé depuis l'antiquité grecque, aussi bien en architecture qu'en ornementation d'objets.Ce motif est inspiré des feuilles d'espèces méditerranéennes du genre Acanthus, qui ont la particularité d'être profondément découpées.\nCe pot est daté des années 90 - 110.";
        }
        else if (text == "Cartel-10")
        {
            image.GetComponent<Image>().sprite = sprite10;
            textGo.GetComponent<Text>().text = "Mirmillon\nOn reconnaît un court glaive, un bras cuirassé et un bout de casque : c'est l'armement classique du Mirmillon, celui des gladiateur le plus lourdement équipé.\nCe fragment appartient à un pot issu de l'atelier de Titos, on le date des années 50-60 après J.-C.";
        }
        else if (text == "Cartel-11")
        {
            image.GetComponent<Image>().sprite = sprite11;
            textGo.GetComponent<Text>().text = "Feuille de marronnier\nLa feuille de marronnier se caractérise par sa nature composée, elle est en effet palmée et constituée de 5 à 7 folioles(on en compte ici 7).Il y en a plein la cour du musée, allez les regarder d'un peu plus près.\nCe pot provient de l'atelier de Cinnamus ; on le date du milieu du 2ème siècle après J.-C.";
        }
        else if (text == "Cartel-12")
        {
            image.GetComponent<Image>().sprite = sprite12;
            textGo.GetComponent<Text>().text = "Hérisson perplexe\nInspiré des travaux du céramologue - astronaute Baloriastov, ce hérisson en forme de point d'interrogation est caractéristique des vaisseaux à propulsion aqueuse. Il date du 32986ème millénaire après Luke & Leia.";
        }
        else if (text == "Cartel-13")
        {
            image.GetComponent<Image>().sprite = sprite13;
            textGo.GetComponent<Text>().text = "Batte épineuse\nAu 19ème siècle, les rats des goûts des rues de New York se créent tout un outillage destiné à assurer leur survie. La batte à épines permettait en particulier de punaiser des feuilles mortes. ";
        }
        else if (text == "Cartel-14")
        {
            image.GetComponent<Image>().sprite = sprite14;
            textGo.GetComponent<Text>().text = "Perruque façon mulet\nLes costumiers du territoire de Belfort avait l'habitude d'habiller leurs potagers pour les protéger du gel. Ils leur constituaient alors des bonnets avec des vrais poils de yack, imitant les coupes de cheveux des acteurs des années 80 : le mulet.";
        }
        else if (text == "Cartel-15")
        {
            image.GetComponent<Image>().sprite = sprite15;
            textGo.GetComponent<Text>().text = "Hélice à moudre le gravier\nAu 623ème siècle avant Millenordia, le cuisinier fait avec les moyens du bord pour assaisonner ses décoctions.Le moulin à gravier a inspiré ce motif d'hélice, très répandu en Géopardie du sud.";
        }
        else if (text == "Cartel-16")
        {
            image.GetComponent<Image>().sprite = sprite16;
            textGo.GetComponent<Text>().text = "Vélo créé par Robinson, au pneu arrière éclaté d'avoir roulé sur Vendredi.";
        }
        else if (text == "Cartel-17")
        {
            image.GetComponent<Image>().sprite = sprite17;
            textGo.GetComponent<Text>().text = "i content sur fond vert. On le voit, il sourit, il est heureux et frémit. C'est le i content sur fond vert.";
        }
        else if (text == "Cartel-18")
        {
            image.GetComponent<Image>().sprite = sprite18;
            textGo.GetComponent<Text>().text = "Interdit d'être écolo. Ce motif fait partie de la signalétique développée à l'issue des tables rondes de la COP 34986.";
        }
        else if (text == "Cartel-19")
        {
            image.GetComponent<Image>().sprite = sprite19;
            textGo.GetComponent<Text>().text = "Porte vers la cabine Back to Lezoux. Ce motif était accroché sur toutes les portes des maisons de Lezoux dont les sanitaires proposait un accès vers le retour dans le futur, mais avant-hier plutôt. C'est pas clair ? Désolé.";
        }
        else if (text == "Cartel-20")
        {
            image.GetComponent<Image>().sprite = sprite20;
            textGo.GetComponent<Text>().text = "Traces de chevreuil écrasé retrouvé dans l'empreinte d'un papou.";
        }
        else if (text == "Cartel-21")
        {
            image.GetComponent<Image>().sprite = sprite21;
            textGo.GetComponent<Text>().text = "Prriutttk";
        }
        else if (text == "Cartel-22")
        {
            image.GetComponent<Image>().sprite = sprite22;
            textGo.GetComponent<Text>().text = "Et alors ?";
        }
        else if (text == "Cartel-23")
        {
            image.GetComponent<Image>().sprite = sprite23;
            textGo.GetComponent<Text>().text = "Discussion animée entre deux Playmobil vus de la flèche droite de la cathédrale de Clermont-Ferrand.";
        }
        else if (text == "Cartel-24")
        {
            image.GetComponent<Image>().sprite = sprite24;
            textGo.GetComponent<Text>().text = "Mâchoire de crocodile au mandibule supérieur édenté comme on en trouve souvent dans les marais de Lezoux.";
        }
        else if (text == "Cartel-25")
        {
            image.GetComponent<Image>().sprite = sprite25;
            textGo.GetComponent<Text>().text = "Cancer en cours de rémission.";
        }
        else if (text == "Cartel-26")
        {
            image.GetComponent<Image>().sprite = sprite26;
            textGo.GetComponent<Text>().text = "Evasion de prison, ne passez pas par la case départ mais venez nous faire un bisou rue Blatin.";
        }
        else if (text == "Cartel-27")
        {
            image.GetComponent<Image>().sprite = sprite27;
            textGo.GetComponent<Text>().text = "Mono-sourcil de type Emmanuel Chain en cochon pendu. C'est très clair pourtant.";
        }
        else if (text == "Cartel-28")
        {
            image.GetComponent<Image>().sprite = sprite28;
            textGo.GetComponent<Text>().text = "Mono-sourcil dubitatif, du type Emmanuel Chain, en verticalité slovène.";
        }
        else if (text == "Cartel-29")
        {
            image.GetComponent<Image>().sprite = sprite29;
            textGo.GetComponent<Text>().text = "Marteau punk à crête nacrée";
        }
        else if (text == "Cartel-30")
        {
            image.GetComponent<Image>().sprite = sprite30;
            textGo.GetComponent<Text>().text = "Quand PacMan, il fait peur. Ici, PacMan a faim, donc il fait peur.";
        }
        else if (text == "Cartel-31")
        {
            image.GetComponent<Image>().sprite = sprite31;
            textGo.GetComponent<Text>().text = "Attrape-moi si tu peux, crie le premier crocodile au second, libidineux.";
        }
        else if (text == "Cartel-32")
        {
            image.GetComponent<Image>().sprite = sprite32;
            textGo.GetComponent<Text>().text = "Moustache postiche de type Emmanuel Chain à se coller sur le pavillon de l'oreille..";
        }
        else if (text == "Cartel-33")
        {
            image.GetComponent<Image>().sprite = sprite33;
            textGo.GetComponent<Text>().text = "Trump ou dollar cannibal.";
        }

    }
}
