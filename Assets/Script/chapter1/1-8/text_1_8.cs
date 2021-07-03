using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-8 화장실조사
public class text_1_8: MonoBehaviour
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
        at.text="a. 화장실 문을 확인한다.";
        aB.interactable=true;


        //b
        // GameObject b = GameObject.Find("b");
        // Button bB =b.GetComponent<Button>();
        // Text bt = GameObject.Find("bText").GetComponent<Text>();
        // bt.text="2. 나가지 않는다.";
        // bB.interactable=true;
        // bB.onClick.AddListener(text_1_2.b활성화);
    }








    public static void choice1활성화(){
      GameObject choice1 = GameObject.Find("choice1");
      Button choice1B =choice1.GetComponent<Button>();
      Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
      at.text=" ";
      choice1B.interactable=false;
      num=5;
      Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
      스킵.interactable=true;

    }

    // public static void b활성화(){
    //   GameObject a = GameObject.Find("a");
    //   Button aB =a.GetComponent<Button>();
    //   Text at = GameObject.Find("aText").GetComponent<Text>();
    //   GameObject b = GameObject.Find("b");
    //   Button bB =b.GetComponent<Button>();
    //   Text bt = GameObject.Find("bText").GetComponent<Text>();
    //   num=44;
    //   at.text=" ";
    //   aB.interactable=false;
    //   bt.text=" ";
    //   bB.interactable=false;
    // }


    //a. 카라에게 무슨 일인지 물어본다.
    private static string text_1="화장실은 여전히 정전이었다.\n하지만 산산조각 난 거울에 \n비상전력 전등의 \n희미한 불빛이 반사되어 \n앞이 보이지 않을 정도로 \n어둡지는 않았다.";
    private static string text_2="나는 상황을 파악하자마자 \n카라를 부르며 \n화장실 열림 버튼을 눌렀지만, \n의수에서 흘러나오는 \n파란 불빛만 깜빡일 뿐, \n카라도 7cm 두께의 \n원목 슬라이딩 도어도 \n아무런 반응이 없었다.";
    private static string text_3="일단은 여기를 \n빠져나가야 한다. \n문을 열 수 있는 \n도구를 찾아보자.";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);

    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_8.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1-8is started "+num);
        StartCoroutine(coroutine);

        //choice1
        GameObject a = GameObject.Find("a");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text=" ";
        choice1B.interactable=false;
        choice1B.onClick.AddListener(text_1_8.choice1활성화);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text_1_8.a활성화);


        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="";
        bB.interactable=false;
        bB.onClick.AddListener(text_1_4_2.b활성화);

        //c
        GameObject c = GameObject.Find("c");
        Button cB =c.GetComponent<Button>();
        Text ct = GameObject.Find("cText").GetComponent<Text>();
        ct.text=" ";
        cB.interactable=false;
        cB.onClick.AddListener(text_1_8.c활성화);

        //d
        GameObject d = GameObject.Find("d");
        Button dB =d.GetComponent<Button>();
        Text dt = GameObject.Find("dText").GetComponent<Text>();
        dt.text=" ";
        dB.interactable=false;
        dB.onClick.AddListener(text_1_8.d활성화);

        //e
        GameObject e = GameObject.Find("e");
        Button eB =e.GetComponent<Button>();
        Text et = GameObject.Find("eText").GetComponent<Text>();
        et.text=" ";
        eB.interactable=false;
        eB.onClick.AddListener(text_1_8.d활성화);

        //f
        GameObject f = GameObject.Find("f");
        Button fB =f.GetComponent<Button>();
        Text ft = GameObject.Find("fText").GetComponent<Text>();
        ft.text=" ";
        fB.interactable=false;
        fB.onClick.AddListener(text_1_8.f활성화);



    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
          선택지활성화();
          Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
          스킵.interactable=false;
          num++;

            //StartCoroutine(coroutine1);
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
            SceneManager.LoadScene("1-9");
            num++;
          }


    }
    }
    GameObject kkk = GameObject.Find("kkk");
    Button kkkB =kkk.GetComponent<Button>();
    Text kkkt = GameObject.Find("kkkText").GetComponent<Text>();
    kkkt.text=" ";
    kkkB.interactable=false;
    kkkB.onClick.AddListener(text_1_8.kkk활성화);
