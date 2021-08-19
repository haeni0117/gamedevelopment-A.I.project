using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_3_4 : MonoBehaviour
{

  public static Text typingText;
  public static Text typingText2;
  public static Button 스킵;
  public static GameObject backbutton_;
  public static Button backbutton;
  public static Text backbuttont;

  //bool-> 오브젝트 조사여부
  public static bool a_inspection2=false;
  public static bool b_inspection2=false;
  public static bool c_inspection2=false;
  public static bool d_inspection2=false;
  public static bool e_inspection2=false;
  public static bool f_inspection2=false;
  public static bool g_inspection2=false;
  public static bool h_inspection2=false;
  public static bool f1_inspection2=false;
  public static bool f2_inspection2=false;
  public static bool e1_inspection2=false;
  public static bool e2_inspection2=false;
  public static bool e3_inspection2=false;



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
    private static string text_00="\"시루....시루야! 어디 있어!\"\n2층 베란다에도 \n시루가 보이지 않는다. \n울음소리는 점점 더 커지는데 \n도대체 어디 있는 거야….";
    private static string text_01="시루다. \n시루는 1층 베란다의 \n차가운 타일 바닥에 \n웅크리고 앉아 울고 있다.\n시루의 노란색 귀는 \n축 처져 힘이 없다.";
    private static string text_1="그러고 보니 마지막 사료를 \n준 지도 한참이 지났다.\n원래라면 자동 사료 급수기에서 \n밥을 먹었겠지만…";
    private static string text_2="베란다에 언제부터 \n갇혀 있었는지 알 수 없으니 \n한참을 굶었을 수도 있다.\n어서 시루를 구해야 한다.";
    private static string text_3="1층 베란다로 내려가 보자.";
    private static string text_4="이건 지문 인식으로 \n열리는 문이라 \n잠겨서 열리지 않으면 곤란한데….";
    private static string text_5="지문 인식 장치에 \n검지를 \n올려놓았다.";
    private static string text_6="\"열렸다!\"";
    private static string text_7="다행히 작업실 문은 \n잠기지 않은 것 같다.\n\n어서 내려가 보자.";
    static IEnumerator coroutine0=  Typing(text_00);
    static IEnumerator coroutine1=  Typing(text_01);
    static IEnumerator coroutine2=  Typing(text_1);
    static IEnumerator coroutine3 = Typing(text_2);
    static IEnumerator coroutine4 = Typing(text_3);
    static IEnumerator coroutine5 = Typing(text_4);
    static IEnumerator coroutine6 = Typing(text_5);
    static IEnumerator coroutine7 = Typing(text_6);
    static IEnumerator coroutine8 = Typing(text_7);
  
    public static void a활성화(){
      num=2;
      스킵.interactable=false;
    }
    public static void b활성화(){
      num=17;
      스킵.interactable=false;
    }
    public static void c활성화(){
      num=20;
      스킵.interactable=false;
    }
    public static void scenechange(){
      SceneManager.LoadScene("4-1");
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
    static IEnumerator Typing2(string message)
    {
        Text typingText = GameObject.Find("general text2").GetComponent<Text>();
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
    스킵.onClick.AddListener(text_3_4.스킵버튼클릭);
    
    a = GameObject.Find("a");
    aB =a.GetComponent<Button>();
    at = GameObject.Find("aText").GetComponent<Text>();
    aB.onClick.AddListener(a활성화);

    b = GameObject.Find("b");
    bB =b.GetComponent<Button>();
    bt = GameObject.Find("bText").GetComponent<Text>();
    bB.onClick.AddListener(b활성화);

    c= GameObject.Find("c");
    cB =c.GetComponent<Button>();
    ct = GameObject.Find("cText").GetComponent<Text>();
    cB.onClick.AddListener(c활성화);

  } 
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_3_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;//스킵비활성화
       
       //오브젝트 초기화
       at.text="A. 2층 베란다로 들어간다.";
       bt.text="A. 작업실로 이동";
       ct.text="A. 작업실로 이동";
       
       a.SetActive(true);
       b.SetActive(false);
      c.SetActive(false);

       aB.interactable=true;
       bB.interactable=true;
       cB.interactable=true;
       

        Debug.Log("coroutin is started! #3-4 num"+num);
        


    }

//     // Update is called once per frame
    void Update(){
      Debug.Log(num);
        //Debug.Log(num);
        
        
        if(num==2){
            Debug.Log("[A. 2층 베란다로 들어간다.]");
            StartCoroutine(coroutine0);
            a.SetActive(false);
            스킵.interactable=true;
            num++;
        }
      
        if(num==5){
            StartCoroutine(coroutine1);
            num++;
        }
        if(num==8){
            StartCoroutine(coroutine2);
            num++;
        }
    
        if(num==11){
            StartCoroutine(coroutine3);
            num++;
        }
        
        if(num==14){
          //(5) 탁자
            StartCoroutine(coroutine4);
            num++;//activate button
            스킵.interactable=false;
        }
        if(num==16){
            b.SetActive(true);
            Debug.Log("[A. 작업실로 이동]");
            스킵.interactable=false;
        

        }
//(5)-1 인공지능 계급론
        if(num==17){
            StartCoroutine(coroutine5);
            num++;//activate button
            스킵.interactable=false;
            b.SetActive(false);
        }
        if(num==19){
            Debug.Log("[작업실 문을 조사한다.]");
            c.SetActive(true);
            //activate button
            스킵.interactable=false;
        }
        if(num==20){
           c.SetActive(false);
            스킵.interactable=true;
            StartCoroutine(coroutine6);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine7);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==26){
            StartCoroutine(coroutine8);
            num++;//activate button
            스킵.interactable=false;
        }
        if(num==28){
            Debug.Log("scenechange");
            scenechange();
        }
        
    }
}
