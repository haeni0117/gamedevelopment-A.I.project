using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text2_2: MonoBehaviour
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
    //서랍장 조사 여부
    private static bool d1=false;
    private static bool d2=false;
    private static bool d3=false;


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
        at.text="(1) 서랍장 1층";
        aB.interactable=true;
        aB.onClick.AddListener(text2_2.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="(2) 서랍장 2층";
        bB.interactable=true;
        bB.onClick.AddListener(text2_2.b활성화);

        //c
        GameObject c = GameObject.Find("c");
        Button cB =c.GetComponent<Button>();
        Text ct = GameObject.Find("cText").GetComponent<Text>();
        ct.text="(3) 서랍장 3층";
        cB.interactable=true;
        cB.onClick.AddListener(text2_2.c활성화);
    }





    public static void a활성화(){
      //a - 1층 서랍장
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      //b - 2층 서랍장
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      //c - 3층 서랍장
      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      //서랍장 선택지
      aB.interactable=false;
      bB.interactable=false;
      cB.interactable=false;
      d1=true;

      num=2;
    }

    public static void b활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      aB.interactable=false;
      bB.interactable=false;
      cB.interactable=false;
      d2=true;

      num =5;
    }

    public static void c활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      aB.interactable=false;
      bB.interactable=false;
      cB.interactable=false;
      d3=true;

      num = 8;
    }


    //a. 카라에게 무슨 일인지 물어본다.
    private static string text_1="사용하는 서랍이라고는 \n믿을 수 없을 정도로 \n텅 비어있다.";
    private static string text_2="사용하는 서랍이라고는 \n믿을 수 없을 정도로 \n텅 비어있다.";
    private static string text_3="이 집으로 이사 올 때 \n안전을 위해서 사 둔 호신용품이다. \n다행히 아직 사용할 일이 없어서 \n서랍장에 넣어 두고 잊고 있었다.\n{전기 충격기를 획득했다.}";




    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);





    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_4_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1-4-2 is started "+num);
        StartCoroutine(coroutine);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="";
        aB.interactable=false;
        aB.onClick.AddListener(text_1_4_2.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="";
        bB.interactable=false;
        bB.onClick.AddListener(text_1_4_2.b활성화);

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
        if(d1&&d2&&d3){
          SceneManager.LoadScene("2-3");
        }


    }
    }
