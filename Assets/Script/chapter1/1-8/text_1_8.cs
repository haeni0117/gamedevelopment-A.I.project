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
        aB.onClick.AddListener(text_1_8.a활성화);

        //b
        // GameObject b = GameObject.Find("b");
        // Button bB =b.GetComponent<Button>();
        // Text bt = GameObject.Find("bText").GetComponent<Text>();
        // bt.text="2. 나가지 않는다.";
        // bB.interactable=true;
        // bB.onClick.AddListener(text_1_2.b활성화);
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
    private static string text_1="화장실은 여전히 정전이었다.\n하지만 산산조각 난 거울에 \n비상전력 전등의 \n희미한 불빛이 반사되어 \n앞이 보이지 않을 정도로 \n어둡지는 않았다.";
    private static string text_2="나는 상황을 파악하자마자 \n카라를 부르며 \n화장실 열림 버튼을 눌렀지만, \n의수에서 흘러나오는 \n파란 불빛만 깜빡일 뿐, \n카라도, \n7cm 두께의 원목 슬라이딩 도어도 \n아무런 반응이 없다.";
    private static string text_3="일단은 여기를 \n빠져나가야 한다. \n문을 열 수 있는 \n도구를 찾아보자.";
    private static string text_4="\"너 때문이야!\"";
    private static string text_5="\"엄마...?\"";
    private static string text_6="\"다 너 때문이야. \n네가 그러지만 않았어도, 우리는 모두 살 수 있었어. \n다 네가, 네가 고집을 부려서 우리 현이가....\"";
    private static string text_7="나는 엄마에게 무슨 말을 하는 거냐고 묻지만 \n엄마는 대답 대신 구겨진 보닛 사이에 낀\n왼 다리를 피가 나도록 긁기 시작한다.";
    private static string text_8="도망치고 싶다. 너무 간절하게, \n이 악몽에서 벗어나고 싶다.\n하지만 절망감이 켜켜이 쌓인 목소리로 나를 비난하는 \n엄마의 눈동자를 벗어날 수가 없다.";
    private static string text_9="\"엄마, 그게 무슨 말이야, 다 내 탓이라니.....\n엄마, 대답 좀 해봐! 엄마!\"";
    private static string text_10="나는 다리를 긁는 엄마를 말리기 위해 손을 뻗는다. \n하지만 엄마를 잡는 것은 손이 아닌 \n뭉툭하게 잘린 손목뿐이다. ";
    private static string text_11="아직 남아있는 손가락의 감각을 되살려보려고 애쓰지만,\n결국 피가 솟구치는 손목으로 \n허공을 허우적대는 걸 그만둔다. ";
    private static string text_12="\"도망가고 싶어.\"";
    private static string text_13="옆으로 고개를 돌리니 \n까만 배경 사이로 손잡이가 보인다.";
    //b-환각 1. 문을 열고 나간다.
    private static string text_14="보기만 해도 추워지는 차가운 파란색 도기 타일. \n정전으로 캄캄한 화장실을 \n희미하게 비추는 비상 전력 전등. \n시끄러운 경고음을 내며 \n깜빡이는 비데의 빨간 불빛.";
    private static string text_15="드디어 돌아왔다. \n아니, 도망쳤다.\n습기가 완벽하게 제거된 \n좁은 샤워 부스 안으로.";




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




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_8.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1-8is started "+num);
        StartCoroutine(coroutine);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="";
        aB.interactable=false;
        aB.onClick.AddListener(text_1_8.a활성화);

        // //b
        // GameObject b = GameObject.Find("b");
        // Button bB =b.GetComponent<Button>();
        // Text bt = GameObject.Find("bText").GetComponent<Text>();
        // bt.text="";
        // bB.interactable=false;
        // bB.onClick.AddListener(text_1_4_2.b활성화);

    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
          선택지활성화();
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
