using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1_3 : MonoBehaviour
{// Start is called before the first frame update
   public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    
    public static GameObject fadeout;
    //조사할 오브젝트
    public static GameObject sofa;
    public static GameObject table;
    public static GameObject speaker;
    public static GameObject decoration;
    public static GameObject walldeco;
    public static GameObject tv;
    public static GameObject another;
    

    public static Button sofa_b;
    public static Button table_b;
    public static Button speaker_b;
    public static Button decoration_b;
    public static Button walldeco_b;
    public static Button tv_b;
    public static Button another_b;
    public static Button achoice_b;
    public static Button bchoice_b;
    public static Button 스킵;

    public static Text sofa_t;
    public static Text table_t;
    public static Text speaker_t;
    public static Text decoration_t;
    public static Text walldeco_t;
    public static Text tv_t;
    public static Text another_t;
    public static Text achoice_t;
    public static Text bchoice_t;
    public static Text typingText;

    
    private static string text_1="소파 틈 사이에 \n구급상자가 있을 가능성은....\n전혀 없다.";
    private static string text_2="탁자 모서리 사이에 \n작은 네 개의 틈을 어루만졌다. \n플라네타리움을 놓기엔 \n적당하지만, \n구급상자를 두기엔 너무 좁다.";
    private static string text_3="쓸데없이 여기에 \n시간을 낭비하고 싶지는 않아.";
    private static string text_4="장식장 안에는 \n내가 수집한 자동차 모형만 \n늘어서 있다. \n1940년대 자동차부터 \n연대순으로 늘어놨는데 \n2030년대 모형만 \n행방이 묘연하다.\n\n사무실 위 책상에 \n둔 것 같긴 한데.....";
    private static string text_5="9개의 화분이 놓인 \n벽 장식이다. \n화분 때문에 구급상자가 \n있을 공간이 없다.";
    private static string text_6="지금은 TV를 볼 때가 \n아닌 것 같다.";
    private static string text_7="다른 곳도 둘러볼까?";
   

    static IEnumerator coroutine1 =  Typing(text_1);
    static IEnumerator coroutine2 =  Typing(text_2);
    static IEnumerator coroutine3 =  Typing(text_3);
    static IEnumerator coroutine4 =  Typing(text_4);
    static IEnumerator coroutine5 =  Typing(text_5);
    static IEnumerator coroutine6 =  Typing(text_6);
    static IEnumerator coroutine7 =  Typing(text_7);

    
   

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;

    }
    public void activate(){
        
        sofa_b.interactable=true;
        table_b.interactable=true;
        speaker_b.interactable=true;
        decoration_b.interactable=true;
        walldeco_b.interactable=true;
        tv_b.interactable=true;
        another_b.interactable=true;

        sofa_t.text="(1) 소파";
        table_t.text="(2) 탁자";
        speaker_t.text="(3) 스피커";
        decoration_t.text="(4) 장식장";
        walldeco_t.text="(5) 벽면 화분 장식";
        tv_t.text="(6) TV";
        another_t.text="(7) 다른 장소로 가본다.";
        
        
        
    }
    public void inactivate(){
        
        sofa_b.interactable=false;
        table_b.interactable=false;
        speaker_b.interactable=false;
        decoration_b.interactable=false;
        walldeco_b.interactable=false;
        tv_b.interactable=false;
        another_b.interactable=false;

        sofa_t.text=" ";
        table_t.text=" ";
        speaker_t.text=" ";
        decoration_t.text=" ";
        walldeco_t.text=" ";
        tv_t.text=" ";
        another_t.text=" ";}

    public void click_sofa(){
        스킵.interactable=false;
        num=2;
    }
    public void click_table(){
        스킵.interactable=false;
        num=5;
    }
    public void click_speaker(){
        스킵.interactable=false;
        num=8;
    }
    public void click_decoration(){
        num=11;
        스킵.interactable=false;
    }
    public void click_walldeco(){
        스킵.interactable=false;
        num=14;
    }
    public void click_tv(){
        스킵.interactable=false;
        num=17;
    }
    public void click_another(){
        스킵.interactable=false;
        num=20;
        
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
    sofa_b=GameObject.Find("sofa").GetComponent<Button>();
    table_b=GameObject.Find("table").GetComponent<Button>();
    speaker_b=GameObject.Find("speaker").GetComponent<Button>();
    decoration_b=GameObject.Find("decoration").GetComponent<Button>();
    walldeco_b=GameObject.Find("walldeco").GetComponent<Button>();
    tv_b=GameObject.Find("tv").GetComponent<Button>();
    another_b=GameObject.Find("another").GetComponent<Button>();
    achoice_b=GameObject.Find("achoice").GetComponent<Button>();
    bchoice_b=GameObject.Find("bchoice").GetComponent<Button>();
    

    sofa_t=GameObject.Find("sofatext").GetComponent<Text>();
    table_t=GameObject.Find("tabletext").GetComponent<Text>();
    speaker_t=GameObject.Find("speakertext").GetComponent<Text>();
    decoration_t=GameObject.Find("decorationtext").GetComponent<Text>();
    walldeco_t=GameObject.Find("walldecotext").GetComponent<Text>();
    tv_t=GameObject.Find("tvtext").GetComponent<Text>();
    another_t=GameObject.Find("anothertext").GetComponent<Text>();
    achoice_t=GameObject.Find("achoicetext").GetComponent<Text>();
    bchoice_t=GameObject.Find("bchoicetext").GetComponent<Text>();
    typingText=GameObject.Find("general text").GetComponent<Text>();


    //onclick -> function
    sofa_b.onClick.AddListener(click_sofa);
    table_b.onClick.AddListener(click_table);
    speaker_b.onClick.AddListener(click_speaker);
    decoration_b.onClick.AddListener(click_decoration);
    walldeco_b.onClick.AddListener(click_walldeco);
    tv_b.onClick.AddListener(click_tv);
    another_b.onClick.AddListener(click_another);

    achoice_b.onClick.AddListener(click_achoice);
    bchoice_b.onClick.AddListener(click_bchoice);

  }
    // Start is called before the first frame update
   void Start()
    {
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;

        sofa_b.interactable=true;
        table_b.interactable=true;
        speaker_b.interactable=true;
        decoration_b.interactable=true;
        walldeco_b.interactable=true;
        tv_b.interactable=true;
        another_b.interactable=true;
        achoice_b.interactable=false;
        bchoice_b.interactable=false;
        
        sofa_t.text="(1) 소파";
        table_t.text="(2) 탁자";
        speaker_t.text="(3) 스피커";
        decoration_t.text="(4) 장식장";
        walldeco_t.text="(5) 벽면 화분 장식";
        tv_t.text="(6) TV";
        another_t.text="(7) 다른 장소로 가본다.";

        achoice_t.text=" ";
        bchoice_t.text=" ";
        Debug.Log("coroutin is started! #6-1-3-> 거실 조사 num"+num);
        
        

    }

//     // Update is called once per frame
    void Update(){

        Debug.Log(num);
        if(num==2){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
            Invoke("activate",1.8f);
        }
        if(num==5){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            Invoke("activate",2.5f);
            
        }
        if(num==8){
            스킵.interactable=true;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
            Invoke("activate",1.8f);
            //closet text 출력시작 
            
        }
        if(num==11){
            inactivate();
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("activate",4.5f);
            
            
        }
        if(num==14){
            //(3)closet-3
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",2.5f);
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
            inactivate();
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("choiceAB_activate",1.8f);
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
