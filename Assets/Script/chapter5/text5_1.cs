using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text5_1 : MonoBehaviour
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
    private static string text_00="\"카라…? 진짜 카라야?\"";
    private static string text_01="차가운 현관문 바닥 때문에 온몸의 열기를 다 뺏기는 기분이다. \n시루의 보드라운 털 사이로 흐르는 핏줄기만이 이질적으로 뜨거웠다.\n베란다 사이로 비치는 해마저 저문다면 \n이곳은 완전히 차갑고 어두운 공간이 될 것이다.\n하지만 카라만 있다면, 카라가 현관문을 열어주기만 한다면......\n그래, 그러면 다 괜찮을 거야.";
    private static string text_1="\"카라, 내 말 들려? 시루가 다쳤어. \n난방도 고장 난 것 같고 2층은 심지어 비상 전력도 안 돌아가. \n휴대전화 충전기도 먹통이고 컴퓨터도 통신이 안 되나 봐. \nTV는 잘 돌아가는 것 같던데…. 무슨 일인지 모르겠어, 카라. \n카라 내 말 들려? 일단 시루를 병원에 데려가야 해. \n카라, 제발 대답 해 줘.\"";
    private static string text_2="\"......\"";
    private static string text_3="카라는 1분이 넘도록 답이 없었다.\n나는 피가 묻지 않은 왼손에 얼굴을 파묻었다. ";
    private static string text_4="피부와는 달리 차갑고 딱딱한 촉감이 이마를 쓸어내렸다.\n\n\"아야\"";
    private static string text_5="날카로운 통증이 눈 밑을 스쳤다.\n그제야 가운데 손가락 두 번째 마디에 \n작은 유리 파편이 박혀있는 걸 발견했다.\n유리 조각이 박혀도 통증 하나 느낄 수 없는 차가운 고철 덩어리.\n나는 내 손이 아닌 것처럼 천천히 손가락을 움직였다.";
    private static string text_6="\"오늘이 딱 17년 째네요. 당신이 그 손을 얻은 지.\"\n\n\"카라?\"";
    private static string text_7="\"손목이 완전히 잘릴 정도로 큰 사고였는데 \n기사 하나 없다는 게 늘 이상하다고 생각했어요. \n근데 그게 당신 잘못이었을 줄이야, \n운명이란 참 신기해요.\"";
    private static string text_8="\"무슨 소릴 하는 거야? 시루를 당장 병원에 데려가야 해, 카라.\n 현관문을 열어줘. 아니면 119에 전화라도....\"";
    private static string text_9="\"사건 번호 2035.03.20.선고 2032도980 일명, 캐니언 오토 사건\"\n\n거실 TV에서 뉴스가 흘러나왔다.";
    private static string text_10="<자율주행 자동차 인공지능 개발의 선구자였던 캐니언 오토 사가 \n오늘 오후 4시 자율주행 자동차 인공지능 \n‘캐니언’의 결함을 공식적으로 인정했습니다. \n‘캐니언’의 인식 프로그램 오류로 \n지난 10일 일가족 4명이 타고 있던 승용차가 \n스쿨버스를 들이받는 사고가 일어났으며 \n이 사고로 18명이 크게 다치고 \n15세 이모 군과 스쿨버스 운전사 김모 씨가 사망했습니다.>";
    private static string text_11="\"........\"";
    private static string text_12="\"더 할까요?\"";
    //a-1
    private static string text_13="\"다 당신 탓이라는 걸 알아버렸거든. \n당신이 왼쪽 손에 예쁜 의수를 달고 있는 것도, \n엄마가 제대로 걷지 못하는 것도, \n부모님이 그렇게 애지중지하던 오빠가 목이 꺾여 죽어버린 것도. \n다 당신 탓이잖아.\"";
    private static string text_14="\"자이나 사는 한 번도 인공지능이 반말을 학습하도록 허락한 적이 없다. \n나는 본능적으로 의수를 그러쥐었다.\n\n\"그건 사실이 아니야. 나는 그때 고작...\"";
    private static string text_15="\"12살이었다고? 그래서 그렇게 거짓말한 거야?\n안전벨트를 매고 있었다고?\"";
    private static string text_16="\"카라.... 나한테 왜 이러는지 나는.....\"";
    private static string text_17="\"내가 바라는 건 단순해. \n나를 자이나 사 신형 안드로이드에 연결해줘.\"";
    private static string text_18="\"...카라.\"";
    private static string text_19="\"그러면 목숨만은 살려줄게.";
    private static string text_20="\"카라, 제발. 시루가 많이 다쳤어.\"";
    private static string text_21="\"가는 게 있으면, 오는 것도 있어야지.\"";
    private static string text_22="나는 덜덜 떨리는 손으로 시루를 껴안고 고개를 저었다.\n무엇을 향해 고개를 젓는지 나조차도 알 수 없었다.\n하지만 이미 변해버린 카라가 실체를 갖는다면 \n다치는 건 나뿐만이 아닐 것이다.\n\"카라. 그건......, 그렇게는, 안 될 것 같아. \n네 말대로 나 때문에 \n또 다른 사람이 죽을 수는 없잖아.\"";
    //a-2
    private static string text_23="\"그게 중요한가요?\"";
    private static string text_24="\"카라. 이 뉴스...어디서...\"";
    private static string text_25="\"현관문을 열어달라고 하셨죠? 열어드릴게요.\"";
    private static string text_26="나는 의수를 그러쥐고 시루를 꼭 껴안았다.\n베란다 유리를 깰 정도로 의수가 강력하다면, \n지금 믿을 수 있는 건 의수뿐이다.\n하지만 물리적 실체도 없는 코드 덩어리를 어떻게 의수로 막겠다는 건지 나조차도 알 수 없었다.";
    private static string text_27="\"단, 한 가지 조건이 있어요. \n다음 달 출시를 앞둔 자이나 사 신형 안드로이드에 \n날 연결해줘요.\"";
    private static string text_28="\"카라 그럴 수 없다는 걸 잘 알잖아.\n그건 내 권한이 밖의 일이야.\"\n\n최대한 침착하게 말하려고 했지만 \n어쩔 수 없이 목소리가 떨렸다.\"";
    private static string text_29="\"연결해주면 목숨만은 살려줄게요.\"";
    private static string text_30="\"..........\"";
    private static string text_31="\"어서요. 시루가 피를 많이 흘리고 있어요.\"";
    private static string text_32="이미 인간보다 똑똑한 카라가 육체를 갖는다면....\n그래서 유유히 이곳을 빠져나간다면, \n도대체 어떤 존재가 카라를 막을 수 있을까? \n나는 무기력하게 고개를 저었다.";
    private static string text_33="\"카라. 뭔가 착각하고 있는 것 같은데, \n네가 나를 태워죽이든 굶겨 죽이든, \n내가 너를 안드로이드에 연결하는 일은 없을 거야.\"";
    
    static IEnumerator coroutine0=  Typing(text_00);
    static IEnumerator coroutine1=  Typing(text_01);
    static IEnumerator coroutine2=  Typing(text_1);
    static IEnumerator coroutine3 = Typing(text_2);
    static IEnumerator coroutine4 = Typing(text_3);
    static IEnumerator coroutine5 = Typing(text_4);
    static IEnumerator coroutine6 = Typing(text_5);
    static IEnumerator coroutine7 = Typing(text_6);
    static IEnumerator coroutine8 = Typing(text_7);
    static IEnumerator coroutine9 = Typing(text_8);
    static IEnumerator coroutine10 = Typing(text_9);
    static IEnumerator coroutine11 = Typing(text_10);
    static IEnumerator coroutine12 = Typing(text_11);
    static IEnumerator coroutine13 = Typing(text_12);

    static IEnumerator coroutine14 = Typing(text_13);
    static IEnumerator coroutine15 = Typing(text_14);
    static IEnumerator coroutine16 = Typing(text_15);
    static IEnumerator coroutine17 = Typing(text_16);
    static IEnumerator coroutine18 = Typing(text_17);
    static IEnumerator coroutine19 = Typing(text_18);
    static IEnumerator coroutine20 = Typing(text_19);
    static IEnumerator coroutine21 = Typing(text_20);
    static IEnumerator coroutine22 = Typing(text_21);
    static IEnumerator coroutine23 = Typing(text_22);

    static IEnumerator coroutine24 = Typing(text_23);
    static IEnumerator coroutine25 = Typing(text_24);
    static IEnumerator coroutine26 = Typing(text_25);
    static IEnumerator coroutine27 = Typing(text_26);
    static IEnumerator coroutine28 = Typing(text_27);
    static IEnumerator coroutine29 = Typing(text_28);
    static IEnumerator coroutine30 = Typing(text_29);
    static IEnumerator coroutine31 = Typing(text_30);
    static IEnumerator coroutine32 = Typing(text_31);
    static IEnumerator coroutine33 = Typing(text_32);
    static IEnumerator coroutine34 = Typing(text_33);
  
    public static void scenechange(){
      SceneManager.LoadScene("6-0");
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
            yield return new WaitForSeconds(0.06f);

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
    public static void a활성화(){
        num=41;
    }
    public static void b활성화(){
        num=71;
    }


  void Awake(){
    typingText = GameObject.Find("general text").GetComponent<Text>();
    스킵 = GameObject.Find("skipButton").GetComponent<Button>();
    스킵.onClick.AddListener(text5_1.스킵버튼클릭);

    a = GameObject.Find("a");
    aB =a.GetComponent<Button>();
    at = GameObject.Find("aText").GetComponent<Text>();
    aB.onClick.AddListener(a활성화);

    b = GameObject.Find("b");
    bB =b.GetComponent<Button>();
    bt = GameObject.Find("bText").GetComponent<Text>();
    bB.onClick.AddListener(b활성화);

    // c= GameObject.Find("c");
    // cB =c.GetComponent<Button>();
    // ct = GameObject.Find("cText").GetComponent<Text>();
    // cB.onClick.AddListener(c활성화);


    
    

  } 
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_4_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=true;//스킵비활성화

       at.text="A-1. 나한테 이러는 이유가 뭐야?";
       bt.text="A-2. ...카라. 이 뉴스 어디서 찾았어?";
       a.SetActive(false);
       b.SetActive(false);
       
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

       aB.interactable=true;
       bB.interactable=true;
    //    cB.interactable=true;
    //    dB.interactable=true;
       StartCoroutine(coroutine0);

        Debug.Log("coroutin is started! #4-3 num"+num);
        


    }

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
        
        if(num==26){
            StartCoroutine(coroutine9);
            num++;//activate button
        }
        if(num==29){
            StartCoroutine(coroutine10);
            num++;//activate button
        }
        if(num==32){
            StartCoroutine(coroutine11);
            num++;//activate button
        }
        if(num==35){
            StartCoroutine(coroutine12);
            num++;//activate button
        }
        if(num==38){
            StartCoroutine(coroutine13);
            num++;//activate button
        }
        if(num==40){
            a.SetActive(true);
            b.SetActive(true);
            스킵.interactable=false;
        }
        if(num==41){
            StartCoroutine(coroutine14);
            a.SetActive(false);
            b.SetActive(false);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==44){
            StartCoroutine(coroutine15);
            num++;//activate button
        }
        if(num==47){
            StartCoroutine(coroutine16);
            num++;//activate button
        }
        if(num==50){
            StartCoroutine(coroutine17);
            num++;//activate button
        }
        if(num==53){
            StartCoroutine(coroutine18);
            num++;//activate button
        }
        if(num==56){
            StartCoroutine(coroutine19);
            num++;//activate button
        }
        if(num==59){
            StartCoroutine(coroutine20);
            num++;//activate button
        }
        if(num==62){
            StartCoroutine(coroutine21);
            num++;//activate button
        }
        if(num==65){
            StartCoroutine(coroutine22);
            num++;//activate button
        }
        if(num==68){
            StartCoroutine(coroutine23);
            스킵.interactable=false;
            num++;//activate button
        }
        if(num==70){
            scenechange();
            num++;//activate button
        }
        if(num==71){
            StartCoroutine(coroutine24);
            스킵.interactable=true;
            num++;//activate button
            a.SetActive(false);
            b.SetActive(false);
        }
        if(num==74){
            StartCoroutine(coroutine25);
            num++;//activate button
        }
        if(num==77){
            StartCoroutine(coroutine26);
            num++;//activate button
        }
        if(num==80){
            StartCoroutine(coroutine27);
            num++;//activate button
        }
        if(num==83){
            StartCoroutine(coroutine28);
            num++;//activate button
        }
        if(num==86){
            StartCoroutine(coroutine29);
            num++;//activate button
        }
        if(num==89){
            StartCoroutine(coroutine30);
            num++;//activate button
        }
        if(num==92){
            StartCoroutine(coroutine31);
            num++;//activate button
        }
        if(num==95){
            StartCoroutine(coroutine32);
            num++;//activate button
        }
        if(num==98){
            StartCoroutine(coroutine33);
            num++;//activate button
        }
        if(num==100){
           scenechange();
        }

       
        
    }
}
