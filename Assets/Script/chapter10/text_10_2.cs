using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_10_2: MonoBehaviour
{
    public static Button 스킵 ;
    
    static IEnumerator Typing(string message)
    { 
        
        Debug.Log("typingtext"+typingText);
        Debug.Log("message"+message);
        
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
    
    public static GameObject a;
    public static Button aB;

    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;

    public static GameObject a1;
    public static Button a1B;
    public static Text a1t;
//(2)반려동물 방석
    public static GameObject b1;
    public static Button b1B;
    public static Text b1t;

    public static GameObject a2;
    public static Button a2B;
    public static Text a2t;
//(2)반려동물 방석
    public static GameObject b2;
    public static Button b2B;
    public static Text b2t;
    public static Text typingText;
//(3)의지
    public static GameObject c;
    public static Button cB;
    public static Text ct;
//(4)iot쓰레기통
    public static GameObject d;
    public static Button dB;
    public static Text dt;
    public static GameObject choice;
    public static Button choiceB;
    public static Text choicet;

    public static GameObject choice1;
    public static Button choice1B;
    public static Text choice1t;

     public static GameObject e;
    public static Button eB;
    public static Text et;
     public static GameObject f;
    public static Button fB;
    public static Text ft;

    //basic component
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    
    public static GameObject fadeout;
    public static bool a_inspection=false;
    public static bool b_inspection=false;
    public static bool c_inspection=false;



    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
        
    }
    public static void 활성화(){
        if(a_inspection==false){
            aB.interactable=true;
        }else aB.interactable=false;
        if(b_inspection==false){
            bB.interactable=true;
        }else bB.interactable=false;
        if(c_inspection==false){
            cB.interactable=true;
        }else cB.interactable=false;
    }
    public static void a활성화(){
        a_inspection=true;
        num=2;
    }
    public static void a1활성화(){
        num=14;
    }
    public static void a2활성화(){
        num=23;
    }
    public static void b활성화(){
        b_inspection=true;
        num=26;
    }
    public static void c활성화(){
        c_inspection=true;
        num=29;
    }
    
    

    //(1)의수보관함 조사
    private static string text_1="2층 창고 진열대에 \n이전 버전의 사라들이 \n고이 잠들어 있다.\n크기별로 진열된 의수들이 \n나를 손가락질 하는 것만 같다.";
    private static string text_2= "이러려고 모아둔 게 아닌데.....\n나는 죄책감을 떨치기 위해\n눈을 질끈 감고 \n아무 의수나 집어 들었다.";
    private static string text_3="{구버전 의수를 획득했다}";
    private static string text_4="여기서 구버전 사라가 들어있는 \n코어를 꺼내야 한다.";
    private static string text_5="{구버전 의수와 드라이브를 조합했다}\n{AI 코어를 획득했다}";
    private static string text_6="손바닥 정 가운데를 \n꾹 누르니 달칵, 소리와 함께 \n코어가 튀어나왔다. \n영문도 모른 채 93% 확률의 \n죽음을 맞이할 희생양이었다.\n코어 옆에 꽂혀 있던 드라이브는 \n탈출할 때를 대비해 \n간직하기로 했다.";
    private static string text_7="코어를 얻었으니 작업실로 가서\n컴퓨터에 연결하자.";
    //(2)금고조사
    private static string text_8="의수의 커버을 \n열어보려 했지만, \n열리지 않는다.\n도구를 사용해 보자 ";
    //(3)철제 서랍장 조사
    private static string text_9= "스마트 키가 없어서 \n여전히 열 수 없다";
    private static string text_10= "의수 설명서가 들어있던 \n서랍장이다.\n다른 곳은 모두 텅 비어있다. ";
    

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5=  Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7=  Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);
   
   

     
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_10_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        스킵.interactable=false;
        
        //a. 의수보관함 조사
        a = GameObject.Find("a");
        aB =a.GetComponent<Button>();
        at = GameObject.Find("aText").GetComponent<Text>();
        at.text="(1) 의수보관함조사";
        aB.interactable=true;
        aB.onClick.AddListener(text_10_2.a활성화);

        a1 = GameObject.Find("a1");
        a1B =a1.GetComponent<Button>();
        a1t = GameObject.Find("a1Text").GetComponent<Text>();
        a1t.text="구버전 의수+드라이브 = \n‘드라이브’, ‘AI코어’ 획득";
        a1B.interactable=true;
        a1B.onClick.AddListener(text_10_2.a1활성화);

        a2 = GameObject.Find("a2");
        a2B =a2.GetComponent<Button>();
        a2t = GameObject.Find("a2Text").GetComponent<Text>();
        a2t.text="구버전 의수를 분해하려 할 시";
        a2B.interactable=true;
        a2B.onClick.AddListener(text_10_2.a2활성화);


        //b. 2층베란다로 간다. -> 비활성화
        b = GameObject.Find("b");
        bB =b.GetComponent<Button>();
        bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="(2) 금고조사 ";
        bB.interactable=true;
        bB.onClick.AddListener(text_10_2.b활성화);   

        //c. 철제서랍장조사
        c = GameObject.Find("c");
        cB =c.GetComponent<Button>();
        ct = GameObject.Find("cText").GetComponent<Text>();
        ct.text="(3) 철제 서랍장 조사";
        cB.interactable=true;
        cB.onClick.AddListener(text_10_2.c활성화);

        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        a1.SetActive(false);
        a2.SetActive(false);
        typingText = GameObject.Find("general text").GetComponent<Text>();

        

        
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(num);
        if(num==2){
            //(1)의수 보관함 조사 선택 -> skip 비활성화
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            StartCoroutine(coroutine);
            스킵.interactable=true;
            num++;

            //skip is activated
            

            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine3);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=false;
        }
        if(num==13){
            a1.SetActive(true);
            a2.SetActive(true);
            typingText.text=" ";
        }
         if(num==14){
            a1.SetActive(false);
            a2.SetActive(false);
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine4);
            num++;
            스킵.interactable=true;
        }
        if(num==17){
            StartCoroutine(coroutine5);
            num++;
            스킵.interactable=true;
        }
        if(num==20){
            StartCoroutine(coroutine6);
            스킵.interactable=false;
            Debug.Log("coroutine is started!  num"+num);
            num++;

        }
        if(num==22){
            SceneManager.LoadScene("10-3");
            스킵.interactable=false;
        }
        if(num==23){
            a1.SetActive(false);
            a2.SetActive(false);
            StartCoroutine(coroutine7);
            스킵.interactable=false;
            
            num++;//activate button
        }
        if(num==25){
            a1.SetActive(true);
            a2.SetActive(true);
            typingText.text=" ";
            a2B.interactable=false;
            스킵.interactable=false;
        }
        if(num==26){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            StartCoroutine(coroutine8);
            스킵.interactable=false;
            num++;//activate button

        }
        if(num==28){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            활성화();
            스킵.interactable=false;
            typingText.text=" ";
            num++;//activate button

        }
        if(num==29){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            StartCoroutine(coroutine9);
            num++;//activate button

        }
        if(num==31){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            활성화();
            typingText.text=" ";
            num++;//activate button

        }
        
        
        
    }
}
