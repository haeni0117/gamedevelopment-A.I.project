using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-8 화장실조사
public class text_1_8: MonoBehaviour
{
  public static Button 스킵;

  public static GameObject choice1;
  public static Button choice1B;
  public static Text choice1t;

  public static GameObject a;
  public static Button aB;
  public static Text at;
  //a-1 샤워부스 선반
  public static GameObject a1;
  public static Button a1B;
  public static Text a1t;
  //a-1-1 샴푸
  public static GameObject a11;
  public static Button a11B;
  public static Text a11t;
  //a-1-2 린스
  public static GameObject a12;
  public static Button a12B;
  public static Text a12t;
  //a-1-3 바디워시
  public static GameObject a13;
  public static Button a13B;
  public static Text a13t;
  //a-1-4 스페어키
  public static GameObject a14;
  public static Button a14B;
  public static Text a14t;
  //b
  public static GameObject b;
  public static Button bB;
  public static Text bt;
  //c
  public static GameObject c;
  public static Button cB;
  public static Text ct;
  //d
  public static GameObject d;
  public static Button dB;
  public static Text dt;
  //d1
  public static GameObject d1;
  public static Button d1B;
  public static Text d1t;
  //d2
  public static GameObject d2;
  public static Button d2B;
  public static Text d2t;
  //d3
  public static GameObject d3;
  public static Button d3B;
  public static Text d3t;
  //d4
  public static GameObject d4;
  public static Button d4B;
  public static Text d4t;
  //d5
  public static GameObject d5;
  public static Button d5B;
  public static Text d5t;
  //e
  public static GameObject e;
  public static Button eB;
  public static Text et;
  //f
  public static GameObject f;
  public static Button fB;
  public static Text ft;

  public static GameObject f1;
  public static Button f1B;
  public static Text f1t;

  public static GameObject f2;
  public static Button f2B;
  public static Text f2t;
  //boolean variable
  public static bool item_sparekey=false;
  public static bool item_toy=false;
  public static bool item_vitasen = false;
  public static bool item_gender = false;


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
    public static Text typingText;
    public static GameObject fadeout;




    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    public static void backbutton클릭(){
      Debug.Log("you clicked the backbutton");
      num=44;
    }
    public static void raycastissue(){
      a11.SetActive(false);
      a12.SetActive(false);
      a13.SetActive(false);
      a14.SetActive(false);
      a1.SetActive(false);
      d1.SetActive(false);
      d2.SetActive(false);
      d3.SetActive(false);
      d4.SetActive(false);
      d5.SetActive(false);
    }
    //choice1activation
    public static void 선택지활성화(){
        text_1_8.choice1t.text="a. 화장실 문을 확인한다.";
        text_1_8.choice1B.interactable=true;
        num=5;
        스킵.interactable=false;
    }

    public static void object활성화(){
      raycastissue();
      at.text="(1) 샤워 부스";
      aB.interactable=true;
      aB.onClick.AddListener(text_1_8.a활성화);
      //b
      bt.text="(2) IoT 비데";
      bB.interactable=true;
      bB.onClick.AddListener(text_1_8.b활성화);
      //c
      ct.text="(3) 발 매트";
      cB.interactable=true;
      cB.onClick.AddListener(text_1_8.c활성화);
      //d
      dt.text="(4) 거울과 선반";
      dB.interactable=true;
      dB.onClick.AddListener(text_1_8.d활성화);
      //e
      et.text="(5) 세면대";
      eB.interactable=true;
      eB.onClick.AddListener(text_1_8.d활성화);
      //f
      ft.text="(6) 수건 받침대";
      fB.interactable=true;
      fB.onClick.AddListener(text_1_8.f활성화);

    }
    public static void a활성화(){
      //그냥 아예 못찾는건가?
      a1.SetActive(true);
      num=11;

    }
    public static void a1활성화(){
      num=14;
      a11.SetActive(true);
      a12.SetActive(true);
      a13.SetActive(true);
      a14.SetActive(true);

      //a-1-1 샴푸
      a11t.text="(1)-1-1 샴푸";
      a11B.interactable=true;
      a11B.onClick.AddListener(text_1_8.a11활성화);
      //a-1-2 린스
      a12t.text="(1)-1-2 린스";
      a12B.interactable=true;
      a12B.onClick.AddListener(text_1_8.a12활성화);
      //a-1-3 바디워시
      a13t.text="(1)-1-3 바디워시";
      a13B.interactable=true;
      a13B.onClick.AddListener(text_1_8.a13활성화);
      //a-1-4 스페어키
      a14t.text="(1)-1-4 스페어키";
      a14B.interactable=true;
      a14B.onClick.AddListener(text_1_8.a14활성화);
    }

