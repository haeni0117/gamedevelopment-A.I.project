using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text_1_9: MonoBehaviour
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

    //basic component
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;


    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    //choice1activation
    public static void 선택지활성화(){
        //objects are showed
        //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="1. 문을 열고 나간다. ";
        aB.interactable=true;
        aB.onClick.AddListener(text_1_2.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="2. 나가지 않는다.";
        bB.interactable=true;
        bB.onClick.AddListener(text_1_2.b활성화);
    }





    public static void a활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=41;
      at.text="";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void a1활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=41;
      at.text="";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void a11활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=41;
      at.text="";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void a12활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=41;
      at.text="";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void a13활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=41;
      at.text="";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void a14활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=41;
      at.text="";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }

    public static void b활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      num=44;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void c활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      num=44;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void d활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      num=44;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void e활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      num=44;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }
    public static void f활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      num=44;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }


    //a. 카라에게 무슨 일인지 물어본다.
    private static string text_1="안방 화장실을 조사한다.";
    //(1) 샤워부스
    private static string text_2="해바라기 샤워기가 달린 \n샤워 부스다. \n가끔 따뜻한 물을 맞으며 \n사색에 잠기곤 한다.";
    //(1)-1 샤워부스 선반
    private static string text_3="샤워할 때 필요한 물품을 \n얹어 놓은 선반이다.";
    //(1)-1-1 샴푸
    private static string text_4="화이트 머스크 향 샴푸다. \n제일 좋아하는 향이다.";
    //(1)-1-2 린스
    private static string text_5="화이트 머스크 향 린스다.\n샴푸와 같은 브랜드의 것이다.";
    //(1)-1-3 바디워시
    private static string text_6="코코넛 향의 바디워시다. \n별로 좋아하는 향은 아니지만....\n선물 받은 거라 그냥 쓰고 있다";
    //(1)-1-4 스페어키
    private static string text_7="화장실 문을 열 수 있는 \n스페어 키다. \n내가 이걸 왜 여기다가 뒀을까.\n{스페어 키를 획득했다.} ";
    //(2)ioT비데
    private static string text_8="하얀색 비데다.\n별로 뚜껑을\n열고 싶지 않다.";
    //(3)발 매트
    private static string text_9="샤워할 때 \n미끄러지지 않기 위해 놓은 \n발 매트다. \n이상하게 한쪽 구석이 불룩하다.\n매트를 들어보니 \n고양이 장난감이 놓여있다.\n시루가 장난감을 물고\n들어왔던 모양이다\n{고양이 장난감을 획득했다!}";
    //(4)거울과 선반
    private static string text_10="깨진 거울 뒤로 선반이 보인다.\n자주 쓰는 물건들을 넣어두었다.";
    //(4)-1 약
    private static string text_11="주기적으로 복용하는 약이다. \n병 겉면에 ‘비타센’이라고 \n적혀 있다.\n{비타센을 획득했다!}";
    //(4)-2 치약
    private static string text_12="반쯤 쓴 치약의 뒷부분이 \n말려 올라가 있다.";
    //(4)-3 휴지
    private static string text_13="여분의 휴지이다.\n 필요할 때마다 꺼내 쓸 수 있다.";
    //(4)-4 면도기
    private static string text_14="날이 날카롭게 갈린 면도기이다. \n자칫 잘못 만지면 베일 것 같다.";
    //(4)-5 드라이어
    private static string text_15="미용실에서 쓰는 것과 같은 \n모델의 드라이어다. \n바람이 아주 강력하다.";
    //(5) 세면대
    private static string text_16="새하얗고 물 때 하나 \n끼지 않은 세면대다.";
    //(6) 수건받침대
    private static string text_17="은색의 철제 수건 받침대이다. \n샤워하기 전에 \n수건을 걸어 놓는 용도로 쓴다.";
    //(6)-1 수건
    private static string text_18="폭신하고 커다란 수건이다.";
    //(6)-2 코트
    private static string text_19="어제 입고 나갔던 코트다. \n내가 이걸 수건 받침대에 \n걸어 놓은 것 같다. \n주머니가 불룩한데 뭐지?\n\n{변환 젠더를 획득했다!}";



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);
    static IEnumerator coroutine10 = Typing(text_11);
    static IEnumerator coroutine11 = Typing(text_12);
    static IEnumerator coroutine12 = Typing(text_13);
    static IEnumerator coroutine13 = Typing(text_14);
    static IEnumerator coroutine14 = Typing(text_15);
    static IEnumerator coroutine15 = Typing(text_16);
    static IEnumerator coroutine16 = Typing(text_17);
    static IEnumerator coroutine17 = Typing(text_18);
    static IEnumerator coroutine18 = Typing(text_19);





    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_9.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1-4-2 is started "+num);
        StartCoroutine(coroutine);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="";
        aB.interactable=false;
        aB.onClick.AddListener(text_1_9.a활성화);
        //a-1
        GameObject a1 = GameObject.Find("a1");
        Button a1B =a1.GetComponent<Button>();
        Text a1t = GameObject.Find("a1Text").GetComponent<Text>();
        a1t.text="";
        a1B.interactable=false;
        a1B.onClick.AddListener(text_1_9.a1활성화);
        //a-1-1
        GameObject a11 = GameObject.Find("a11");
        Button a11B =a11.GetComponent<Button>();
        Text a11t = GameObject.Find("a11Text").GetComponent<Text>();
        a11t.text="";
        a11B.interactable=false;
        a11B.onClick.AddListener(text_1_9.a11활성화);

        //a-1-2
        GameObject a12 = GameObject.Find("a12");
        Button a12B =a12.GetComponent<Button>();
        Text a12t = GameObject.Find("a12Text").GetComponent<Text>();
        a12t.text="";
        a12B.interactable=false;
        a12B.onClick.AddListener(text_1_9.a12활성화);

        //a-1-3
        GameObject a13 = GameObject.Find("a13");
        Button a13B =a13.GetComponent<Button>();
        Text a13t = GameObject.Find("a13Text").GetComponent<Text>();
        a13t.text="";
        a13B.interactable=false;
        a13B.onClick.AddListener(text_1_9.a13활성화);
        //a-1-4
        GameObject a14 = GameObject.Find("a14");
        Button a14B =a14.GetComponent<Button>();
        Text a14t = GameObject.Find("a14Text").GetComponent<Text>();
        a14t.text="";
        a14B.interactable=false;
        a14B.onClick.AddListener(text_1_9.a14활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="";
        bB.interactable=false;
        bB.onClick.AddListener(text_1_9.b활성화);

        //C
        GameObject c= GameObject.Find("c");
        Button cB =c.GetComponent<Button>();
        Text ct = GameObject.Find("cText").GetComponent<Text>();
        ct.text="";
        cB.interactable=false;
        cB.onClick.AddListener(text_1_9.c활성화);

        //d
        GameObject d = GameObject.Find("d");
        Button dB =d.GetComponent<Button>();
        Text dt = GameObject.Find("dText").GetComponent<Text>();
        dt.text="";
        dB.interactable=false;
        dB.onClick.AddListener(text_1_9.d활성화);

        //e
        GameObject e = GameObject.Find("e");
        Button eB =e.GetComponent<Button>();
        Text et = GameObject.Find("eText").GetComponent<Text>();
        et.text="";
        eB.interactable=false;
        eB.onClick.AddListener(text_1_9.e활성화);

        //f
        GameObject f = GameObject.Find("f");
        Button fB =f.GetComponent<Button>();
        Text ft = GameObject.Find("fText").GetComponent<Text>();
        ft.text="";
        fB.interactable=false;
        fB.onClick.AddListener(text_1_9.f활성화);

    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
          StartCoroutine(coroutine1);
          num++;
            //StartCoroutine(coroutine1);
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
        }
        if(num==17){
          StartCoroutine(coroutine6);
          num++;
        }
        if(num==20){
          StartCoroutine(coroutine7);
          num++;
        }
        if(num==23){
          StartCoroutine(coroutine8);
          num++;
        }
        if(num==26){
          StartCoroutine(coroutine9);
          num++;
        }
        if(num==29){
          StartCoroutine(coroutine10);
          num++;
        }
        if(num==32){
          StartCoroutine(coroutine11);
          num++;
        }
        if(num==35){
          StartCoroutine(coroutine12);
          num++;
        }
        if(num==38){
          선택지활성화();
        }
        if(num==41){
          //1. 문을 열고 나간다.
          StartCoroutine(coroutine13);
          num++;
        }
        if(num==44){
          StartCoroutine(coroutine14);
          num++;
        }
        if(num==47){
          //문을 열고 나간다는 어디로 이어지는 선택지??
          Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
          스킵.interactable=false;
        }
        if(num==50){
          SceneManager.LoadScene("1-5");
          num++;
        }

    }
    }
