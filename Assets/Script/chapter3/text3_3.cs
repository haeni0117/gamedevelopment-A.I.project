using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text3_3 : MonoBehaviour
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
    private static string text_00="어디 밟고 올라갈 만한 것이 있을까?";
    private static string text_01="집에서 작업할 때 대부분을 \n보내는 장소다. \n컴퓨터를 이용하면 밖에 \n연락할 수 있을지 모르지만....\n지금은 시루를 찾는 게 먼저다.           ";
    private static string text_1="이 방석에 시루가 동그랗게 \n몸을 말고 있는 모습을 \n얼른 다시 보고 싶다....           ";
    private static string text_2="등받이와 머리 받침대 조절이 \n가능한 의자다.\n내 체형에 딱 맞게 \n조절해놓았다.\n이 의자를 밝고 올라가면\n될 것 같은데....?\n\n{의자를 획득했다}          ";
    private static string text_3="윗면 센서에 손을 흔들면 \n자동으로 뚜껑이 열리는 \n쓰레기통이다. \n별로 볼만한 것은 없다.           ";
    private static string text_4="취미용 책들과 \n스마트 액자가 올라가 있다.           ";
    private static string text_5="인공지능의 계급 분화를 주장한 \n아니샤 바르미마나의 책이다. \n인상 깊게 읽은 구절에는 \n형광펜으로 밑줄이 쳐져 있다.\n\n이 분 덕분에 내가 지금의 \n지위에 오를 수 있었다고 해도 \n과언이 아니다.           ";
    private static string text_6="내가 좋아하는 작가의 \n연작 소설이다. \n결말이 정말 궁금하지만, \n지금은 그럴 때가 아니다.           ";
    private static string text_7="스마트 액자 액정 부분이\n새까맣다.\n원래는 시루의 어릴 때\n사진이 있어야 하는데…           ";
    private static string text_8="흑단으로 만들어져 \n반들거리는 빛이 난다           ";

    private static string text_9="밤에 작업실이 너무 캄캄하지 \n않도록 켜 두는 조명이다.";
    private static string text_10="하루하루 감정이 담긴 \n짧은 일기들을 적어두는 \n다이어리다.";
//pop-up : 다이어리
    private static string text_11="{2049.06.30. 수 \n날이 흐리다.\n비가 오는 날이면 늘 그날 생각이 나서 하루종일 우울하다.\n카라가 이런 나의 기분을 눈치챘는지 \n비타센 복용을 권했다.\n약을 먹을 때마다 어제의 기억이 흐릿해지지만...\n약을 먹어서라도 기분이 나아진다면, \n그걸로 충분해.}";
    private static string text_12="{2049.07.017. 토 \n오늘은 휴일이지만 \n급한 회의가 잡혀 회사에 갔다.\n아니샤와 함께 새로 출시된 \n카라의 업데이트 패치에 대한 \n대화를 나누었다.";
    private static string text_13="생각보다 회의가 일찍 끝나 \n아니샤와 함께 저녁식사를 했다. \n오랜만에 하는 여유로운 식사라 \n내가 처음 이 회사에 들어와 \n연구를 시작한 시절의 이야기를 하며\n즐거운 시간을 보넀다.";
    private static string text_14="아니샤는 내 논문을 처음 봤을 때 \n굉장한 영감을 받았다고 했다. \n모두가 무시하던\n나의 연구를 유일하게 인정해주고\n자신의 회사 연구실 일부를 \n내어주기까지 하면서\n나를 서포트 해준 사람.....";