    public static void b1활성화(){
      num=14;
      a11.SetActive(true);
      a12.SetActive(true);
      a13.SetActive(true);
      a14.SetActive(true);

      //a-1-1 샴푸
      a11t.text="(1)-1-1 샴푸";
      a11B.interactable=true;
      a11B.onClick.AddListener(text_1_8.a11활성화);
      //a-1-2 린스
      a12t.text="(1)-1-2 린스";
      a12B.interactable=true;
      a12B.onClick.AddListener(text_1_8.a12활성화);
      //a-1-3 바디워시
      a13t.text="(1)-1-3 바디워시";
      a13B.interactable=true;
      a13B.onClick.AddListener(text_1_8.a13활성화);
      //a-1-4 스페어키
      a14t.text="(1)-1-4 스페어키";
      a14B.interactable=true;
      a14B.onClick.AddListener(text_1_8.a14활성화);
    }

    public static void a11활성화(){
      num=17;
    }
    public static void a12활성화(){
      num=20;
    }
    public static void a13활성화(){
      num=23;
    }
    public static void a14활성화(){
      num=26;
      item_sparekey=true;
    }
    public static void b활성화(){
      num=29;
    }
    public static void c활성화(){
      num=32;
    }
    public static void d활성화(){
      num=35;
    }
    public static void d1활성화(){
      num=38;
    }
    public static void d2활성화(){
      num=41;
    }
    public static void d3활성화(){
      num=44;
    }
    public static void d4활성화(){
      num=47;
    }
    public static void e활성화(){
      num=50;
    }
    public static void f활성화(){
      num=53;
    }
    public static void f1활성화(){
      num=56;
    }
    public static void f2활성화(){
      num=59;
    }
    public static void 기본오브젝트삭제(){
      //a
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      at.text=" ";
      aB.interactable=false;

      //b
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      bt.text="  ";
      bB.interactable=false;


      //c
      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      ct.text=" ";
      cB.interactable=false;


      //d
      GameObject d = GameObject.Find("d");
      Button dB =d.GetComponent<Button>();
      Text dt = GameObject.Find("dText").GetComponent<Text>();
      dt.text=" ";
      dB.interactable=false;

      //e
      GameObject e = GameObject.Find("e");
      Button eB =e.GetComponent<Button>();
      Text et = GameObject.Find("eText").GetComponent<Text>();
      et.text=" ";
      eB.interactable=false;
      //f
      GameObject f = GameObject.Find("f");
      Button fB =f.GetComponent<Button>();
      Text ft = GameObject.Find("fText").GetComponent<Text>();
      ft.text=" ";
      fB.interactable=false;

    }

