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
    public double gold = 1000;

    //texts for HUD
    public Text UIknowledge;
    public Text UIcharisma;
    public Text UIgodsFavour;
    public Text UIgold;

    //timers
    public Text timer1;
    public Text timer2;
    public Text timer3;
    public Text timer4;
    public Text timer5;
    public Text timer6;
    public Text timer7;
    public Text timer8;
    public Text timer9;
    public Text timer10;
    public Text timer11;
    public Text timer12;

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
    double worth12 = 20480;
    int skillLevel12 = 1;
    float time12 = 30;
    float runetime12 = 0;




    //Making progress bars   
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
    public Image progressBar12;





    private void Awake()
    {
        // setup reference to game manager
        if (gm == null)
            gm = this.GetComponent<GameManager>();

    }

    // Start is called before the first frame update
    void Start()
    {
        //reseting bars
        progressBar1.fillAmount = 0;
        progressBar2.fillAmount = 0;
        progressBar3.fillAmount = 0;
        progressBar4.fillAmount = 0;
        progressBar5.fillAmount = 0;
        progressBar6.fillAmount = 0;
        progressBar7.fillAmount = 0;
        progressBar8.fillAmount = 0;
        progressBar9.fillAmount = 0;
        progressBar10.fillAmount = 0;
        progressBar11.fillAmount = 0;
        progressBar12.fillAmount = 0;

        //reseting timers
        timer1.text = time1.ToString("F0");
        timer2.text = time2.ToString("F0");
        timer3.text = time3.ToString("F0");
        timer4.text = time4.ToString("F0");
        timer5.text = time5.ToString("F0");
        timer6.text = time6.ToString("F0");
        timer7.text = time7.ToString("F0");
        timer8.text = time8.ToString("F0");
        timer9.text = time9.ToString("F0");
        timer10.text = time10.ToString("F0");
        timer11.text = time11.ToString("F0");
        timer12.text = time12.ToString("F0");

    }

    // Update is called once per frame
    void Update()
    {
        //Отображение HUDа;
        UIknowledge.text = "Знания: " + knowledge.ToString("F0");
        UIcharisma.text = "Харизма: " + charisma.ToString("F0");
        UIgodsFavour.text = "Божественная милость: " + godsFavour.ToString("F0");
        UIgold.text = "Золото: " + gold.ToString("F0");

        //Настройка кнопок        
        biblePrehistory.text = "История библии\nСтоимость обучения: " + worth1.ToString("F0") + " Золота\nУровень: " + skillLevel1;
        bibleInterpritation.text = "Интерпритация библии\nСтоимость обучения: " + worth2.ToString("F0") + " Золота\nУровень: " + skillLevel2;
        newTestament.text = "Новый Завет\nСтоимость обучения: " + worth3.ToString("F0") + " Золота\nУровень: " + skillLevel3;
        oldTestament.text = "Старый завет\nСтоимость обучения: " + worth4.ToString("F0") + " Золота\nУровень: " + skillLevel4;
        communicationWithGod.text = "Общение с высшими силами\nСтоимость обучения: " + worth5.ToString("F0") + " Золота\nУровень: " + skillLevel5;
        sermons.text = "Проповеди\nСтоимость обучения: " + worth6.ToString("F0") + " Золота\nУровень: " + skillLevel6;
        moralTheology.text = "Богословие\nСтоимость обучения: " + worth7.ToString("F0") + " Золота\nУровень: " + skillLevel7;
        prayers.text = "Молитвы\nСтоимость обучения: " + worth8.ToString("F0") + " Золота\nУровень: " + skillLevel8;
        rituals.text = "Ритуалы\nСтоимость обучения: " + worth9.ToString("F0") + " Золота\nУровень: " + skillLevel9;
        secretKnowledge.text = "Тайное знание\nСтоимость обучения: " + worth10.ToString("F0") + " Золота\nУровень: " + skillLevel10;
        heresy_deniel.text = "Борьба с ересью\nСтоимость обучения: " + worth11.ToString("F0") + " Золота\nУровень: " + skillLevel11;
        asceticText.text = "Аскетизм\nСтоимость обучения: " + worth12.ToString("F0") + " Золота\nУровень: " + skillLevel12;
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

    //button1
    public void runBar1()
    {
        if (gold >= worth1)
        {
            StartCoroutine(barRunningcoroutine1());
        }
    }

    IEnumerator barRunningcoroutine1()
    {
        gold -= worth1;
        worth1 *= 1.2;
        progressBar1.fillAmount = 0;
        while (progressBar1.fillAmount < 1)
        {
            timer1.text = "Time: " + (time1 - runetime1).ToString("F0");
            runetime1 += Time.deltaTime;
            progressBar1.fillAmount = runetime1 / time1;
            yield return null;
        }
        runetime1 = 0;
        skillLevel1++;        
        addKnowledge(1);       
        time1 *= 1.12f;
        timer1.text = time1.ToString("F0");
        progressBar1.fillAmount = 0;

    }

    //button2
    public void runBar2()
    {
        if (gold >= worth2)
        {
            StartCoroutine(barRunningcoroutine2());
        }
    }

    IEnumerator barRunningcoroutine2()
    {
        gold -= worth2;
        worth2 *= 1.2;
        progressBar2.fillAmount = 0;
        while (progressBar2.fillAmount < 1)
        {
            timer2.text = "Time: " + (time2 - runetime2).ToString("F0");
            runetime2 += Time.deltaTime;
            progressBar2.fillAmount = runetime2 / time2;
            yield return null;
        }
        runetime2 = 0;
        skillLevel2++;
        addCharisma(1);        
        time2 *= 1.12f;
        timer2.text = time2.ToString("F0");
        progressBar2.fillAmount = 0;
    }

    //button3
    public void runBar3()
    {
        if (gold >= worth3)
        {
            StartCoroutine(barRunningcoroutine3());
        }
    }

    IEnumerator barRunningcoroutine3()
    {
        gold -= worth3;
        worth3 *= 1.2;
        progressBar3.fillAmount = 0;
        while (progressBar3.fillAmount < 1)
        {
            timer3.text = "Time: " + (time3 - runetime3).ToString("F0");
            runetime3 += Time.deltaTime;
            progressBar3.fillAmount = runetime3 / time3;
            yield return null;
        }
        runetime3 = 0;
        skillLevel3++;        
        addgodsFavour(1);
        time3 *= 1.12f;
        timer3.text = time3.ToString("F0");
        progressBar3.fillAmount = 0;
    }

    //button4
    public void runBar4()
    {
        if (gold >= worth4)
        {
            StartCoroutine(barRunningcoroutine4());
        }
    }

    IEnumerator barRunningcoroutine4()
    {
        gold -= worth4;
        worth4 *= 1.2;
        progressBar4.fillAmount = 0;
        while (progressBar4.fillAmount < 1)
        {
            timer4.text = "Time: " + (time4 - runetime4).ToString("F0");
            runetime4 += Time.deltaTime;
            progressBar4.fillAmount = runetime4 / time4;
            yield return null;
        }
        runetime4 = 0;
        skillLevel4++;       
        addKnowledge(1);
        addgodsFavour(1);
        time4 *= 1.12f;
        timer4.text = time4.ToString("F0");
        progressBar4.fillAmount = 0;
    }

    //button5
    public void runBar5()
    {
        if (gold >= worth5)
        {
            StartCoroutine(barRunningcoroutine5());
        }
    }

    IEnumerator barRunningcoroutine5()
    {
        gold -= worth5;
        worth5 *= 1.2;
        progressBar5.fillAmount = 0;
        while (progressBar5.fillAmount < 1)
        {
            timer5.text = "Time: " + (time5 - runetime5).ToString("F0");
            runetime5 += Time.deltaTime;
            progressBar5.fillAmount = runetime5 / time5;
            yield return null;
        }
        runetime5 = 0;
        skillLevel5++;
        addCharisma(1);
        addKnowledge(1);        
        time5 *= 1.12f;
        timer5.text = time5.ToString("F0");
        progressBar5.fillAmount = 0;
    }

    //button6
    public void runBar6()
    {
        if (gold >= worth6)
        {
            StartCoroutine(barRunningcoroutine6());
        }
    }

    IEnumerator barRunningcoroutine6()
    {
        gold -= worth6;
        worth6 *= 1.2;
        progressBar6.fillAmount = 0;
        while (progressBar6.fillAmount < 1)
        {
            timer6.text = "Time: " + (time6 - runetime6).ToString("F0");
            runetime6 += Time.deltaTime;
            progressBar6.fillAmount = runetime6 / time6;
            yield return null;
        }
        runetime6 = 0;
        skillLevel6++;
        addCharisma(1);        
        addgodsFavour(1);
        time6 *= 1.12f;
        timer6.text = time6.ToString("F0");
        progressBar6.fillAmount = 0;
    }

    //button7
    public void runBar7()
    {
        if (gold >= worth7)
        {
            StartCoroutine(barRunningcoroutine7());
        }
    }

    IEnumerator barRunningcoroutine7()
    {
        gold -= worth7;
        worth7 *= 1.2;
        progressBar7.fillAmount = 0;
        while (progressBar7.fillAmount < 1)
        {
            timer7.text = "Time: " + (time7 - runetime7).ToString("F0");
            runetime7 += Time.deltaTime;
            progressBar7.fillAmount = runetime7 / time7;
            yield return null;
        }
        runetime7 = 0;
        skillLevel7++;
        addCharisma(1);
        addKnowledge(1);
        addgodsFavour(1);
        time7 *= 1.12f;
        timer7.text = time7.ToString("F0");
        progressBar7.fillAmount = 0;
    }

    //button8
    public void runBar8()
    {
        if (gold >= worth8)
        {
            StartCoroutine(barRunningcoroutine8());
        }
    }

    IEnumerator barRunningcoroutine8()
    {
        gold -= worth8;
        worth8 *= 1.2;
        progressBar8.fillAmount = 0;
        while (progressBar8.fillAmount < 1)
        {
            timer8.text = "Time: " + (time8 - runetime8).ToString("F0");
            runetime8 += Time.deltaTime;
            progressBar8.fillAmount = runetime8 / time8;
            yield return null;
        }
        runetime8 = 0;
        skillLevel8++;
        addCharisma(1);
        addKnowledge(2);
        addgodsFavour(1);
        time8 *= 1.12f;
        timer8.text = time8.ToString("F0");
        progressBar8.fillAmount = 0;
    }

    //button9
    public void runBar9()
    {
        if (gold >= worth9)
        {
            StartCoroutine(barRunningcoroutine9());
        }
    }

    IEnumerator barRunningcoroutine9()
    {
        gold -= worth9;
        worth9 *= 1.2;
        progressBar9.fillAmount = 0;
        while (progressBar9.fillAmount < 1)
        {
            timer9.text = "Time: " + (time9 - runetime9).ToString("F0");
            runetime9 += Time.deltaTime;
            progressBar9.fillAmount = runetime9 / time9;
            yield return null;
        }
        runetime9 = 0;
        skillLevel9++;
        addCharisma(2);
        addKnowledge(1);
        addgodsFavour(1);
        time9 *= 1.12f;
        timer9.text = time9.ToString("F0");
        progressBar9.fillAmount = 0;
    }

    //button10
    public void runBar10()
    {
        if (gold >= worth10)
        {
            StartCoroutine(barRunningcoroutine10());
        }
    }

    IEnumerator barRunningcoroutine10()
    {
        gold -= worth10;
        worth10 *= 1.2;
        progressBar10.fillAmount = 0;
        while (progressBar10.fillAmount < 1)
        {
            timer10.text = "Time: " + (time10 - runetime10).ToString("F0");
            runetime10 += Time.deltaTime;
            progressBar10.fillAmount = runetime10 / time10;
            yield return null;
        }
        runetime10 = 0;
        skillLevel10++;
        addCharisma(1);
        addKnowledge(1);
        addgodsFavour(2);
        time10 *= 1.12f;
        timer10.text = time10.ToString("F0");
        progressBar10.fillAmount = 0;
    }

    //button 11
    public void runBar11()
    {
        if (gold >= worth11)
        {
            StartCoroutine(barRunningcoroutine11());
        }
    }

    IEnumerator barRunningcoroutine11()
    {
        gold -= worth11;
        worth11 *= 1.2;
        progressBar11.fillAmount = 0;
        while (progressBar11.fillAmount < 1)
        {
            timer11.text = "Time: " + (time11 - runetime11).ToString("F0");
            runetime11 += Time.deltaTime;
            progressBar11.fillAmount = runetime11 / time11;
            yield return null;
        }
        runetime11 = 0;
        skillLevel11++;
        addCharisma(2);
        addKnowledge(2);
        addgodsFavour(2);
        time11 *= 1.12f;
        timer11.text = time11.ToString("F0");
        progressBar11.fillAmount = 0;
    }

    //button12
    public void runBar12()
    {
        if (gold >= worth12)
        {
            StartCoroutine(barRunningcoroutine12());
        }
    }

    IEnumerator barRunningcoroutine12()
    {
        gold -= worth12;
        worth12 *= 1.2;
        progressBar12.fillAmount = 0;
        while (progressBar12.fillAmount < 1)
        {
            timer12.text = "Time: " + (time12 - runetime12).ToString("F0");
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
        timer12.text = time12.ToString("F0");
        progressBar12.fillAmount = 0;
    }

}
