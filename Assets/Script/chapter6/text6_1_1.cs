using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1_1 : MonoBehaviour
{// Start is called before the first frame update
   public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    
    public static GameObject fadeout;
    //조사할 오브젝트
    public static GameObject bed;
    public static GameObject drawer;
    public static GameObject closet;
    public static GameObject sidetable;
    public static GameObject organizer;
    public static GameObject baghanger;
    public static GameObject restroom;
    public static GameObject another;
    

    public static Button bed_b;
    public static Button drawer_b;
    public static Button closet_b;
    public static Button sidetable_b;
    public static Button organizer_b;
    public static Button baghanger_b;
    public static Button restroom_b;
    public static Button another_b;
    public static Button achoice_b;
    public static Button bchoice_b;
    public static Button 스킵;

    public static Text bed_t;
    public static Text drawer_t;
    public static Text closet_t;
    public static Text sidetable_t;
    public static Text organizer_t;
    public static Text baghanger_t;
    public static Text restroom_t;
    public static Text another_t;
    public static Text achoice_t;
    public static Text bchoice_t;
    public static Text typingText;

    
    private static string text_1="당장이라도 눕고 싶지만 \n그럴 여유는 없다.";
    private static string text_2="텅 빈 서랍장은 \n뒤져봐도 소용없다.";

    private static string text_3="옷을 헤치고 \n안쪽을 더듬어 봤지만, \n당연히 옷 말고는 \n아무것도 없다.";
    private static string text_4="옷장 밑 1단 서랍장은 \n잠금이 걸려 있다.";
    private static string text_5="역시 비밀번호는 \n기억나지 않는다.\n구급상자를 \n금고에 넣어뒀을 리는 없으니 \n일단 구급상자부터 찾아보자.";

    private static string text_6="구급상자는 보이지 않는다.";
    private static string text_7="수납장 위를 훑어봐도 \n구급상자는 보이지 않아.";
    private static string text_8="백팩을 한 번 더 뒤졌다.\n역시 쓸 만한 것은\n보이지 않아.";
    private static string text_9="화장실에는 \n다시 들어가고 싶지 않다. ";
    private static string text_10="다른 곳도 둘러볼까?";
   

    static IEnumerator coroutine1 =  Typing(text_1);
    static IEnumerator coroutine2 =  Typing(text_2);
    static IEnumerator coroutine3 =  Typing(text_3);
    static IEnumerator coroutine4 =  Typing(text_4);
    static IEnumerator coroutine5 =  Typing(text_5);
    static IEnumerator coroutine6 =  Typing(text_6);
    static IEnumerator coroutine7 =  Typing(text_7);
    static IEnumerator coroutine8 =  Typing(text_8);
    static IEnumerator coroutine9 =  Typing(text_9);
    static IEnumerator coroutine10 =  Typing(text_10);
    
   

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;

    }
    public void activate(){
        
        bed_b.interactable=true;
        drawer_b.interactable=true;
        closet_b.interactable=true;
        sidetable_b.interactable=true;
        organizer_b.interactable=true;
        baghanger_b.interactable=true;
        restroom_b.interactable=true;
        another_b.interactable=true;
        
        drawer_t.text="(2) 서랍장";
        bed_t.text="(1) 침대";
        closet_t.text="(3) 옷장";
        sidetable_t.text="(4) 사이드테이블";
        organizer_t.text="(5) 수납대";
        baghanger_t.text="(6) 가방걸이";
        restroom_t.text="(7) 안방 화장실";
        another_t.text="(8) 다른 장소로 가본다.";
        
    }
    public void inactivate(){
        
        bed_b.interactable=false;
        drawer_b.interactable=false;
        closet_b.interactable=false;
        sidetable_b.interactable=false;
        organizer_b.interactable=false;
        baghanger_b.interactable=false;
        restroom_b.interactable=false;
        another_b.interactable=false;

        drawer_t.text=" ";
        bed_t.text=" ";
        closet_t.text=" ";
        sidetable_t.text=" ";
        organizer_t.text=" ";
        baghanger_t.text=" ";
        restroom_t.text=" ";
        another_t.text=" ";}

    public void click_bed(){
        스킵.interactable=false;
        num=2;
    }
    public void click_drawer(){
        스킵.interactable=false;
        num=5;
    }
    public void click_closet(){
        스킵.interactable=true;
        num=8;
    }
    public void click_sidetable(){
        num=17;
        스킵.interactable=false;
    }
    public void click_organizer(){
        스킵.interactable=false;
        num=20;
    }
    public void click_baghanger(){
        스킵.interactable=false;
        num=23;
    }
    public void click_restroom(){
        스킵.interactable=false;
        num=26;
        
    }
    public void click_another(){
        스킵.interactable=false;
        num=29;
        
    }
    public void choiceAB_activate(){
        achoice_b.interactable=true;
        bchoice_b.interactable=true;
        achoice_t.text="A. 다른 곳을 둘러본다.";
        bchoice_t.text="B. 아니다. 더 찾아보자.";

    }
    public void click_achoice(){
        SceneManager.LoadScene("6-1");
    }
    public void click_bchoice(){
        achoice_b.interactable=false;
        bchoice_b.interactable=false;
        achoice_t.text=" ";
        bchoice_t.text=" ";
        activate();
        typingText.text=" ";
    }

    static IEnumerator Typing(string message)
    {
        typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log(typingText);
        Debug.Log(message);

        //message=text_1;
        for (int i = 0; i < message.Length; i++)
        {
            typingText.text = message.Substring(0, i + 1);
            yield return new WaitForSeconds(0.05f);

            if(num%3==1){
                num++;
                Debug.Log("coroutine is stopped+num"+num);
                yield break; //코루틴종료
                //여기서 그냥 끊고, update에서 다음 시나리오 출력해주기
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면? ㅇㅋㅇㅋ

            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);


    }


  void Awake(){
    //button
    bed_b = GameObject.Find("bed").GetComponent<Button>();
    drawer_b = GameObject.Find("drawer").GetComponent<Button>();
    closet_b = GameObject.Find("closet").GetComponent<Button>();
    sidetable_b = GameObject.Find("sidetable").GetComponent<Button>();
    organizer_b = GameObject.Find("organizer").GetComponent<Button>();
    baghanger_b = GameObject.Find("baghanger").GetComponent<Button>();
    restroom_b = GameObject.Find("restroom").GetComponent<Button>();
    another_b = GameObject.Find("another").GetComponent<Button>();
    achoice_b = GameObject.Find("achoice").GetComponent<Button>();
    bchoice_b = GameObject.Find("bchoice").GetComponent<Button>();
    typingText = GameObject.Find("general text").GetComponent<Text>();
    //text
    bed_t = GameObject.Find("bedtext").GetComponent<Text>();
    drawer_t = GameObject.Find("drawertext").GetComponent<Text>();
    closet_t = GameObject.Find("closettext").GetComponent<Text>();
    sidetable_t = GameObject.Find("sidetabletext").GetComponent<Text>();
    organizer_t = GameObject.Find("organizertext").GetComponent<Text>();
    baghanger_t = GameObject.Find("baghangertext").GetComponent<Text>();
    restroom_t = GameObject.Find("restroomtext").GetComponent<Text>();
    another_t = GameObject.Find("anothertext").GetComponent<Text>();
    achoice_t= GameObject.Find("achoicetext").GetComponent<Text>();
    bchoice_t = GameObject.Find("bchoicetext").GetComponent<Text>();
    typingText = GameObject.Find("general text").GetComponent<Text>();

    //onclick -> function
    bed_b.onClick.AddListener(click_bed);
    drawer_b.onClick.AddListener(click_drawer);
    closet_b.onClick.AddListener(click_closet);
    sidetable_b.onClick.AddListener(click_sidetable);
    organizer_b.onClick.AddListener(click_organizer);
    baghanger_b.onClick.AddListener(click_baghanger);
    restroom_b.onClick.AddListener(click_restroom);
    another_b.onClick.AddListener(click_another);
    achoice_b.onClick.AddListener(click_achoice);
    bchoice_b.onClick.AddListener(click_bchoice);

  }
    // Start is called before the first frame update
   void Start()
    {
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;

        bed_b.interactable=true;
        drawer_b.interactable=true;
        closet_b.interactable=true;
        sidetable_b.interactable=true;
        organizer_b.interactable=true;
        baghanger_b.interactable=true;
        restroom_b.interactable=true;
        another_b.interactable=true;
        
        bed_t.text="(1) 침대";
        drawer_t.text="(2) 서랍장";
        closet_t.text="(3) 옷장";
        sidetable_t.text="(4) 사이드테이블";
        organizer_t.text="(5) 수납대";
        baghanger_t.text="(6) 가방걸이";
        restroom_t.text="(7) 안방 화장실";
        another_t.text="(8) 다른 장소로 가본다.";
        achoice_t.text=" ";
        bchoice_t.text=" ";
        Debug.Log("coroutin is started! #6-1-2 -> 작업실 조사 num"+num);
        
        

    }

//     // Update is called once per frame
    void Update(){

        Debug.Log(num);
        if(num==2){
            //(1)bed
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
            Invoke("activate",1.8f);
        }
        if(num==5){
            //(2)drawer
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            Invoke("activate",1.8f);
            
        }
        if(num==8){
            //(3)closet-1
            스킵.interactable=true;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
            //closet text 출력시작 
            
        }
        if(num==11){
            //(3)closet-2
            inactivate();
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            
            
        }
        if(num==14){
            //(3)closet-3
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",4.3f);
        }
        
        if(num==17){
            //(4)sidetable
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1f);
        }
        if(num==20){
            //(5)organizer
            스킵.interactable=false;
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1.8f);
        }
        if(num==23){
            //(6)baghanger
            inactivate();
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            스킵.interactable=false;
            Invoke("activate",2.5f);
            
        }
        if(num==26){
            //(7)안방화장실
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1.8f);
        }
        if(num==29){
            //(8)다른 장소로 가본다.
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("choiceAB_activate",1.8f);
            //activate button
            
        }
        // if(num==32){
        //     스킵.interactable=false;
        //     inactivate();
        //     StartCoroutine(coroutine11);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        //     Invoke("activate",1.8f);
        // }
        // if(num==35){
        //     스킵.interactable=false;
        //     inactivate();
        //     StartCoroutine(coroutine12);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        //     Invoke("activate",1.8f);
        // }
        // if(num==38){
        //     StartCoroutine(coroutine13);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==41){
        //     StartCoroutine(coroutine14);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==44){
        //     StartCoroutine(coroutine15);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==47){
        //     StartCoroutine(coroutine16);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==50){
        //     StartCoroutine(coroutine17);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==53){
        //     StartCoroutine(coroutine18);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==56){
        //     SceneManager.LoadScene("4-2");
        //     num++;//activate button
        // }


    }
}
