using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text_1_4: MonoBehaviour
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





    public static void a활성화(){
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      num=2;
      at.text=" ";
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


    //a. 카라에게 무슨 일인지 물어본다.
    private static string text_1="\"카라,\n무슨 일이야 이게?\"";
    private static string text_2="\"작업실 쪽에서 \n누전이 일어난 것 같습니다. \n금방 복구할 수 있도록 \n조치해두었으니, \n너무 걱정하지 않으셔도 \n될 것 같습니다.\"";
    private static string text_3="인공지능이 관리하는\n스마트홈에서 정전이라니.....\n듣기 싫은 경고음이 \n불규칙적으로 울리고 \n다시 머리가 욱신거린다.";
    private static string text_4="\"저 경고음은 끌 수 없어?\"";
    private static string text_5="\"......\"";
    private static string text_6="\"카라?\"";
    private static string text_7="\"카라?\"";
    private static string text_8="소음이 점점 커진다.\n이제는 소음이 귓가에서 \n울리는 게 아니라 \n머릿속을 파고드는 것만 같다.";
    private static string text_9="비상 전력으로 돌아가는\n벽면의 햇살이 거울에 반사되어 \n섬광을 피하려고 내려다본\n바닥엔 오직,\n심해의 캄캄한 어둠뿐이다.";
    private static string text_10="'너는 늘 그 고집이 문제야'\n‘그러니까 왜 말을 안 들어서\n이 사단을.....'";
    private static string text_11="\"고개를 드세요.\"";
    private static string text_12="\"카라...?\"";
    private static string text_13="\"고개를 드세요. 주인님.\n본인이 무슨 짓을 했는지\n마주할 용기는 있어야죠.\"";
    //b
    private static string text_14="샤워 부스 옆 비데는\n빨간 불빛과 함께 \n듣기 싫은 경고음을 \n불규칙적으로 내고 있었다.\n\n비데 앞에 서니\n여느 때와 다름없이 \n뚜껑이 자동으로 열렸다.";
    private static string text_15="그러나 비데 안의 물은 \n비상 전력으로 돌아가는 \n희미한 불빛 아래서도\n선명한 선홍색이었다";
    private static string text_16="문득, 스마트홈 인공지능을 \n일반 집보다 정전 및 단수 사고가 \n120배 적게 발생하도록 \n설계하는 데 성공했다는\n동료 연구원의 이야기가 떠올랐다.";
    private static string text_17="그는 내 손을 붙잡고 \n이제 전기 엔지니어 스무 명이면 \n전국을 관리할 수 있다며 \n기뻐했었다. \n그의 아버지가 평생을 \n전기 엔지니어로 사셨음에도.";
    private static string text_18="나는 습관처럼 \n손톱을 물어뜯었다.\n새하얀 왼손 의수에 \n엄지손가락에서 떨어진 핏방울이 \n독을 품은 꽃잎처럼 퍼졌다.";
    private static string text_19="\"너 때문이야\"";
    private static string text_20="갑자기 뒤편에서 날카로운 비명이 들렸다.";
    private static string text_21="\"엄마....?\"";



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
    static IEnumerator coroutine19 = Typing(text_20);
    static IEnumerator coroutine20=  Typing(text_21);




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_4.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1-4 is started "+num);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="A.카라에게 무슨 일인지 물어본다. ";
        aB.interactable=true;
        aB.onClick.AddListener(text_1_4.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 비데에 가까이 다가가서 확인해 본다.";
        bB.interactable=true;
        bB.onClick.AddListener(text_1_4.b활성화);

    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            StartCoroutine(coroutine);
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
          StartCoroutine(coroutine3);
          num++;
        }
        if(num==14){
          StartCoroutine(coroutine4);
          num++;
        }
        if(num==17){
          StartCoroutine(coroutine5);
          num++;
        }
        if(num==20){
          StartCoroutine(coroutine6);
          num++;
        }
        if(num==23){
          StartCoroutine(coroutine7);
          num++;
        }
        if(num==26){
          StartCoroutine(coroutine8);
          num++;
        }
        if(num==29){
          StartCoroutine(coroutine9);
          num++;
        }
        if(num==32){
          StartCoroutine(coroutine10);
          num++;
        }
        if(num==35){
          StartCoroutine(coroutine11);
          num++;
        }
        if(num==38){
          StartCoroutine(coroutine12);
          num++;
        }
        if(num==41){
          SceneManager.LoadScene("1-5");//fadeout -> anim -> 1-6(video)
          num++;
        }
        if(num==44){
          StartCoroutine(coroutine13);
          num++;
        }
        if(num==47){
          StartCoroutine(coroutine14);
          num++;
        }
        if(num==50){
          StartCoroutine(coroutine15);
          num++;
        }
        if(num==53){
          StartCoroutine(coroutine16);
          num++;
        }
        if(num==56){
          StartCoroutine(coroutine17);
          num++;
        }
        if(num==59){
          StartCoroutine(coroutine18);
          num++;
        }
        if(num==62){
          StartCoroutine(coroutine19);
          num++;
        }
        if(num==65){
          StartCoroutine(coroutine20);
          num++;
        }
        if(num==68){
          SceneManager.LoadScene("1-4-2");
          num++;
        }







    }
    }