    public static void choice1활성화(){
      choice1.SetActive(false);
      num=5;

    }
    //a. 카라에게 무슨 일인지 물어본다.
    private static string text_1="화장실은 여전히 정전이었다.\n하지만 산산조각 난 거울에 \n비상전력 전등의 \n희미한 불빛이 반사되어 \n앞이 보이지 않을 정도로 \n어둡지는 않았다.";
    private static string text_2="나는 상황을 파악하자마자 \n카라를 부르며 \n화장실 열림 버튼을 눌렀지만, \n의수에서 흘러나오는 \n파란 불빛만 깜빡일 뿐, \n카라도 7cm 두께의 \n원목 슬라이딩 도어도 \n아무런 반응이 없었다.";
    private static string text_3="일단은 여기를 \n빠져나가야 한다. \n문을 열 수 있는 \n도구를 찾아보자.";

    private static string object1t="해바라기 샤워기가 달린 \n샤워 부스다. \n가끔 따뜻한 물을 맞으며 \n사색에 잠기곤 한다.";
    private static string object2t="하얀색 비데다.\n별로 뚜껑을\n열고 싶지 않다.";
    private static string object3t="샤워할 때 \n미끄러지지 않기 위해 놓은 \n발 매트다. \n이상하게 한쪽 구석이 불룩하다.\n매트를 들어보니 \n고양이 장난감이 놓여있다.\n시루가 장난감을 물고\n들어왔던 모양이다.\n\n\n[고양이 장난감을 획득했다!]";
    private static string object4t="깨진 거울 뒤로 선반이 보인다. \n자주 쓰는 물건들을 넣어두었다.";
    private static string object5t="새하얗고 물 때 하나 \n끼지 않은 세면대다.";
    private static string object6t="은색의 철제 수건 받침대이다. \n샤워하기 전에 \n수건을 걸어 놓는 용도로 쓴다.";
    //object1 샤워부스
    private static string object11t = "샤워할 때 필요한 물품을 \n얹어 놓은 선반이다.";
    private static string object111t = "화이트 머스크 향 샴푸다.\n제일 좋아하는 향이다";
    private static string object112t ="화이트 머스크 향 린스다.\n샴푸와 같은 브랜드의 것이다.";
    private static string object113t ="코코넛 향의 바디워시다. \n별로 좋아하는 향은 아니지만....\n선물 받은 거라 그냥 쓰고 있다.";
    private static string object114t = "화장실 문을 열 수 있는 \n스페어 키다. \n내가 이걸 왜 여기다가 뒀을까.\n\n\n{스페어 키를 획득했다.}";
    //object4 거울과 선반
    private static string object41t="주기적으로 복용하는 약이다. \n병 겉면에 ‘비타센’이라고 \n적혀 있다.\n\n{비타센을 획득했다!}";
    private static string object42t="반쯤 쓴 치약의 뒷부분이 \n말려 올라가 있다.";
    private static string object43t="여분의 휴지이다.\n필요할 때마다 꺼내 쓸 수 있다.";
    private static string object44t="날이 날카롭게 갈린 면도기이다.\n자칫 잘못 만지면 베일 것 같다.";
    private static string object45t="미용실에서 쓰는 것과 같은 \n모델의 드라이어다. \n바람이 아주 강력하다.";

