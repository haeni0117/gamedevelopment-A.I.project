using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_10_3: MonoBehaviour
{
    public static Button 스킵 ;
    
    static IEnumerator Typing(string message)
    { 
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
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

    //basic component
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;


    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
        
    }
    public static void a활성화(){
        num=2;
    }
    public static void b활성화(){
        num=5;
    }
    public static void c활성화(){
        num=8;
    }
    public static void d활성화(){
        SceneManager.LoadScene("10-4");
    }
    
    

    //(1)의수보관함 조사
    private static string text_1="완전히 부서져서 조각난 \n부품들이 바닥에 나뒹굴었다.\n밟지 않도록 조심해야지. ";
    private static string text_2= "시루가 자고 있다. \n빨리 탈출해야 하는데….\n손바닥이 축축해지고 \n가슴이 답답하다. ";
    private static string text_3="해가 옅어지고 있다. \n밤이 오기 전에 이곳을 \n빠져나가야 한다.";
    private static string text_4="여기서 구버전 사라가 들어있는 \n코어를 꺼내야 한다.";
    private static string text_5="{예전 의수와 드라이브를 조합했다}\n{AI 코어를 획득했다}";
    private static string text_6="손바닥 정 가운데를 \n꾹 누르니 달칵, 소리와 함께 \n코어가 튀어나왔다. \n영문도 모른 채 93% 확률의 \n죽음을 맞이할 희생양이었다.\n코어 옆에 꽂혀 있던 드라이브는 \n탈출할 때를 대비해 \n간직하기로 했다.";
    private static string text_7="코어를 얻었으니 작업실로 가서\n컴퓨터에 연결하자.";
    //(2)금고조사
    private static string text_8="스마트 키가 없어서 \n여전히 열 수 없다. ";
    //(3)철제 서랍장 조사
    private static string text_9= "의수 설명서가 들어있던 \n서랍장이다.\n다른 곳은 모두 텅 비어있다. ";
    
    

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5=  Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7=  Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
   
   

     
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_10_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        스킵.interactable=false;
        
        //(1) 의자 조사
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="(1) 의자 조사";
        aB.interactable=true;
        aB.onClick.AddListener(text_10_3.a활성화);


        //(2) 반려동물 방석 조사 
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="(2) 반려동물 방석 조사";
        bB.interactable=true;
        bB.onClick.AddListener(text_10_3.b활성화);   

        //(3) 2층 베란다 창문 조사
        GameObject c = GameObject.Find("c");
        Button cB =c.GetComponent<Button>();
        Text ct = GameObject.Find("cText").GetComponent<Text>();
        ct.text="(3) 2층 베란다 창문 조사";
        cB.interactable=true;
        cB.onClick.AddListener(text_10_3.c활성화);

        //(4) 작업실 컴퓨터 조사
        GameObject d = GameObject.Find("d");
        Button dB =d.GetComponent<Button>();
        Text dt = GameObject.Find("dText").GetComponent<Text>();
        dt.text="(4) 작업실 컴퓨터 조사";
        dB.interactable=true;
        dB.onClick.AddListener(text_10_3.d활성화);

        

        
    }
    // Update is called once per frame
    void Update()
    
    {
        Debug.Log(num);
        if(num==2){
            //(1)의자 조사 
            StartCoroutine(coroutine);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){//(2)반려동물 방석 조사
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
        }
        if(num==8){//(3)2층 베란다 창문 조사 
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        
       
        
        
    }
}
