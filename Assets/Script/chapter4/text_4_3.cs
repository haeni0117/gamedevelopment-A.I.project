using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_4_3 : MonoBehaviour
{

  public static Text typingText;
  public static Text typingText2;
  public static Button 스킵;
  public static GameObject backbutton_;
  public static Button backbutton;
  public static Text backbuttont;





    public static int num = 0;
    public static GameObject fadeout;
    public static GameObject diary;
//(1)책상
    public static GameObject a;
    public static Button aB;
    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;
//(3)의지
    public static GameObject c;
    public static Button cB;
    public static Text ct;
//(4)iot쓰레기통
    public static GameObject d;
    public static Button dB;
    public static Text dt;
//(5)탁자
    public static GameObject e;
    public static Button eB;
    public static Text et;
    public static GameObject e1;
    public static Button e1B;
    public static Text e1t;
    public static GameObject e2;
    public static Button e2B;
    public static Text e2t;
    public static GameObject e3;
    public static Button e3B;
    public static Text e3t;
//(6)사이드테이블
    public static GameObject f;
    public static Button fB;
    public static Text ft;

    public static GameObject f1;
    public static Button f1B;
    public static Text f1t;

    public static GameObject f2;
    public static Button f2B;
    public static Text f2t;
//(7) 책장
    public static GameObject g;
    public static Button gB;
    public static Text gt;
//(8) 2층 베란다창문
    public static GameObject h;
    public static Button hB;
    public static Text ht;

//(8) a선택지 - 베란다 커튼을 걷어본다.
public static GameObject choice_a;
public static Button choice_aB;
public static Text choice_at;
//(8) b선택지 - 베란다 커튼을 걷어본다.
public static GameObject choice_b;
public static Button choice_bB;
public static Text choice_bt;




//     //string -> narration
    private static string text_00="아까부터 의수 쪽에서\n지속적인 잡음이 들리는데,\n이게 무슨 소리지?";
    private static string text_01="설마...고장 난 건 아니겠지?";
    private static string text_1="나는 시루를 품에 안고 \n재빨리 현관문으로 달렸다.";
    private static string text_2="'접근이 거절되었습니다'";
    private static string text_3="처음부터 열릴 거라고 \n기대하지 않았다. \n지금 이 집은 모든 문이 \n잠겨서 꼼짝도 하지 않으니까.\n통신은 먹통이고, \n전기는 수동으로 통제할 수 없다.\n자동 온도 조절 기능도 \n중단됐는지 점점 추워지는 게 느껴졌다. ";
    private static string text_4="시루를 안은 팔에 피가 \n묻어 비릿한 냄새가 났다.";
    private static string text_5="나는 계속해서 신경질적으로 \n문고리를 돌렸지만, \n세계 최초 3중 보안 시스템으로\n독신 여성에게 최적화된 \n안전을 제공한다는 \n자이나 사의 광고만 \n귓가에 맴돌았다.";
    private static string text_6="\"카라! 내 말 들려? \n아직 깨어있다면 제발 도와줘. \n\n카라....\"";
    private static string text_7="\"놀라워요. \n여기까지도 못 올 줄 알았는데. \n자, 이제 무엇을 도와드릴까요?\"";
    static IEnumerator coroutine0=  Typing(text_00);
    static IEnumerator coroutine1=  Typing(text_01);
    static IEnumerator coroutine2=  Typing(text_1);
    static IEnumerator coroutine3 = Typing(text_2);
    static IEnumerator coroutine4 = Typing(text_3);
    static IEnumerator coroutine5 = Typing(text_4);
    static IEnumerator coroutine6 = Typing(text_5);
    static IEnumerator coroutine7 = Typing(text_6);
    static IEnumerator coroutine8 = Typing(text_7);
    public static void scenechange(){
      SceneManager.LoadScene("4-5");
    }

    static IEnumerator Typing(string message)
    {
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
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
    
     public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
       
    }


  void Awake(){
    typingText = GameObject.Find("general text").GetComponent<Text>();
    스킵 = GameObject.Find("skipButton").GetComponent<Button>();
    스킵.onClick.AddListener(text_4_3.스킵버튼클릭);
    
    

  } 
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_4_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=true;//스킵비활성화
       
       //오브젝트 초기화
    //    at.text="* 베란다 문을 조사한다. ";
    //    bt.text="빨리 열어야 하는데 어쩌지?";
    //    ct.text="지금은 한시가 급하니까,\n의수를 사용해서 문을 부수자.";
    //    dt.text="문을 부수다가 의수가 망가지면 큰일이야. 다른 방법을 찾아보자.";
       //ct.text="A. 작업실로 이동";
       
    //    a.SetActive(false);
    //    b.SetActive(false);
    //   c.SetActive(false);
    //   d.SetActive(false);

    //    aB.interactable=true;
    //    bB.interactable=true;
    //    cB.interactable=true;
    //    dB.interactable=true;
       StartCoroutine(coroutine0);

        Debug.Log("coroutin is started! #4-3 num"+num);
        


    }

//     // Update is called once per frame
    void Update(){
      Debug.Log(num);
        //Debug.Log(num);
        
        
        if(num==2){
            StartCoroutine(coroutine1);
            스킵.interactable=true;
            num++;
        }
      
        if(num==5){
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            StartCoroutine(coroutine3);
            num++;
            

        }
    
        
        
        if(num==11){
            
            StartCoroutine(coroutine4);//역시나 잠겨있다~

            num++;
        }
        
        if(num==14){
            
            StartCoroutine(coroutine5);
             num++;
            
        }//choice -> 2개

        if(num==17){
            StartCoroutine(coroutine6);
            num++;//activate button
        }
        if(num==20){
            StartCoroutine(coroutine7);
            num++;
        }
       
        if(num==23){
            StartCoroutine(coroutine8);
            num++;//activate button
        }
        
        if(num==25){
            scenechange();
        }
       
        
    }
}
