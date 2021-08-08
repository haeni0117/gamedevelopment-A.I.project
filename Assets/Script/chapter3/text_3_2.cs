using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_3_2 : MonoBehaviour
{

  public static Text typingText;
  public static Button 스킵;
  public static GameObject backbutton_;
  public static Button backbutton;
  public static Text backbuttont;

  //bool-> 오브젝트 조사여부
  public static bool a_inspection=false;
  public static bool b_inspection=false;
  public static bool c_inspection=false;
  public static bool d_inspection=false;
  public static bool e_inspection=false;
  public static bool f_inspection=false;
  public static bool g_inspection=false;
  public static bool h_inspection=false;


    public static int num = 0;
    public static GameObject fadeout;
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
//(6)사이드테이블
    public static GameObject f;
    public static Button fB;
    public static Text ft;
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
    private static string text_00="어딘가에서 시루가 우는 소리가 \n희미하게 들려온다. \n빠르게 작업실을 둘러봤지만 \n시루는 보이지 않는다. \n일단 시루를 찾아야 한다.\n\n\"어디 있는 거지? 시루야!\"";
    private static string text_01="시루가 어디에 있을까?";
    private static string text_1="집에서 작업할 때 대부분의\n공간을 보내는 장소다. \n시루는 가끔 컴퓨터에만 집중하는 \n나를 방해하기 위해 따뜻한 키보드 위에 \n앉아 있곤 한다. \n하지만 지금 시루는 여기 없어.           ";
    private static string text_2="시루가 가장 좋아하는 \n고양이용 방석이다. \n하지만 어디 갔는지 \n시루가 보이지 않는다           ";
    private static string text_3="의자를 돌려봤지만....\n역시 시루는 여기 있지 않다           ";
    private static string text_4="…정말 시루가 여기 \n있을거라고 생각해...?           ";
    private static string text_5="잡동사니들이 어지럽게 \n흩어져 있다. \n시루가 여기 있을 리 없다.           ";
    private static string text_6="시루가 숨어있기에는 \n공간이 턱없이 부족하다.           ";
    private static string text_7="책장 가장 윗부분까지 \n까치발을 들어서 살펴보았다. \n하지만 시루는 여기 없다.           ";
    private static string text_8="자동 조절 커튼이 걸려 있는 \n베란다 창문이다. \n잠깐! 커튼을 여니 \n시루 울음소리가\n더 크게 들려온다....!           ";

    private static string text_9="전자동 커튼이라 뻑뻑해서 \n완전히 걷히지는 않지만 \n살짝 들린 사이로 \n시루의 울음소리가 들린다. \n시루가 베란다에 숨어있는 것 같다. \n베란다 바닥이 차가워서 \n시루는 베란다를 좋아하지 않는데 \n어떻게 들어간 거지?";
    private static string text_10="게다가 나는 2층 베란다 문을 \n항상 잠가두는데…\n하지만 이런 쓸데없는 \n생각할 시간이 없어. \n어서 시루를 데려와야 해.....!";

    private static string text_11="역시나 문이 잠겨 있다. \n쪽에서 철컥철컥 소리가 나서\n올려다보니 자동 조절 걸쇠가 \n작동하지 않는다. \n저걸 풀어야 문을 열 수 있다.";
    private static string text_12="가만히 살펴보니\n전자동 개폐 장치를 수동으로\n열 수 있을 것 같다. \n하지만 창이 너무 높아서 \n손이 닿지 않는다. \n밟고 올라갈 만한 것을 \n찾아봐야겠어";



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
    static IEnumerator coroutine12 = Typing(text_11);
    static IEnumerator coroutine13 = Typing(text_12);

    public static void 오브젝트활성화(){
      typingText.text="";
      at.text="(1) 책상";
      bt.text="(2) 반려동물 방석";
      ct.text="(3) 의자";
      dt.text="(4) IoT 쓰레기통";
      et.text="(5) 탁자";
      ft.text="(6) 사이드 테이블";
      gt.text="(7) 책장";
      ht.text="(8) 2층 베란다 창문";

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

      if(e_inspection==false){
        eB.interactable=true;
      }else eB.interactable=false;

      if(f_inspection==false){
        fB.interactable=true;
      }else fB.interactable=false;

      if(g_inspection==false){
        gB.interactable=true;
      }else gB.interactable=false;

      if(h_inspection==false){
        hB.interactable=true;
      }else hB.interactable=false;
    }


    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
    }
    public static void a활성화(){
      num=5;
      a_inspection=true;
    }
    public static void b활성화(){
      num=8;
      b_inspection=true;
    }
    public static void c활성화(){
      num=11;
      c_inspection=true;
    }
    public static void d활성화(){
      num=14;
      d_inspection=true;
    }
    public static void e활성화(){
      num=17;
      e_inspection=true;
    }
    public static void f활성화(){
      num=20;
      f_inspection=true;
    }
    public static void g활성화(){
      num=23;
      g_inspection=true;
    }
    public static void h활성화(){
      num=26;
      h_inspection=true;
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
      SceneManager.LoadScene("3-3");
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


  void Awake(){
    typingText = GameObject.Find("general text").GetComponent<Text>();
    스킵 = GameObject.Find("skipButton").GetComponent<Button>();
    스킵.onClick.AddListener(text_1_8.스킵버튼클릭);
    backbutton_=GameObject.Find("backbutton");
    backbutton=GameObject.Find("backbutton").GetComponent<Button>();
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

    f = GameObject.Find("f");
    fB =f.GetComponent<Button>();
    ft = GameObject.Find("fText").GetComponent<Text>();
    fB.onClick.AddListener(f활성화);

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
  }
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_3_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=true;//스킵비활성화
       //오브젝트 초기화
       at.text="";
       bt.text="";
       ct.text="";
       dt.text="";
       et.text="";
       ft.text="";
       gt.text="";
       ht.text="";
       choice_at.text="";
       choice_bt.text="";
       choice_a.SetActive(false);
       choice_b.SetActive(false);


       aB.interactable=false;
       bB.interactable=false;
       cB.interactable=false;
       dB.interactable=false;
       eB.interactable=false;
       fB.interactable=false;
       gB.interactable=false;
       hB.interactable=false;
       choice_aB.interactable=false;
       choice_bB.interactable=false;


        Debug.Log("coroutin is started! #3-1 num"+num);
        StartCoroutine(coroutine00);

    }

