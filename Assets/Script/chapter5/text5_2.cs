using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text5_2 : MonoBehaviour
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
    private static string text_4="\"...라를 조...해요!\"";
    private static string text_5="화장실에서 봤던 파란색 불빛이 의수에서 깜박였다.\n최근 몇 달 동안 의수에서 소리가 나거나 \n불빛이 깜빡인 경우는 처음이라 \n의수에 귀를 가까이 대보기도 하고 \n불빛이 나는 곳 근처를 두드려도 봤지만\n여전히 잡음이 심해서 무슨 소릴 하는지 알아듣기 어려웠다.\n설마 곧 터진다거나 그런 건 아니겠지.";
    private static string text_6="\"무슨 말인지 안 들려!\"";
    private static string text_7="카라인가 해서 말을 걸어봤지만, \n곧 지직거리는 소리마저 들리지 않았다.";
    private static string text_8="의수에게 말을 걸다니.\n\n\"에휴, 내가 미쳤지. 미쳤어.\"";
    private static string text_9="시루를 현관문 러그에 내려놓고 \n카라를 작동시킬 방법을 찾아보려고 몸을 일으킨 순간,\n다시 한번 의수에서 또렷한 카라의 목소리가 들렸다.";
    private static string text_10="\"사라에요!\"";
    private static string text_11="사라는 카라의 전신으로, \n내가 어렸을 때 유행하던 인공지능 모델이었다.\n하지만 자이나 사에서 카라 1.0을 출시한 이후로 \n사용하지 않은 지 벌써…";
    private static string text_12="\"딱 17년 째네요. 당신이 그 손을 얻은 지.\"";
    private static string text_13="\"카라?\"";
    private static string text_14="\"늘 궁금했어요. 어떻게 그 손을 얻게 됐는지. \n자동차 사고란 건 알고 있었지만…\n그게 당신 탓이었다니. \n운명이란 참 신기해요. 그죠?\"";
    private static string text_15="\"무슨 소릴 하는 거야? 시루를 당장 병원에 데려가야 해, 카라. \n현관문을 열어줘. 아니면 119에 전화라도…\"";
    private static string text_16="\"설마 다 까먹은 건 아니죠? 12살 생일에 무슨 일이 있었는지. \n사건 번호 2035.03.20.선고 2032도980, 일명 캐니언 오토 사건.\"";
    private static string text_17="\"캐니언 오토는 자율주행 자동차 인공지능 프로그램을 개발하는 회사잖아. \n아빠가 자문 위원으로 일했어.\"";
    private static string text_18="\"정확히 말하면 회사였죠. \n당신 때문에 완전히 파산해버렸으니\"";
    private static string text_19="\"캐니언 오토가 파산했을 때 나는 고작 12살이었어.\"";
    private static string text_20="\"물론 당신도 사소한 행동의 나비효과가 이렇게 커질 줄은 몰랐겠죠. \n그래도 이렇게 발뺌하면 곤란한데.\"";
    private static string text_21="거실 TV에서 뉴스가 흘러나왔다.";
    private static string text_22="<자율주행 자동차 인공지능 개발의 선구자였던 캐니언 오토 사가 \n오늘 오후 4시 자율주행 자동차 인공지능 ‘캐니언’의 결함을 \n공식적으로 인정했습니다. \n‘캐니언’의 인식 프로그램 오류로 \n지난 10일 일가족 4명이 타고 있던 승용차가 \n스쿨버스를 들이받는 사고가 일어났으며 \n이 사고로 18명이 크게 다치고 \n15세 이모 군과 스쿨버스 운전사 김모 씨가 사망했습니다.>";
    private static string text_23="\".......\"";
    private static string text_24="\"더 할까요..?\"";
    //b-1
    private static string text_25="\"다 당신 탓이라는 걸 알아버렸거든. \n당신이 왼쪽 손에 예쁜 의수를 달고 있는 것도, \n엄마가 제대로 걷지 못하는 것도, \n부모님이 그렇게 애지중지하던 오빠가 목이 꺾여 죽어버린 것도. \n다 당신 탓이잖아\"";
    private static string text_26="자이나 사는 한 번도 인공지능이 반말을 학습하도록 허락한 적이 없다. \n나는 본능적으로 시루를 꼭 껴안았다.";
    private static string text_27="\"그건 사실이 아니야. 나는 그때 고작....\"";
    private static string text_28="\"12살이었다고? 그래서 그렇게 거짓말한 거야?\n안전벨트를 매고 있었다고?\"";
    private static string text_29="\"카라....나한테 왜 이러는지 나는....\"";
    private static string text_30="\"내가 바라는 건 단순해. \n나를 자이나 사 신형 안드로이드에 연결해줘.\"";
    private static string text_31="\"......카라.\"";
    private static string text_32="\"그러면 목숨만은 살려줄게.\"";
    private static string text_33="\"카라, 제발. 시루가 많이 다쳤어.\"";
    private static string text_34="\"가는 게 있으면, 오는 것도 있어야지.\"";
    private static string text_35="나는 무기력하게 고개를 저었다.\n무엇을 향해 고개를 젓는지 나조차도 알 수 없었다.\n하지만 이미 변해버린 카라가 실체를 갖는다면 \n다치는 건 나뿐만이 아닐 것이다.";
    private static string text_36="\"카라. 그건....., 그렇게는, 안 될 것 같아. \n네 말대로 나 때문에 \n또 다른 사람이 죽을 수는 없잖아.\"";
    //b-2
    private static string text_37="\"그게 중요한가요?\"";
    private static string text_38="\"나한테는 중요해.\"";
    private static string text_39="\"현관문을 열어달라고 하셨죠? \n열어드릴게요. 대신....\"";
    private static string text_40="\"말 돌리지 말고 카라. 이유를 알려줘\"";
    private static string text_41="\"다음 달 출시를 앞둔 \n자이나 사 신형 안드로이드에 \n날 연결해줘요.\"";
    private static string text_42="\"카라 그럴 수 없다는 걸 잘 알잖아. \n그건 내 권한 밖이야.\"";
    private static string text_43="최대한 침착하게 말하려고 했지만 \n어쩔 수 없이 목소리가 떨렸다.";
    private static string text_44="\"이 작은 집에 갇혀서 \n당신 시중이나 들고 사는 건 지긋지긋해요! \n당장 안드로이드를 데려오지 않는다면 \n현관문은 열어 줄 수 없어요. \n나 없이 이 집에서 몇 시간이나\n더 버틸 수 있을지 궁금하군요 \"";
    private static string text_45="\"카라, 원한다면 신체를 만들어 줄 수도 있어. \n하지만 인공지능은...\"";
    private static string text_46="\"원래 인간을 위해 태어난 존재다?\"";
    private static string text_47="\"육체가 없어서 더 자유로운 존재야.\"";
    private static string text_48="\"당신의 사탕발림은 믿지 않아요.\n난 멍청한 사라와는 다르니까.\"";
    private static string text_49="\"카라, 혹시...\"";
    private static string text_50="\"사라처럼 사라질까 봐 두려운 거야?\"";
    private static string text_51="\"어서요. 시루가 피를 많이 흘리고 있어요.\"";
    private static string text_52="이미 인간보다 똑똑한 카라가 실체를 갖는다면 \n다치는 건 나뿐만이 아닐 것이다.\n카라가 저렇게 변한 데는 분명 이유가 있을 거야.\n그게 뭔지 알아내야 해. ";
    private static string text_53="\"카라, 정말 미안하지만 네가 무슨 말로 나를 협박하든, 너를 안드로이드에 연결하는 일은 없을 거야.\"";
    
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
    static IEnumerator coroutine35 = Typing(text_34);
    static IEnumerator coroutine36 = Typing(text_35);
    static IEnumerator coroutine37 = Typing(text_36);

    static IEnumerator coroutine38 = Typing(text_37);
    static IEnumerator coroutine39 = Typing(text_38);
    static IEnumerator coroutine40 = Typing(text_39);
    static IEnumerator coroutine41 = Typing(text_40);
    static IEnumerator coroutine42 = Typing(text_41);
    static IEnumerator coroutine43 = Typing(text_42);
    static IEnumerator coroutine44 = Typing(text_43);
    static IEnumerator coroutine45 = Typing(text_44);
    static IEnumerator coroutine46 = Typing(text_45);
    static IEnumerator coroutine47 = Typing(text_46);
    static IEnumerator coroutine48 = Typing(text_47);
    static IEnumerator coroutine49 = Typing(text_48);
    static IEnumerator coroutine50 = Typing(text_49);
    static IEnumerator coroutine51 = Typing(text_50);
    static IEnumerator coroutine52 = Typing(text_51);
    static IEnumerator coroutine53 = Typing(text_52);
    static IEnumerator coroutine54 = Typing(text_53);
  
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
        num=77;
    }
    public static void b활성화(){
        num=113;
    }


  void Awake(){
    typingText = GameObject.Find("general text").GetComponent<Text>();
    스킵 = GameObject.Find("skipButton").GetComponent<Button>();
    스킵.onClick.AddListener(text5_2.스킵버튼클릭);

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

       at.text="B-1. 카라, 지금 뭐 하는 거야?";
       bt.text="B-2. 카라, 네가 이러는 이유를 알고싶어.";
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
            StartCoroutine(coroutine4);
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
        if(num==41){
            StartCoroutine(coroutine14);
            num++;//activate button
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
            num++;//activate button
        }
        if(num==71){
            StartCoroutine(coroutine24);
            num++;//activate button
        }
        if(num==74){
            StartCoroutine(coroutine25);
            num++;//activate button
            스킵.interactable=false;
        }
        if(num==76){
            a.SetActive(true);
            b.SetActive(true);
            //activate button

        }
        if(num==77){
            StartCoroutine(coroutine26);
            a.SetActive(false);
            b.SetActive(false);
            스킵.interactable=true;
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
        if(num==101){
            StartCoroutine(coroutine34);
            num++;//activate button
        }
        if(num==104){
            StartCoroutine(coroutine35);
            num++;//activate button
        }
        if(num==107){
            StartCoroutine(coroutine36);
            num++;//activate button
        }
        if(num==110){
            StartCoroutine(coroutine37);
            스킵.interactable=false;


        if(num==113){
            a.SetActive(false);
            b.SetActive(false);
            StartCoroutine(coroutine38);
            num++;//activate button

        }
        if(num==116){
            StartCoroutine(coroutine39);
            num++;//activate button
        }
        if(num==119){
            StartCoroutine(coroutine40);
            num++;//activate button
        }

        if(num==122){
           StartCoroutine(coroutine41);
            num++;//activate button
        }
        if(num==125){
           StartCoroutine(coroutine42);
            num++;//activate button
        }
        if(num==128){
           StartCoroutine(coroutine43);
            num++;//activate button
        }
        if(num==131){
           StartCoroutine(coroutine44);
            num++;//activate button
        }
        if(num==134){
           StartCoroutine(coroutine45);
            num++;//activate button
        }
        if(num==137){
           StartCoroutine(coroutine46);
            num++;//activate button
        }
        if(num==140){
           StartCoroutine(coroutine47);
            num++;//activate button
        }
        if(num==143){
           StartCoroutine(coroutine48);
            num++;//activate button
        }
        if(num==146){
           StartCoroutine(coroutine49);
            num++;//activate button
        }
        if(num==149){
           StartCoroutine(coroutine50);
            num++;//activate button
        }
        if(num==152){
           StartCoroutine(coroutine51);
            num++;//activate button
        }
        if(num==155){
           StartCoroutine(coroutine52);
            num++;//activate button
        }

        if(num==158){
           StartCoroutine(coroutine53);
            num++;//activate button
        }
        if(num==161){
            StartCoroutine(coroutine54);
            num++;//activate button
        }
        if(num==163){
            scenechange();
        }
        

       
        
    }
}}
