using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text_1_2: MonoBehaviour
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
        at.text="A. 그래. 고마워. ";
        aB.interactable=true;
        aB.onClick.AddListener(text_1_2.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 엄마가? 아침에? 무슨일로?";
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
      num=5;
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
      num=32;
      at.text=" ";
      aB.interactable=false;
      bt.text=" ";
      bB.interactable=false;
    }



    private static string text_1="드디어 일어나셨군요.\n어머니께 전화가 왔습니다.\n지금 확인하시겠습니까?";
    //a. 그래 고마워.
    private static string text_2="<부재중 기록 확인>";
    private static string text_3="\"왜 오늘 같은 날 \n전화를 안 받니?\n설마 평일인데 7시 넘어서까지 \n자는 건 아니겠지?\n\n추모식이 4시부터 \n시립묘지에서 열리니까 \n오늘은 연차를 내든지 해서 \n꼭 오도록 해라.";
    private static string text_4="옷은 검은 색으로 \n깔끔하게 입고 오고,\n어떻게 떠난 아이인데......";
    private static string text_5="양심이 있으면 \n네가 저번처럼 늦지는 않겠지. \n연희 숙모랑 연준 삼촌도 \n온다고 했으니, \n엄마 창피하게 하지 마라. \n그러니까..... \n이만 끊는다.\n이따 보자.\"";
    private static string text_6="\"괜찮으십니까?\"";
    private static string text_7="\n멍하니 음성이 끊긴 전화기만 \n바라보다 카라의 말에\n정신이 들었다.";
    private static string text_8="오늘마저 늦으면 \n부모님은 두 번 다시 나를 \n보고 싶어 하지 않으실 것이다. \n갑작스럽게 반차라도 내려면 \n지각만은 피해야 했으므로 \n나는 급히 침대에서 내려와 \n화장실로 향했다.";
    //b. 엄마가? 아침에? 무슨일로?
    private static string text_9="\"저는 부재중 기록에 \n접근 권한이 없습니다. \n지금 권한을 \n해제하시겠습니까?\"";




    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);

    static IEnumerator coroutine8 = Typing(text_9);




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1 is started "+num);
        StartCoroutine(coroutine);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text_1_2.a활성화);

        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text=" ";
        bB.interactable=false;
        bB.onClick.AddListener(text_1_2.b활성화);

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
          SceneManager.LoadScene("1-2-2");//화장실씬으로 이동
        }
        if(num==29){
          StartCoroutine(coroutine8);
          num++;
        }
        if(num==32){
          SceneManager.LoadScene("1-2-1");//b선택지로 이동






    }
}}
