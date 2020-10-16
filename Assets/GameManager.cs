using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI; // include UI namespace so can reference UI elements

public class GameManager : MonoBehaviour
{

    // static reference to game manager so can be called from other scripts directly (not just through gameobject component)
    public static GameManager gm;

    //creating UI for HUD
    double knowledge = 0;
    double charisma = 0;
    double godsFavour = 0;
    double gold = 1000;
       
    //texts for HUD
    public Text UIknowledge;
    public Text UIcharisma;
    public Text UIgodsFavour;
    public Text UIgold;

    //texts for buttons    
    public Text biblePrehistory;
    public Text bibleInterpritation;
    public Text newTestament;
    public Text oldTestament;
    public Text communicationWithGod;
    public Text sermons;
    public Text moralTheology;
    public Text prayers;
    public Text rituals;
    public Text secretKnowledge;
    public Text heresy_deniel;
    public Text asceticText;

    //UI for buttons
 
    //buton1
    double worth1 = 10;
    int skillLevel1 = 1;
    float time1 = 3;
    float runetime1 = 0;

    //buton2
    double worth2 = 20;
    int skillLevel2 = 1;
    float time2 = 5;
    float runetime2 = 0;

    //buton3
    double worth3 = 40;
    int skillLevel3 = 1;
    float time3 = 7;
    float runetime3 = 0;

    //buton4
    double worth4 = 80;
    int skillLevel4 = 1;
    float time4 = 9;
    float runetime4 = 0;

    //buton5
    double worth5 = 160;
    int skillLevel5 = 1;
    float time5 = 11;
    float runetime5 = 0;

    //buton6
    double worth6 = 320;
    int skillLevel6 = 1;
    float time6 = 12;
    float runetime6 = 0;

    //buton7
    double worth7 = 640;
    int skillLevel7 = 1;
    float time7 = 15;
    float runetime7 = 0;

    //buton8
    double worth8 = 1280;
    int skillLevel8 = 1;
    float time8 = 18;
    float runetime8 = 0;

    //buton9
    double worth9 = 2560;
    int skillLevel9 = 1;
    float time9 = 21;
    float runetime9 = 0;

    //buton10
    double worth10 = 5120;
    int skillLevel10 = 1;
    float time10 = 24;
    float runetime10 = 0;

    //buton11
    double worth11 = 10240;
    int skillLevel11 = 1;
    float time11 = 27;
    float runetime11 = 0;

    //buton12
    double worth12 = 100;
    int skillLevel12 = 1;
    float time12 = 3;
    float runetime12 = 0;




    //Making progress bars
    public Image progressBar12;
    public Image progressBar1;
    public Image progressBar2;
    public Image progressBar3;
    public Image progressBar4;
    public Image progressBar5;
    public Image progressBar6;
    public Image progressBar7;
    public Image progressBar8;
    public Image progressBar9;
    public Image progressBar10;
    public Image progressBar11;
    




    private void Awake()
    {
        // setup reference to game manager
        if (gm == null)
            gm = this.GetComponent<GameManager>();
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Отображение HUDа;
        UIknowledge.text = "Знания: " + knowledge.ToString();
        UIcharisma.text = "Харизма: " + charisma.ToString();
        UIgodsFavour.text = "Божественная милость: " + godsFavour.ToString();
        UIgold.text = "Золото: " + gold.ToString();

        //Настройка кнопок
        asceticText.text = "Аскетизм\nСтоимость обучения: " + worth12 + " Золота\nУровень: " + skillLevel12;
        biblePrehistory.text = "История библии\nСтоимость обучения: " + worth1 + " Золота\nУровень: " + skillLevel1;
        bibleInterpritation.text = "Интерпритация библии\nСтоимость обучения: " + worth2 + " Золота\nУровень: " + skillLevel2;
        newTestament.text = "Новый Завет\nСтоимость обучения: " + worth3 + " Золота\nУровень: " + skillLevel3;
        oldTestament.text = "Старый завет\nСтоимость обучения: " + worth4 + " Золота\nУровень: " + skillLevel4;
         public Text newTestament;
    public Text oldTestament;
    public Text communicationWithGod;
    public Text sermons;
    public Text moralTheology;
    public Text prayers;
    public Text rituals;
    public Text secretKnowledge;
    public Text heresy_deniel;
    public Text asceticText;


}

   
    public void addKnowledge(int value)
    {
        knowledge += value;
    }

    public void addCharisma(int value)
    {
        charisma += value;
    }
    public void addgodsFavour(int value)
    {
        godsFavour += value;
    }

    //running progress bar
    public void runBar12()
    {
        if (gold >= worth12)
        {
            StartCoroutine(barRunningcoroutine12());
        }
    }

    IEnumerator barRunningcoroutine12()
    {
        gold -=worth12;
        worth12 *= 1.2;
        progressBar12.fillAmount = 0;        
        while (progressBar12.fillAmount < 1)
        {
            runetime12 += Time.deltaTime;
            progressBar12.fillAmount = runetime12 / time12;
            yield return null;
        }
        runetime12 = 0;
        skillLevel12++;
        addCharisma(2);
        addKnowledge(3);
        addgodsFavour(3);
        time12 *= 1.12f;



    }

}