//     // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            Debug.Log("coroutine1 is started!  num"+num);
            StartCoroutine(coroutine01);
            num++;
            스킵.interactable=false;

            //StartCoroutine(coroutine1);
        }
        if(num==4){
            Debug.Log("오브젝트 활성화!");
            오브젝트활성화();
            스킵.interactable=false;
        }
        if(num==5){
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine2);
            오브젝트비활성화();
            num++;
        }
        if(num==7){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==8){
            Debug.Log("coroutine3 is started!  num"+num);
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
            Debug.Log("coroutine4 is started!  num"+num);
            num++;
            오브젝트비활성화();
        }
        if(num==13){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine5 is started!  num"+num);
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==16){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }

        if(num==17){
            StartCoroutine(coroutine6);
            Debug.Log("coroutine6 is started!  num"+num);
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==19){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==20){
            StartCoroutine(coroutine7);
            Debug.Log("coroutine7 is started!  num"+num);
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==22){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine8 is started!  num"+num);
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==25){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==26){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine9 is started!  num"+num);
            num++;//activate button
            오브젝트비활성화();


        }
        if(num==28){
            Debug.Log("베란다 -> 선택지 보여주기");
            선택지활성화();

        }
        if(num==29){
            Debug.Log("[a. 베란다 커튼을 걷어본다.]");
            StartCoroutine(coroutine10);
            스킵.interactable=true;
            choice_b.SetActive(false);
            choice_a.SetActive(false);
            num++;
        }
        if(num==32){
            Debug.Log("[a. 베란다 커튼을 걷어본다.]");
            StartCoroutine(coroutine11);
            스킵.interactable=false; //다음 씬으로 이동
            Invoke("scenechange",3f);
            num++;
        }
        if(num==35){
            Debug.Log("[B. 베란다 문을 연다.]");
            StartCoroutine(coroutine12);
            스킵.interactable=true;
            choice_a.SetActive(false);
            choice_b.SetActive(false);
            num++;
        }
        if(num==38){
            Debug.Log("[B. 베란다 문을 연다.]");
            StartCoroutine(coroutine13);
            스킵.interactable=false; //다음 씬으로 이동
            Invoke("scenechange",3f);
            num++;
        }
    }
}