    private static string object61t="폭신하고 커다란 수건이다.";
    private static string object62t="어제 입고 나갔던 코트다. \n내가 이걸 수건 받침대에 \n걸어 놓은 것 같다. \n주머니가 불룩한데 뭐지?";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);

    static IEnumerator object1 = Typing(object1t);
    static IEnumerator object11 = Typing(object11t);
    static IEnumerator object111 = Typing(object111t);
    static IEnumerator object112 = Typing(object112t);
    static IEnumerator object113 = Typing(object113t);
    static IEnumerator object114 = Typing(object114t);

    static IEnumerator object41 = Typing(object41t);
    static IEnumerator object42 = Typing(object42t);
    static IEnumerator object43 = Typing(object43t);
    static IEnumerator object44 = Typing(object44t);
    static IEnumerator object45 = Typing(object45t);

    static IEnumerator object61 = Typing(object61t);
    static IEnumerator object62 = Typing(object62t);

    static IEnumerator object2 = Typing(object2t);
    static IEnumerator object3 = Typing(object3t);
    static IEnumerator object4 = Typing(object4t);
    static IEnumerator object5 = Typing(object5t);
    static IEnumerator object6 = Typing(object6t);

    // Start is called before the first frame update
    void Awake(){
      스킵 = GameObject.Find("skipButton").GetComponent<Button>();
      스킵.onClick.AddListener(text_1_8.스킵버튼클릭);

      choice1 = GameObject.Find("choice1");
      choice1B =choice1.GetComponent<Button>();
      choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
      //a (1) 샤워부스
      a = GameObject.Find("a");
      aB =a.GetComponent<Button>();
      at = GameObject.Find("aText").GetComponent<Text>();
      //a-1 샤워부스 선반
      a1 = GameObject.Find("a1");
      a1B =a1.GetComponent<Button>();
      a1t = GameObject.Find("a1Text").GetComponent<Text>();
      //a-1-1 샴푸
      a11 = GameObject.Find("a11");
      a11B =a11.GetComponent<Button>();
      a11t = GameObject.Find("a11Text").GetComponent<Text>();
      //a-1-2 린스
      a12 = GameObject.Find("a12");
      a12B =a12.GetComponent<Button>();
      a12t = GameObject.Find("a12Text").GetComponent<Text>();
      //a-1-3 바디워시
      a13 = GameObject.Find("a13");
      a13B =a13.GetComponent<Button>();
      a13t = GameObject.Find("a13Text").GetComponent<Text>();
      //a-1-4 스페어키
      a14 = GameObject.Find("a14");
      a14B =a14.GetComponent<Button>();
      a14t = GameObject.Find("a14Text").GetComponent<Text>();
      //b
      b = GameObject.Find("b");
      bB =b.GetComponent<Button>();
      bt = GameObject.Find("bText").GetComponent<Text>();
      //c
      c = GameObject.Find("c");
      cB =c.GetComponent<Button>();
      ct = GameObject.Find("cText").GetComponent<Text>();
      //d
      d = GameObject.Find("d");
      dB =d.GetComponent<Button>();
      dt = GameObject.Find("dText").GetComponent<Text>();
      //d1
      d1 = GameObject.Find("d1");
      d1B =d.GetComponent<Button>();
      d1t = GameObject.Find("d1Text").GetComponent<Text>();
      //d2
      d2 = GameObject.Find("d2");
      d2B =d2.GetComponent<Button>();
      d2t = GameObject.Find("d2Text").GetComponent<Text>();
      //d3
      d3 = GameObject.Find("d3");
      d3B =d.GetComponent<Button>();
      d3t = GameObject.Find("dText").GetComponent<Text>();
      //d4
      d4 = GameObject.Find("d4");
      d4B =d4.GetComponent<Button>();
      d4t = GameObject.Find("d4Text").GetComponent<Text>();
      //d5
      d5 = GameObject.Find("d5");
      d5B =d.GetComponent<Button>();
      d5t = GameObject.Find("dText").GetComponent<Text>();
      //e
      e = GameObject.Find("e");
      eB =e.GetComponent<Button>();
      et = GameObject.Find("eText").GetComponent<Text>();
      //f
      f = GameObject.Find("f");
      fB =f.GetComponent<Button>();
      ft = GameObject.Find("fText").GetComponent<Text>();
    }
    void Start()
    {
        Debug.Log("scene1-8 is started "+num);
        StartCoroutine(coroutine);

        //choice1
        choice1t.text=" ";
        choice1B.interactable=false;
        choice1B.onClick.AddListener(text_1_8.choice1활성화);
        //a (1) 샤워부스
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text_1_8.a활성화);
        //a-1 샤워부스 선반
        a1t.text=" ";
        a1B.interactable=false;
        a1B.onClick.AddListener(text_1_8.a1활성화);
        //a-1-1 샴푸
        a11t.text=" ";
        a11B.interactable=false;
        a11B.onClick.AddListener(text_1_8.a11활성화);
        //a-1-2 린스
        a12t.text=" ";
        a12B.interactable=false;
        a12B.onClick.AddListener(text_1_8.a12활성화);
        //a-1-3 바디워시
        a13t.text=" ";
        a13B.interactable=false;
        a13B.onClick.AddListener(text_1_8.a13활성화);
        //a-1-4 스페어키
        a14t.text=" ";
        a14B.interactable=false;
        a14B.onClick.AddListener(text_1_8.a14활성화);
        //b
        bt.text="";
        bB.interactable=false;
        bB.onClick.AddListener(text_1_8.b활성화);
        //c
        ct.text=" ";
        cB.interactable=false;
        cB.onClick.AddListener(text_1_8.c활성화);
        //d
        dt.text=" ";
        dB.interactable=false;
        dB.onClick.AddListener(text_1_8.d활성화);
        //e
        et.text=" ";
        eB.interactable=false;
        eB.onClick.AddListener(text_1_8.d활성화);
        //f
        ft.text=" ";
        fB.interactable=false;
        fB.onClick.AddListener(text_1_8.f활성화);
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
          선택지활성화();
          스킵.interactable=false;
          num++;


            //StartCoroutine(coroutine1);
        }
        if(num==5){
            StartCoroutine(coroutine1);
            num++;
            스킵.interactable=true;

        }
        if(num==8){
            StartCoroutine(coroutine2);
            num++;
            스킵.interactable=false;
            //기본오브젝트 하위 오브젝트는 잠시 비활성화 SetActive(false)


        }
        if(num==10){
          object활성화();
          스킵.interactable=false;
        }
        //object1~6 기본멘트
        //object1 : (1)샤워부스 조사멘트
        if(num==11){
          a1.SetActive(true);
          a활성화();
          StartCoroutine(object1);
          기본오브젝트삭제();
          num++;

        }
        if(num==13){
          a1t.text="(1)-1 샤워 부스 선반";
          a1B.interactable=true;
        }
        if(num==14){
          //object1 : (1)샤워부스선반 조사멘트
          StartCoroutine(object11);
          선택지활성화();
          num++;
        }
        if(num==17){
          StartCoroutine(object111);
          num++;
        }
        if(num==20){
          StartCoroutine(object112);
          num++;
        }
        if(num==23){
          StartCoroutine(object113);
          num++;
        }
        if(num==26){
          StartCoroutine(object114);
          num++;
        }
        /////////////////////////////////////
        if(num==29){
          StartCoroutine(object2);
          기본오브젝트삭제();
          num++;
        }
        if(num==31){
          object활성화();
        }
        if(num==32){
          StartCoroutine(object3);
          기본오브젝트삭제();
          num++;
        }
        if(num==34){
          object활성화();

        }
        if(num==35){
          StartCoroutine(object4);
          기본오브젝트삭제();
          num++;
        }
        if(num==38){
          StartCoroutine(object41);

        }
        if(num==41){
          StartCoroutine(object42);
          num++;
        }
        if(num==44){
          StartCoroutine(object43);
          num++;
        }
        if(num==47){
          StartCoroutine(object44);
          num++;
        }
        if(num==50){
          StartCoroutine(object5);
          num++;
        }
        if(num==53){
          StartCoroutine(object6);
          num++;
        }
        if(num==56){
          StartCoroutine(object61);
          num++;
        }
        if(num==59){
          StartCoroutine(object62);
          num++;
        }




    }
    }
    // GameObject kkk = GameObject.Find("kkk");
    // Button kkkB =kkk.GetComponent<Button>();
    // Text kkkt = GameObject.Find("kkkText").GetComponent<Text>();
    // kkkt.text=" ";
    // kkkB.interactable=false;
    // kkkB.onClick.AddListener(text_1_8.kkk활성화);
