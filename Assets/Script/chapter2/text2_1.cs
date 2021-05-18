using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text2_1 : MonoBehaviour
{
    public GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public GameObject fadeout;
    public static string message;
    public float m_Speed;
    private static int num=0;
    //시간지연
    private double timer = 0.0;
    private double waitingTime = 0.5;
    //B U T T O N
    public GameObject theonlychoice; //안방문을 연다(1개선택)
    //public Text theonlychoice_; //<안방문을 연다> 텍스트무효화 -> text를 gameobject안에 넣어도 되나?
    

    
    //private IEnumerator coroutine;
    //public Text generaltext;
    //아까 구글링한 방법
    //Coroutine coroutine_stop = StopCoroutine("Typing");
    
    
    private static string text_1="온기가 전혀 돌지 않는 \n안방이 서늘하다.\n반쯤 열린 창문 틈으로 \n무채색의 눈보라가 휘날린다.\n안방은 늘 그렇듯 \n기계적으로 정돈되어 있고, \n흐트러진 이부자리만이 \n사람의 흔적을 알린다.";
    private static string text_2 ="나는 안방에서 다시 한번 \n카라를 소리쳐 불렀지만,\n여전히 카라는 아무런 답이 없다.";
    private static string text_3 = "스마트홈 중앙 통제 시스템이\n어디에 있더라…….\n카라를 이식한 첫날 받은 \n사용 설명서에 적혀 있을 텐데.";
    private static string text_4 = "한참을 고민했지만, \n중앙 통제 시스템의 위치도,\n사용 설명서의 위치도 \n생각나지 않는다.\n누군가 기억을 \n깨끗하게 지워버린 것 같다.\n10년이 넘도록 \n스마트홈 인공지능에 \n익숙해진 탓이겠지.";
    private static string text_5 = "카라를 복구하려면 \n일단은 이 우중충한 안방을 \n어서 벗어나야 한다.";
    private static string text_6 = "\"철컥, 철컥\"\n\n예상과는 달리,\n거실로 나가는 문은 잠겨 있다.";
    private static string text_7 ="안방은 가장 보안이 \n삼엄한 공간이기 때문에 \n전자동 문이 고장 났을 경우 \n수동으로 빠져나갈 수 있도록 \n스페어 키를 서랍장에 넣어 놨다.\n번호 패드를 쓰는 방법도 있지만….\n그러려면 나사를 먼저 풀어야 한다.\n우선 서랍장을 조사해 봐야겠다.";




   // private static string text_6 
    
    //==========================================================================
    //코루틴함수 : Typing

    //scenario!
    static IEnumerator coroutine = Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    // static IEnumerator coroutine5 = Typing(text_6);
    //identifier : IEnumerator







//===============================================================================================================
    static IEnumerator Typing(string message)
    { 
        typingText=GameObject.Find("general text").GetComponent<Text>();
        
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
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면?
           
            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);
            //button_skip.onClick.AddListener(StopCoroutine(coroutine));
                // button_skip = transform.Find("skipButton").GetComponent<Button>() ;
                // button_skip.onClick.AddListener(StopCoroutine("Typing",text_1)) ;
                // Debug.Log("buttonisclicked");
            //     StopCoroutine("Typing");
            // }
            // else continue;
        
    } 

    public void theonlychoiceF(){
        //Debug.Log("you clicked <theonlybutton> num="+num);
        Debug.Log("철컥철컥  num"+num);
        StartCoroutine(coroutine5);
        num=30;
        Text theonlychoice_;
        theonlychoice_=GameObject.Find("theonlychoice_text").GetComponent<Text>();
        theonlychoice_.text=" "; //text-> 비우기
            //theonlychoice.text=" ";
        

    }
    
    public void coroutine_stop(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
        
    }


    //     button_skip.onClick.AddListener(StopCoroutine("Typing"));
    // }
    

    // cnt funtion set==========================================================
    //cnt앞에 자료형 int를 써주니까 아예 새로운 변수로 인식하는 것 같음 왜??
    // public void goout(){
    //     StopCoroutine("Typing");
    // }
    
    // public void cntup1(){
    //     cnt=100;   
    // }
    // private void cntup2(){
    //     cnt=200;
    // }
    // private void cntup3(){
    //     cnt = 300;
    // }
    // private void cntup4(){
    //     cnt = 400;
    // }
    // private void cntup5(){
    //     cnt=500;
    // }
    // private void cntup6(){
    //     cnt=600;
    // }
    // //========================================================
    // public void narr(){
    //     StartCoroutine("Typing",text_1);
    //     //인스턴스 만들기
    //    // mytyping = Typing(text_1);
    //     // m_Speed = 0.05f; 
    //     // m_Message="온기가 전혀 돌지 않는 \n안방이 서늘하다.\n반쯤 열린 창문 틈으로 \n무채색의 눈보라가 휘날린다.\n안방은 늘 그렇듯 \n기계적으로 정돈되어 있고, \n흐트러진 이부자리만이 \n사람의 흔적을 알린다."; 
    //     // generaltext.text=m_Message;
    //     // StartCoroutine(Typing(m_Message));
    //     Debug.Log("cntup1 실행");
    //     //Invoke("cntup1",6);
    // }
        
    // }
    // public void narr_0(){
    //     m_Speed = 0.05f; 
    //     m_Message="나는 안방에서 다시 한번 \n카라를 소리쳐 불렀지만,\n여전히 카라는 아무런 답이 없다."; 
    //     generaltext.text=m_Message;
    //     StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    //     Invoke("cntup2",4);
    // }
    // private void narr_1(){
    //     m_Speed = 0.05f; 
    //     m_Message="카라를 이식한 첫날 받은 \n사용 설명서에 적혀 있을 텐데.\n한참을 고민했지만, \n중앙 통제 시스템의 위치도, \n사용 설명서의 위치도\n생각나지 않는다.\n누군가 기억을 \n깨끗하게 지워버린 것 같다.\n10년이 넘도록 \n스마트홈 인공지능에 \n익숙해진 탓이겠지.";
    //     generaltext.text=m_Message;
    //     StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    //     Invoke("cntup3",5);
        
    // }
    // private void narr_2(){
    //     m_Speed = 0.05f; 
    //     m_Message="카라를 복구하려면 \n일단은 이 우중충한 안방을 \n어서 벗어나야 한다."; 
    //     generaltext.text=m_Message;
    //     StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    //     Invoke("cntup4",4);
    // }
    // private void narr_3(){
    //     m_Speed = 0.05f; 
    //     m_Message="\'철컥, 철컥\'\n\n\n예상과는 달리,\n 거실로 나가는 문은 잠겨 있다."; 
    //     generaltext.text=m_Message;
    //     StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    //     Invoke("cntup5",5);
    // }
    // private void narr_4(){
    //     m_Speed = 0.05f; 
    //     m_Message="안방은 가장 보안이 \n삼엄한 공간이기 때문에 \n전자동 문이 고장 났을 경우 \n수동으로 빠져나갈 수 있도록 \n스페어 키를 서랍장에 넣어 놨다.\n\n번호 패드를 쓰는 방법도 있지만…. \n그러려면 나사를 먼저 풀어야 한다. \n\n우선 서랍장을 조사해 봐야겠다."; 
    //     generaltext.text=m_Message;
    //     StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    //     Invoke("cntup6",6);
    // }
    
    // Start is called before the first frame update
    

    void Start()
    {
        
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            Debug.Log("coroutine1 is started!  num"+num);
            StartCoroutine(coroutine1); 
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine3 is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine3 is started!  num"+num);
            num++;
        }
        if(num==14){
            Debug.Log("<theonlychoice>버튼활성화  num"+num);
            theonlychoice.SetActive(true);//activate button
        }
        
        if(num==32){
            Debug.Log("coroutine6 is started+num"+num);
            StartCoroutine(coroutine6);
            fadeout.SetActive(true);
            
            

            
        }
       

    }
}
