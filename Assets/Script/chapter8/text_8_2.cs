using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//7.5 #5 사라와 대화

public class text_8_2 : MonoBehaviour
{
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

    public static GameObject a;
    public static Button aB;
    public static Button 스킵;
    public static Text at;
    public static GameObject choice;
    public static Button choiceB;
    public static Text choicet;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;
    public static GameObject c;
    public static Button cB;
    public static Text ct;
//(4)iot쓰레기통
    public static GameObject d;
    public static Button dB;
    public static Text dt;

    
    public static bool a_inspection=false;
    public static bool b_inspection= false;
    public static bool c_inspection= false;
    public static bool d_inspection= false;
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
        if(d_inspection==false){
            dB.interactable=true;
        }else dB.interactable=false;
        // if(e_inspection==false){
        //     eB.interactable=true;
        // }else eB.interactable=false;
        // if(f_inspection==false){
        //     fB.interactable=true;
        // }else fB.interactable=false;
    }

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    private static string text_1="뭔가 이상해....\n분명히 아까 집 안의 모든 \n통신이 다 끊긴 걸 확인했는데 \n갑자기 전화가 온다니?\n계단 앞에서 시루가 날카롭게 \n울기 시작했다.\n마치 내려가지 말라고 나를 \n말리는 것처럼.";
    private static string text_2="도대체 무슨 냄새일까?\n직접 내려가 보지 않더라도 \n1층을 살펴볼 수 있으면 좋을 텐데.....";
    private static string text_3="책상 위에는 쓸 만한 것이 없다.";
    private static string text_4="1층에 방석이라도 던져 볼까...?";
    private static string text_5="책과 의수 부품뿐이다. \n이걸로는 아무것도 할 수 없어.";


    private static string text_6="시루를 구하느라 정신이 없어서 \n베란다를 살펴보지 않았다. \n쓸만한 것이 있으려나?";
    
    
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    
    // static IEnumerator coroutine13 = Typing(text_14);
    // static IEnumerator coroutine14 = Typing(text_15);
    // static IEnumerator coroutine15 = Typing(text_16);
    // static IEnumerator coroutine16 = Typing(text_17);
    // static IEnumerator coroutine17 = Typing(text_18);
    // static IEnumerator coroutine18 = Typing(text_19);
    // static IEnumerator coroutine19 = Typing(text_20);
    // static IEnumerator coroutine20 = Typing(text_21);       
    // static IEnumerator coroutine21 = Typing(text_22);
    // static IEnumerator coroutine22 = Typing(text_23);       
    // static IEnumerator coroutine23 = Typing(text_24);
    // static IEnumerator coroutine24 = Typing(text_25);
    // static IEnumerator coroutine25 = Typing(text_26);
    // static IEnumerator coroutine26 = Typing(text_27);
    // static IEnumerator coroutine27 = Typing(text_28);
    public static void a활성화(){
        num=8;
       
    }
    public static void b활성화(){
        num=11;
    }
    public static void c활성화(){
        num=14;
    }
    public static void d활성화(){
        num=17;
    }
    public static void choice활성화(){
        num=5;
    }
    






    // Start is called before the first frame update
    void Start()
    {
        typingText = GameObject.Find("general text").GetComponent<Text>();
        // FadeOut(1.0f);
        // Debug.Log("fadein : awake function");
        a = GameObject.Find("a");
        aB =a.GetComponent<Button>();
        at = GameObject.Find("aText").GetComponent<Text>();
        aB.onClick.AddListener(a활성화);

        b = GameObject.Find("b");
        bB =b.GetComponent<Button>();
        bt = GameObject.Find("bText").GetComponent<Text>();
        bB.onClick.AddListener(b활성화);

        c = GameObject.Find("c");
        cB =c.GetComponent<Button>();
        ct = GameObject.Find("cText").GetComponent<Text>();
        cB.onClick.AddListener(c활성화);

        d = GameObject.Find("d");
        dB =d.GetComponent<Button>();
        dt = GameObject.Find("dText").GetComponent<Text>();
        dB.onClick.AddListener(d활성화);

        스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.

        choice = GameObject.Find("choice");
        choiceB =choice.GetComponent<Button>();
        choicet = GameObject.Find("choiceText").GetComponent<Text>();
        choiceB.onClick.AddListener(choice활성화);


        Debug.Log("coroutin is started! #3-1 num"+num);
        StartCoroutine(coroutine);
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        choice.SetActive(false);
        스킵.interactable=true;

        at.text="A. 안방으로 간다.";
        bt.text="B. 안방 화장실로 간다.";
        ct.text="C. 주방으로 간다.";
        dt.text="D. 거실로 간다.";
        choicet.text="1. 작업실을 다시 한 번 살펴보자";
        
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
           StartCoroutine(coroutine1);
            num++;
            스킵.interactable=false;

           
            //StartCoroutine(coroutine1);
        }
        if(num==4){
            choice.SetActive(true);
            스킵.interactable=false;
            
        }
        if(num==5){
            choice.SetActive(false);
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
            Debug.Log("choice_show");
            스킵.interactable=false;
            
            
        }
        if(num==8){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine2);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=false;
        }
        if(num==10){
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
        }
        if(num==11){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine3);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=false;
        }
        if(num==13){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
        }
        if(num==14){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=false;
        }
        if(num==16){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            스킵.interactable=false;
            typingText.text=" ";
        }
        if(num==17){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=false;
        }
        if(num==19){
            SceneManager.LoadScene("8-3");
        }
        
        
       
        
        

    }
}
