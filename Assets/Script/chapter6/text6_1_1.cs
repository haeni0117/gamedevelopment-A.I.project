using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1_1 : MonoBehaviour
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
    private static string text_00="당장이라도 눕고 싶지만 \n그럴 여유는 없다.";
    private static string text_01="텅 빈 서랍장은 \n뒤져봐도 소용없다";
    private static string text_1="옷을 헤치고 \n안쪽을 더듬어 봤지만, \n당연히 옷 말고는 \n아무것도 없다.           ";
    private static string text_2="옷장 밑 1단 서랍장은 \n잠금이 걸려 있다.           ";
    private static string text_3="역시 비밀번호는 \n기억나지 않는다.\n구급상자를 \n금고에 넣어뒀을 리는 없으니 \n일단 구급상자부터 찾아보자.           ";


    private static string text_4="구급상자는 보이지 않는다.           ";
    private static string text_5="수납장 위를 훑어봐도 \n구급상자는 보이지 않아.           ";
    private static string text_6="백팩을 한 번 더 뒤졌다. \n역시 쓸 만한 것은 \n보이지 않아.           ";
    private static string text_7="화장실에는 \n다시 들어가고 싶지 않다.            ";
    private static string text_8="다른 곳도 둘러볼까?";

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


    public static void 오브젝트활성화(){
      typingText.text="";
      at.text="(1) 침대";
      bt.text="(2) 서랍장";
      ct.text="(3) 옷장";
      dt.text="(4) 사이드 테이블";
      et.text="(5) 수납대";
      ft.text="(6) 가방걸이";
      gt.text="(7) 안방 화장실";
      ht.text="(8) 다른 장소로 가본다.";


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
      num=2;
      a_inspection=true;
    }
    public static void b활성화(){
      num=5;
      b_inspection=true;
    }
    public static void c활성화(){
      num=8;
      c_inspection=true;
    }
    public static void d활성화(){
      num=17;
      d_inspection=true;
    }
    public static void e활성화(){
      num=20;
      e_inspection=true;
    }
    public static void f활성화(){
      num=23;
      f_inspection=true;
    }
    public static void g활성화(){
      num=26;
      g_inspection=true;
    }
    public static void h활성화(){
      num=29;
      h_inspection=true;
    }
    public static void choice_a활성화(){
      num=32;

    }public static void choice_b활성화(){
      num=33;

    }
    public static void 선택지활성화(){
      choice_a.SetActive(true);
      choice_b.SetActive(true);
      choice_at.text="A. 다른 곳을 둘러본다.";
      choice_bt.text="B. 아니다, 더 찾아보자.";
      choice_aB.interactable=true;
      choice_bB.interactable=true;
    }
    public static void scenechange(){
      SceneManager.LoadScene("6-1");
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
       오브젝트활성화();


        Debug.Log("coroutin is started! #3-1 num"+num);
        
    }

//     // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            Debug.Log("[침대]");
            StartCoroutine(coroutine00);
            오브젝트비활성화();
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
            Debug.Log("[서랍장]");
            StartCoroutine(coroutine01);
            오브젝트비활성화();
            num++;
        }
        if(num==7){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==8){
            Debug.Log("[옷장 - 1]");
            StartCoroutine(coroutine2);
            오브젝트비활성화();
            스킵.interactable=false;
            num++;
        }
        if(num==10){
            Debug.Log("[옷장 - 2]");
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==12){
            Debug.Log("[옷장 - 3]");
            StartCoroutine(coroutine4);
            Debug.Log("coroutine4 is started!  num"+num);
            num++;
            오브젝트비활성화();
        }
        if(num==14){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
            
        }
        if(num==17){
            Debug.Log("[사이드테이블]");
            StartCoroutine(coroutine5);
            오브젝트활성화();
            num++;
        }
        if(num==19){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }

        if(num==20){
            StartCoroutine(coroutine6);
            Debug.Log("[수납대]");
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==22){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==23){
            StartCoroutine(coroutine7);
            Debug.Log("[가방걸이]");
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==25){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==26){
            StartCoroutine(coroutine8);
            Debug.Log("[안방화장실]");
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==28){
            Debug.Log("오브젝트 목록!");
            오브젝트활성화();
        }
        if(num==29){
            StartCoroutine(coroutine9);
            Debug.Log("[다른 장소로 가본다.]");
            num++;//activate button
            오브젝트비활성화();
        }
        if(num==31){
            Debug.Log("다른장소 -> 선택지");
            선택지활성화();

        }
        if(num==32){
            Debug.Log("[다른 곳을 둘러본다.]");
            scenechange();
            
        }
        if(num==33){
            Debug.Log("[아니다, 더 찾아보자.]");
            오브젝트활성화();
            
        }
        
    }
}
