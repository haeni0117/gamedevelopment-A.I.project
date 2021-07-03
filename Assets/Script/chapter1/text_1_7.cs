using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_1_7 : MonoBehaviour
{

    public static int num = 0;
    public static GameObject button_;
    //public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;
    private static bool A=false;
    private static bool B=false;
    private static bool C=false;

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
    //스킵버튼
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    public static void 선택지활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      at.text="엄마";
      aB.interactable=true;


      //(아ㅃ
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      bt.text="아빠";
      bB.interactable=true;


      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      ct.text="오빠";
      cB.interactable=true;

    }
    public static void a활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      aB.interactable=false;


      //(아ㅃ
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      bB.interactable=false;

      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      cB.interactable=false;

  //skipButton -> definition
     Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
     //adlistner로 불러오려면 static void여야 한다.
     스킵.interactable=true;


     num = 2;

    }
    public static void b활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      aB.interactable=false;


      //(아ㅃ
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      bB.interactable=false;


      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      cB.interactable=false;

  //skipButton -> definition
     Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
     //adlistner로 불러오려면 static void여야 한다.
     스킵.interactable=true;


     num = 14;


    }
    public static void c활성화(){
      GameObject a = GameObject.Find("a");
      Button aB =a.GetComponent<Button>();
      Text at = GameObject.Find("aText").GetComponent<Text>();
      aB.interactable=false;


      //(아ㅃ
      GameObject b = GameObject.Find("b");
      Button bB =b.GetComponent<Button>();
      Text bt = GameObject.Find("bText").GetComponent<Text>();
      bB.interactable=false;


      GameObject c = GameObject.Find("c");
      Button cB =c.GetComponent<Button>();
      Text ct = GameObject.Find("cText").GetComponent<Text>();
      cB.interactable=false;

  //skipButton -> definition
     Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
     //adlistner로 불러오려면 static void여야 한다.
     스킵.interactable=true;


     num=23;


    }
    //mom
    private static string text_1="\"누구야...?\"";
    private static string text_2="\"다 너 때문이야. 네가 그러지만 않았어도, \n우리는 모두 살 수 있었어. \n다 네가, 네가 고집을 부려서 우리 현이가....\"";
    private static string text_3="엄마는 대답 대신 구겨진 보닛 사이에 낀 왼 다리를 \n피가 나도록 긁기 시작한다.\n나는 도망치고 싶다고 생각하지만, \n절망감이 켜켜이 쌓인 목소리로 나를 비난하는 \n엄마의 눈동자를 벗어날 수가 없다.";
    private static string text_4="\"엄마, 그게 무슨 말이야, 다 내 탓이라니......\n엄마, 대답 좀 해봐! 엄마!\"";
    private static string text_5="나는 다리를 긁는 엄마를 말리기 위해 손을 뻗는다. \n하지만 엄마를 잡는 것은, \n손이 아닌 뭉툭하게 잘린 손목뿐이다. \n아직 남아있는 손가락의 감각을 되살려보려고 애쓰지만,\n결국 피가 튀는 손목으로 \n허공을 허우적대는 걸 그만둔다.";
    //dad
    private static string text_6="다 너 때문이야. \n어렸을 때부터 내 말을 그렇게도 안 듣더니, \n결국 기어코 일을 저지르는구나. \n네가 다 망친 거야. \n내 꿈도, 직장도, 가정도 네가 다......”";
    private static string text_7="\"캐니언 오토는 내 꿈을 이룰 수 있는 절호의 기회였어! \n캐니언 오토가 성공했다면, \n평생 허름한 사무실에 박혀서 \n풋내기들이나 가르치진 않았을 거다! \"";
    private static string text_8="사소한 실수 하나로 모든 걸 날려버리다니......\n내가 다 고칠 수 있었는데, \n그 망할 놈의 기자들 때문에, \n다 너 때문에......\"";
    //bro
    private static string text_9="\"다 너 때문이야. \n너 때문에 내가 죽은 거야. \n고작 15살밖에 안 된 내가, \n이렇게 처참한 몰골로 죽은 건 \n다 너 때문이야.\"";
    private static string text_10="\"내가 그런 게 아니야, \n나는, 나는 그러려고 그런 게....\"";
    private static string text_11="나는 이 끔찍한 악몽을 \n몇 번의 손사래로 물리칠 수 있다는 듯이 \n유약한 몸뚱이로 세차게 저항하지만, \n오빠의 핏발 선 눈초리는 점점 따가워지고, \n물귀신처럼 끈질기게 나를 뒤쫓는다.";
    private static string text_12="\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"";

    private static string text_13="온몸이 뒤틀린 가족들에게 나도 왼손을 잃었다고, \n운전을 한 사람은 내가 아니라고 외치고 싶지만, \n까맣게 칠해진 유년의 기억 속에서 \n새빨간 의심이 고개를 들고 속삭인다.";
    private static string text_14="\n사실 네가 잘못한 게 맞을 거라고. \n이 모든 참상은 다 너 때문이라고. \n그래서 나 같은 건 죽어 마땅할지도 모른다고. ";
    private static string text_15="\"그래, 어쩌면 나 같은 건.....\"";
    private static string text_16="손목의 잘린 단면을 타고 \n손바닥 모양의 푸른빛이 잠깐 나타났다 사라지고,\n노이즈 섞인 목소리가 손을 타고 흘러나온다.";
    private static string text_17="\"...을...요.\"";
    private static string text_18="\"뭐라고?\"";

    private static string text_19="아직도 피가 흐르는 손목에 귀를 갖다 대자 \n카라의 목소리가 들린다.";
    private static string text_20="\"홀로...을...꺼요!\"";
    private static string text_21="죽은 오빠가 입을 벙긋거리고, \n잘린 손목은 아프지 않고,\n아무리 비가 거세져도 발밑으로 물이 고이지 않아.\n빗소리를 뚫고 오빠가 악에 받쳐 소리친다.";
    private static string text_22="\"네가 지은 죄는 절대로 용서받을 수 없어! \n왜냐면 이건 다.\"";
    private static string text_23="\"환각이니까\"";
    private static string text_24="거울을 내리친다.";
    private static string text_25="나는 번쩍이는 푸른빛을 그러모아 주먹을 쥐고 \n자동차를 힘껏 내리쳤다.";


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
    static IEnumerator coroutine20 = Typing(text_21);
    static IEnumerator coroutine21 = Typing(text_22);
    static IEnumerator coroutine22 = Typing(text_23);
    static IEnumerator coroutine23 = Typing(text_24);
    static IEnumerator coroutine24 = Typing(text_25);


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene 5-1 is started");
        //엄마
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="엄마";
        aB.interactable=true;
        aB.onClick.AddListener(text_1_7.a활성화);

        //(아ㅃ
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="아빠";
        bB.interactable=true;
        bB.onClick.AddListener(text_1_7.b활성화);

        GameObject c = GameObject.Find("c");
        Button cB =c.GetComponent<Button>();
        Text ct = GameObject.Find("cText").GetComponent<Text>();
        ct.text="오빠";
        cB.interactable=true;
        cB.onClick.AddListener(text_1_7.c활성화);
    //skipButton -> definition
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       //adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;
       스킵.onClick.AddListener(text_1_7.스킵버튼클릭);
       StartCoroutine(coroutine);


    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(num);
        if(num==2){
            num++;
            Debug.Log("coroutine is started!  num : "+num);
            StartCoroutine(coroutine1);

            //StartCoroutine(coroutine1);
        }
        if(num==5){
            num++;
            Debug.Log("coroutine is started!  num : "+num);
            StartCoroutine(coroutine2);



        }
        if(num==8){
            num++;
            Debug.Log("coroutine is started!  num : "+num);
            StartCoroutine(coroutine3);

        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num : "+num);
            num++;
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            //adlistner로 불러오려면 static void여야 한다.
            스킵.interactable=false;
            선택지활성화();
            A=true;
        }
        if(num==14){
            num++;
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num : "+num);
            //activate button
        }
        if(num==17){
          StartCoroutine(coroutine6);
          Debug.Log("coroutine is started!  num : "+num);
          num++;
        }
        if(num==20){
          StartCoroutine(coroutine7);
          Debug.Log("coroutine is started!  num : "+num);
          num++;
          Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
          //adlistner로 불러오려면 static void여야 한다.
          스킵.interactable=false;
          선택지활성화();
          B=true;

        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num : "+num);
            num++;
        }
         if(num==26){
           StartCoroutine(coroutine9);
           Debug.Log("coroutine is started!  num : "+num);
           num++;
        }
        if(num==29){
          StartCoroutine(coroutine10);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==32){
          StartCoroutine(coroutine11);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

          Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
          //adlistner로 불러오려면 static void여야 한다.
          스킵.interactable=false;
          선택지활성화();
          C=true;


        }
        if(num==35){
          StartCoroutine(coroutine12);
          Debug.Log("coroutine is started!  num : "+num);
          num++;


        }
        if(num==38){
          StartCoroutine(coroutine13);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==41){
          StartCoroutine(coroutine14);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==44){
          StartCoroutine(coroutine15);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==47){
          StartCoroutine(coroutine16);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==50){
          StartCoroutine(coroutine17);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==53){
          StartCoroutine(coroutine18);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==56){
          StartCoroutine(coroutine19);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==59){
          StartCoroutine(coroutine20);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==62){
          StartCoroutine(coroutine21);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==65){
          StartCoroutine(coroutine22);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==68){
          StartCoroutine(coroutine23);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==71){
          StartCoroutine(coroutine24);
          Debug.Log("coroutine is started!  num : "+num);
          num++;

        }
        if(num==74){
          SceneManager.LoadScene("1-8");
        }
        if(text_1_7.A&& text_1_7.B&& text_1_7.C){

          if(num==12 || num==21 || num==33){
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            //adlistner로 불러오려면 static void여야 한다.
            num=34;
            스킵.interactable=true;

          }


        }
}
}