//(7)책장
    private static string text_15="그런데 아니샤는\n나조차도 잘 기억 나지 않는 \n과거를 어떻게 저렇게 또렷하게 \n기억하는 걸까?.}";
    //(8)2층 베란다 창문 -> ㄱ. 의자 획득 이전 조사를 했을 때
    private static string text_16="이놈의 자동 조절 장치는 \n왜 저렇게 위에 달린 건지...";
  //(8)2층 베란다 창문 -> ㄴ. 의자 획득 이후 조사를 했을 때
    private static string text_17="의자를 밟고 올라가면 \n손이 닿을 것 같다!\n{의자를 2층 베란다 창문에 사용한다.} ";
    private static string text_18="\"됐다!\"\n조절 장치를 돌려\n문을 열었다.\n그런데...\n\"앗!\"";
    private static string text_19="의자에서 미끄러져 \n완전히 굴러떨어졌다. \n그래도 크게 다친 곳은 없다.\n하지만 의자가 완전히 \n부서져 버렸다.\n{아이템 창에서 의자 삭제}";
    private static string text_20="부서진 의자의 부품을 \n밟지 않도록 조심하며\n베란다로 나갔다.";
    static IEnumerator coroutine00=  Typing(text_00);
    static IEnumerator coroutine01=  Typing(text_01);
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
    static IEnumerator coroutine12 = Typing2(text_11);
    static IEnumerator coroutine13 = Typing2(text_12);
    static IEnumerator coroutine14 = Typing2(text_13);
    static IEnumerator coroutine15 = Typing2(text_14);
    static IEnumerator coroutine16 = Typing2(text_15);
    static IEnumerator coroutine17 = Typing(text_16);
    static IEnumerator coroutine18 = Typing(text_17);
    static IEnumerator coroutine19 = Typing(text_18);
    static IEnumerator coroutine20 = Typing(text_19);
    static IEnumerator coroutine21 = Typing(text_20);

    public static void 오브젝트활성화(){
      a.SetActive(true);
      b.SetActive(true);
      c.SetActive(true);
      d.SetActive(true);
      e.SetActive(true);
      f.SetActive(true);
      g.SetActive(true);

      typingText.text="";
      at.text="(1) 책상";
      bt.text="(2) 반려동물 방석";
      ct.text="(3) 의자";
      dt.text="(4) IoT 쓰레기통";
      et.text="(5) 탁자";
      ft.text="(6) 사이드 테이블";
      gt.text="(7) 책장";
      ht.text="(8) 2층 베란다 창문";

      if(a_inspection2==false){
        aB.interactable=true;
      }else aB.interactable=false;

      if(b_inspection2==false){
        bB.interactable=true;
      }else bB.interactable=false;

      if(c_inspection2==false){
        cB.interactable=true;
      }else cB.interactable=false;

      if(d_inspection2==false){
        dB.interactable=true;
      }else dB.interactable=false;

      if(e_inspection2==false){
        eB.interactable=true;
      }else eB.interactable=false;

      if(f_inspection2==false){
        fB.interactable=true;
      }else fB.interactable=false;

      if(g_inspection2==false){
        gB.interactable=true;
      }else gB.interactable=false;

      if(h_inspection2==false){
        hB.interactable=true;
      }else hB.interactable=false;
    }


    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
        backbutton_.SetActive(false);
    }
    public static void a활성화(){
      num=2;
      a_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void b활성화(){
      num=5;
      b_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void c활성화(){
      num=8;
      c_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void d활성화(){
      num=11;
      d_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void e활성화(){
      num=14;
      e_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void f활성화(){
      num=29;
      f_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void f1활성화(){
      num=32;
      f1_inspection2=true;
    }
    public static void f2활성화(){
      num=35;
      f2_inspection2=true;
    }
    public static void g활성화(){
      num=53;
      g_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void h활성화(){
      num=56;
      h_inspection2=true;
      backbutton_.SetActive(false);
    }
    public static void choice_a활성화(){
      num=29;

    }public static void choice_b활성화(){
      num=35;

    }
    public static void 선택지활성화(){
      choice_a.SetActive(true);
      choice_b.SetActive(true);
      choice_at.text="A. 베란다 커특을 걷어본다.";
      choice_bt.text="B. 베란다 문을 연다.";
      choice_aB.interactable=true;
      choice_bB.interactable=true;
    }
    public static void scenechange(){
      SceneManager.LoadScene("3-4");
    }
    public static void backbutton활성화(){
      num=1;
      typingText.text="";
      e1.SetActive(false);
      e2.SetActive(false);
      e3.SetActive(false);
      f1.SetActive(false);
      f2.SetActive(false);
    }
    public static void 오브젝트비활성화(){
      at.text="";
      bt.text="";
      ct.text="";
      dt.text="";
      et.text="";
      ft.text="";
      gt.text="";
      ht.text="";
      aB.interactable=false;
      bB.interactable=false;
      cB.interactable=false;
      dB.interactable=false;
      eB.interactable=false;
      fB.interactable=false;
      gB.interactable=false;
      hB.interactable=false;
    }
    public static void 사이트테이블오브젝트활성화(){
      f1.SetActive(true);
      f2.SetActive(true);
      f1t.text="(6)-1 스탠드 조명";
      f2t.text="(6)-2 다이어리";
      f1B.interactable=true;
      f2B.interactable=true;
      typingText.text=" ";
    }
    public static void 사이드테이블오브젝트비활성화(){
      f1.SetActive(false);
      f2.SetActive(false);
      diary.SetActive(false);
      typingText.text=" ";
    }
    public static void 탁자오브젝트활성화(){
      typingText.text="";
      e1.SetActive(true);
      e2.SetActive(true);
      e3.SetActive(true);
      e1t.text="(5)-1. 인공지능 계급론";
      e2t.text="(5)-2. 소설책";
      e3t.text="(5)-3. 스마트 액자";
      if(e1_inspection2==false){
        e1B.interactable=true;
      }else e1B.interactable=false;
      if(e2_inspection2==false){
        e2B.interactable=true;
      }else e2B.interactable=false;
      if(e3_inspection2==false){
        e3B.interactable=true;
      }else e3B.interactable=false;
    }
    public static void e1활성화(){
      // backbutton_.SetActive(true);
      e1_inspection2=true;
      e1.SetActive(false);
      e2.SetActive(false);
      e3.SetActive(false);
      num=17;
    }
    public static void e2활성화(){
      // backbutton_.SetActive(true);
      e2_inspection2=true;
      e1.SetActive(false);
      e2.SetActive(false);
      e3.SetActive(false);
      num=23;
    }
    public static void e3활성화(){
      // backbutton_.SetActive(true);
      e3_inspection2=true;
      e1.SetActive(false);
      e2.SetActive(false);
      e3.SetActive(false);
      num=26;
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


  void Awake(){
    typingText = GameObject.Find("general text").GetComponent<Text>();
    스킵 = GameObject.Find("skipButton").GetComponent<Button>();
    스킵.onClick.AddListener(text3_3.스킵버튼클릭);
    backbutton_=GameObject.Find("backbutton");
    backbutton=GameObject.Find("backbutton").GetComponent<Button>();
    backbutton.onClick.AddListener(backbutton활성화);
    backbuttont=GameObject.Find("backbuttonText").GetComponent<Text>();

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

    e = GameObject.Find("e");
    eB =e.GetComponent<Button>();
    et = GameObject.Find("eText").GetComponent<Text>();
    eB.onClick.AddListener(e활성화);

    e1 = GameObject.Find("e1");
    e1B =e1.GetComponent<Button>();
    e1t = GameObject.Find("e1Text").GetComponent<Text>();
    e1B.onClick.AddListener(e1활성화);

    e2 = GameObject.Find("e2");
    e2B =e2.GetComponent<Button>();
    e2t = GameObject.Find("e2Text").GetComponent<Text>();
    e2B.onClick.AddListener(e2활성화);

    e3 = GameObject.Find("e3");
    e3B =e3.GetComponent<Button>();
    e3t = GameObject.Find("e3Text").GetComponent<Text>();
    e3B.onClick.AddListener(e3활성화);


    f = GameObject.Find("f");
    fB =f.GetComponent<Button>();
    ft = GameObject.Find("fText").GetComponent<Text>();
    fB.onClick.AddListener(f활성화);

    f1 = GameObject.Find("f1");
    f1B =f1.GetComponent<Button>();
    f1t = GameObject.Find("f1Text").GetComponent<Text>();
    f1B.onClick.AddListener(f1활성화);

    f2 = GameObject.Find("f2");
    f2B =f2.GetComponent<Button>();
    f2t = GameObject.Find("f2Text").GetComponent<Text>();
    f2B.onClick.AddListener(f2활성화);

    g = GameObject.Find("g");
    gB =g.GetComponent<Button>();
    gt = GameObject.Find("gText").GetComponent<Text>();
    gB.onClick.AddListener(g활성화);

    h = GameObject.Find("h");
    hB =h.GetComponent<Button>();
    ht = GameObject.Find("hText").GetComponent<Text>();
    hB.onClick.AddListener(h활성화);

    choice_a = GameObject.Find("choice_a");
    choice_aB =choice_a.GetComponent<Button>();
    choice_at = GameObject.Find("choice_aText").GetComponent<Text>();
    choice_aB.onClick.AddListener(choice_a활성화);

    choice_b = GameObject.Find("choice_b");
    choice_bB =choice_b.GetComponent<Button>();
    choice_bt = GameObject.Find("choice_bText").GetComponent<Text>();
    choice_bB.onClick.AddListener(choice_b활성화);

    diary =  GameObject.Find("diary");
  } 
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_3_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=true;//스킵비활성화
       diary.SetActive(false);
       //오브젝트 초기화
       at.text="";
       bt.text="";
       ct.text="";
       dt.text="";
       et.text="";
       ft.text="";
       gt.text="";
       ht.text="";
       f1t.text="";
       f2t.text="";

       choice_at.text="";
       choice_bt.text="";
       choice_a.SetActive(false);
       choice_b.SetActive(false);
       e1.SetActive(false);
       e2.SetActive(false);
       e3.SetActive(false);
        f1.SetActive(false);
        f2.SetActive(false);


       aB.interactable=false;
       bB.interactable=false;
       cB.interactable=false;
       dB.interactable=false;
       eB.interactable=false;
       e1B.interactable=false;
       e2B.interactable=false;
       e3B.interactable=false;
       fB.interactable=false;
       gB.interactable=false;
       hB.interactable=false;
       f1B.interactable=false;
       f2B.interactable=false;
       choice_aB.interactable=false;
       choice_bB.interactable=false;



        Debug.Log("coroutin is started! #3-1 num"+num);
        StartCoroutine(coroutine00);
        // num++;


    }

//     // Update is called once per frame
    void Update(){
      Debug.Log(num);
        //Debug.Log(num);
        if(num==1){
            Debug.Log("오브젝트 활성화!");
            오브젝트활성화();
            스킵.interactable=false;

            //StartCoroutine(coroutine1);
        }
        if(num==2){
            Debug.Log("[책상] 선택지");
            StartCoroutine(coroutine01);
            오브젝트비활성화();
            스킵.interactable=false;
            num++;
        }
        if(num==4){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
            스킵.interactable=false;
        }
        if(num==5){
            Debug.Log("[반려동물 방석] 선택지");
            StartCoroutine(coroutine2);
            오브젝트비활성화();
            num++;
        }
        if(num==7){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==8){
            Debug.Log("[의자] 선택지");
            StartCoroutine(coroutine3);
            오브젝트비활성화();
            num++;
        }
        if(num==10){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("[IoT 쓰레기통] 선택지");
            num++;
            오브젝트비활성화();
        }
        if(num==13){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==14){
          //(5) 탁자
            StartCoroutine(coroutine5);
            Debug.Log("[탁자] 선택지");
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==16){
            Debug.Log("[인공지능 계급론] [소설책] [스마트액자]");
            탁자오브젝트활성화();
            스킵.interactable=false;

        }
//(5)-1 인공지능 계급론
        if(num==17){
            StartCoroutine(coroutine6);
            Debug.Log("인공지능 계급론 text1");
            num++;//activate button
            오브젝트비활성화();
            스킵.interactable=false;
            backbutton_.SetActive(false);
        }
        if(num==19){
            Debug.Log("[인공지능 계급론] [소설책] [스마트액자]");
            탁자오브젝트활성화();
            오브젝트비활성화();
            스킵.interactable=false;
            backbutton_.SetActive(true);
        }
        if(num==23){
            StartCoroutine(coroutine7);
            Debug.Log("소설책");
            num++;//activate button
            오브젝트비활성화();
            스킵.interactable=false;
            backbutton_.SetActive(false);
        }
        if(num==25){
            Debug.Log("탁자오브젝트 목록!");
            탁자오브젝트활성화();
            오브젝트비활성화();
            스킵.interactable=false;
            backbutton_.SetActive(true);
        }
        if(num==26){
            StartCoroutine(coroutine8);
            Debug.Log("스마트 액자");
            num++;//activate button
            오브젝트비활성화();
            스킵.interactable=false;
            backbutton_.SetActive(false);

        }
        if(num==28){
            Debug.Log("탁자오브젝트 목록!");
            탁자오브젝트활성화();
            오브젝트비활성화();
            스킵.interactable=false;
            backbutton_.SetActive(true);


        }//(6)사이트테이블
        if(num==29){
            Debug.Log("사이드테이블 조사-> text출력");
            오브젝트비활성화();
            StartCoroutine(coroutine9);
            // choice_b.SetActive(false);
            // choice_a.SetActive(false);
            num++;
            backbutton_.SetActive(false);
        }
        if(num==31){
            사이트테이블오브젝트활성화();
            Debug.Log("[사이트테이블 오브젝트활성화]");
            스킵.interactable=false; 
            backbutton_.SetActive(false);
            
        }
        if(num==32){
            Debug.Log("[스탠드조명]");
            StartCoroutine(coroutine10);
            스킵.interactable=true;
            num++;
            
        }
        if(num==34){
            사이트테이블오브젝트활성화();
            Debug.Log("[사이트테이블 오브젝트활성화]");
            스킵.interactable=false; //다음 씬으로 이동
            if(f2_inspection2==true){
              backbutton_.SetActive(true);
            }else  backbutton_.SetActive(false);
            
            
        }
        if(num==35){//팝업창 생성
            Debug.Log("[다이어리]");
            StartCoroutine(coroutine11);
            
            스킵.interactable=true;
            diary.SetActive(true);
            f2B.interactable=false;
            num++;
        }
        if(num==38){
            Debug.Log("[다이어리 text1]");
            StartCoroutine(coroutine12);
            스킵.interactable=true;
            f2B.interactable=false;
            num++;
  
        }
        if(num==41){
            Debug.Log("[다이어리 text2]");
            diary.SetActive(true);
            StartCoroutine(coroutine13);
            스킵.interactable=true;
            f2B.interactable=false;
            num++;
        }
        if(num==44){
            Debug.Log("[다이어리 text3]");
            StartCoroutine(coroutine14);
            스킵.interactable=true;
            f2B.interactable=false;
            num++;
        }
        if(num==47){
            Debug.Log("[다이어리 text4]");
            StartCoroutine(coroutine15);
            스킵.interactable=true;
            f2B.interactable=false;
            num++;
        }
        if(num==50){
            Debug.Log("[다이어리 text5]");
            StartCoroutine(coroutine16);
            스킵.interactable=false;
            f2B.interactable=false;
            num++;
        }
      
        if(num==52){
            diary.SetActive(false);
            Debug.Log("[다이어리 선택지 종료]");
            typingText2.text ="";//다이어리 텍스트 초기화
            사이드테이블오브젝트비활성화();
            오브젝트활성화();


        }
        if(num==53){
            Debug.Log("[책장]");
            StartCoroutine(coroutine17);
            스킵.interactable=false;
            오브젝트비활성화(); 
            backbuttont.text="";
            num++;
        }
        if(num==55){
            Debug.Log("[오브젝트활성화]");
            오브젝트활성화();
            스킵.interactable=false; 
        }
        if(num==56){
            Debug.Log("[2층 베란다 창문]");
            if(f2_inspection2==false){
              typingText.text="주변을 더 둘러봐야 할 것 같다.";
            }
            else{if(c_inspection2==false){
              StartCoroutine(coroutine18);
            }
            else {StartCoroutine(coroutine19);}
            스킵.interactable=true; }
            오브젝트비활성화(); 
            num++;
        }
        if(num==59){
            Debug.Log("[2층 베란다 창문 -> 기본 텍스트]");
            스킵.interactable=true; //다음 씬으로 이동
            StartCoroutine(coroutine20);
            num++;
        }
        if(num==62){
            Debug.Log("[의자 아이템 삭제]");
            스킵.interactable=true; //다음 씬으로 이동
            StartCoroutine(coroutine21);
            num++;
        }
        if(num==64){
            Debug.Log("[scene #3-3 -> #3-4]");
            스킵.interactable=false; //다음 씬으로 이동
            scenechange();
            
        }
    }
}
