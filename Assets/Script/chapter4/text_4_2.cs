using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_4_2 : MonoBehaviour
{

  public static Text typingText;
  public static Text typingText2;
  public static Button 스킵;
  public static GameObject backbutton_;
  public static Button backbutton;
  public static Text backbuttont;

  //bool-> 오브젝트 조사여부
  public static bool a_inspection2=false;
  public static bool b_inspection2=false;
  public static bool c_inspection2=false;
  public static bool d_inspection2=false;
  public static bool e_inspection2=false;
  public static bool f_inspection2=false;
  public static bool g_inspection2=false;
  public static bool h_inspection2=false;
  public static bool f1_inspection2=false;
  public static bool f2_inspection2=false;
  public static bool e1_inspection2=false;
  public static bool e2_inspection2=false;
  public static bool e3_inspection2=false;



    public static int num = 0;
    public static GameObject fadeout;
    public static GameObject diary;
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
    public static GameObject e1;
    public static Button e1B;
    public static Text e1t;
    public static GameObject e2;
    public static Button e2B;
    public static Text e2t;
    public static GameObject e3;
    public static Button e3B;
    public static Text e3t;
//(6)사이드테이블
    public static GameObject f;
    public static Button fB;
    public static Text ft;

    public static GameObject f1;
    public static Button f1B;
    public static Text f1t;

    public static GameObject f2;
    public static Button f2B;
    public static Text f2t;
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
    private static string text_00="시루를 처음 만난 순간이\n머릿속을 빠르게 스쳤다.\n마음이 점점 급해진다.";
    private static string text_01="계단을 내려오자마자 \n베란다부터 살펴봤다. \n2층 베란다 난간 사이로 \n떨어진 건지 베란다 나무에 \n시루의 발톱 자국이 \n깊게 나 있다.";
    private static string text_1="시루는 나를 보자마자 문으로 \n다가와 가르랑거린다.\n\"다행이다, 무사하구나.\"\n그런데… 어딘가 불편해 보인다. \n걸음걸이가 이상해.\n언제부터 갇혀 있었던 걸까.";
    private static string text_2="시루의 행동이 눈에 띄게 둔해졌다.\n어서 베란다 문을 열어야 한다.";
    private static string text_3="역시나 잠겨 있다. \n잠금장치가 꼼짝도 하지 않는다.";
    private static string text_4="나는 페인트를 바른 듯 \n새하얗고 매끄러운 \n왼손을 바라보았다. \n의수를 사용하면, 문을 부수고 \n시루를 구할 수 있을지도 몰라.";
    private static string text_5="문을 부순다면 분명히 의수에 \n엄청난 충격이 가해질 것이다. \n정말 문을 부수는 것이\n옳은 선택일까?";
    private static string text_6="생명보다 중요한 건 없어. \n약속했잖아. 지켜주기로.";
    private static string text_7="나는 왼손 의수로 있는 힘껏 \n문을 내리쳤다. \n내리친 곳에 자글자글한 균열이 \n가더니 작은 조각들이 떨어졌다.\n나는 다시 한번 더 힘을 모아 \n문을 향해 돌진했다.";
    private static string text_8="문이 부서지면서 생긴 파편들이 \n의수와 왼팔 곳곳에 \n가시처럼 박혔다. \n유리가 깨져서 시루가 놀랐는지\n1층 베란다 나무를 타고 \n다시 2층 베란다로 도망갔다.";
    private static string text_9="나무에는 누구의 것인지 \n알 수 없는 핏자국이 흘렀다. \n나무가 찔려 피를 \n흘리는 것처럼 보였다.\n\n이런, 다시 올라가야 하나.";
    private static string text_10="유리를 깨면 시루가 \n놀랄지도 몰라. \n주변을 조사해 볼까.";
    private static string text_11="* 거실을 조사해 보자.";
    private static string text_12="다행히 2층에 올라가니 \n베란다 난간을 타고 \n시루가 집 안으로 들어와 있었다.\n나는 바로 시루에게 \n물과 사료를 먹이고 \n피가 나는 부위를 확인했다.\n앞 다리가 살짝 부어있는 것이 \n날카로운 물체에 긁힌 것 같았다.\n당장 생명에 지장이 있을 것 \n같지는 않지만 \n만약 금속 물체에 찔린 거라면 \n파상풍의 위험이 있었다.";
    private static string text_13="빨리 병원에 데리고 가야겠어.";
    static IEnumerator coroutine0=  Typing(text_00);
    static IEnumerator coroutine1=  Typing(text_01);
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
    static IEnumerator coroutine14 = Typing(text_13);
 

    public static void a활성화(){
      num=11;
      스킵.interactable=false;
    }
    public static void b활성화(){
      num=14;
      스킵.interactable=false;
    }
    public static void c활성화(){
      num=17;
      스킵.interactable=false;
    }
    public static void d활성화(){
      num=50;
      스킵.interactable=false;
    }
    public static void scenechange(){
      SceneManager.LoadScene("4-4");
    }
    public static void scenechange2(){
      SceneManager.LoadScene("4-3");
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
    static IEnumerator Typing2(string message)
    {
        Text typingText = GameObject.Find("general text2").GetComponent<Text>();
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
     public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
       
    }


  void Awake(){
    typingText = GameObject.Find("general text").GetComponent<Text>();
    스킵 = GameObject.Find("skipButton").GetComponent<Button>();
    스킵.onClick.AddListener(text_3_4.스킵버튼클릭);
    
    a = GameObject.Find("a");
    aB =a.GetComponent<Button>();
    at = GameObject.Find("aText").GetComponent<Text>();
    aB.onClick.AddListener(a활성화);

    b = GameObject.Find("b");
    bB =b.GetComponent<Button>();
    bt = GameObject.Find("bText").GetComponent<Text>();
    bB.onClick.AddListener(b활성화);

    c= GameObject.Find("c");
    cB =c.GetComponent<Button>();
    ct = GameObject.Find("cText").GetComponent<Text>();
    cB.onClick.AddListener(c활성화);

    d= GameObject.Find("d");
    dB=d.GetComponent<Button>();
    dt = GameObject.Find("dText").GetComponent<Text>();
    dB.onClick.AddListener(d활성화);


  } 
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_4_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=true;//스킵비활성화
       
       //오브젝트 초기화
       at.text="* 베란다 문을 조사한다. ";
       bt.text="빨리 열어야 하는데 어쩌지?";
       ct.text="지금은 한시가 급하니까,\n의수를 사용해서 문을 부수자.";
       dt.text="문을 부수다가 의수가 망가지면 큰일이야. 다른 방법을 찾아보자.";
       //ct.text="A. 작업실로 이동";
       
       a.SetActive(false);
       b.SetActive(false);
      c.SetActive(false);
      d.SetActive(false);

       aB.interactable=true;
       bB.interactable=true;
       cB.interactable=true;
       dB.interactable=true;
       StartCoroutine(coroutine0);

        Debug.Log("coroutin is started! #3-4 num"+num);
        


    }

//     // Update is called once per frame
    void Update(){
      Debug.Log(num);
        //Debug.Log(num);
        
        
        if(num==2){
            StartCoroutine(coroutine1);
            스킵.interactable=true;
            num++;
        }
      
        if(num==5){
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            StartCoroutine(coroutine3);
            num++;
            스킵.interactable=false;

        }
    
        if(num==10){
            a.SetActive(true);
            스킵.interactable=false;
        }
        
        if(num==11){
            a.SetActive(false);
            StartCoroutine(coroutine4);//역시나 잠겨있다~
            스킵.interactable=false;
            num++;
        }
        if(num==13){
          //(5) 탁자
            b.SetActive(true);
            스킵.interactable=false;
        }
        if(num==14){
            b.SetActive(false);
            StartCoroutine(coroutine5);
             num++;
            
        }//choice -> 2개
         if(num==16){
          //(5) 탁자
            c.SetActive(true);
            d.SetActive(true);
            스킵.interactable=false;
        }
//A. 지금은 한시가 급하니까, 의수를 사용해서 문을 부수자.
        if(num==17){
            StartCoroutine(coroutine6);
            c.SetActive(false);
            d.SetActive(false);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==20){
            StartCoroutine(coroutine7);
            num++;
            //activate button
            스킵.interactable=true;
        }
       
        if(num==23){
            StartCoroutine(coroutine8);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==26){
            StartCoroutine(coroutine9);
            num++;//activate button
            스킵.interactable=true;
        }
         if(num==29){
            StartCoroutine(coroutine10);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==32){
            StartCoroutine(coroutine13);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==35){
            StartCoroutine(coroutine14);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==37){
            scenechange();
        }
        if(num==50){
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine11);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==53){
            StartCoroutine(coroutine12);
            num++;//activate button
            스킵.interactable=true;
        }
        if(num==55){
            scenechange2();
            
        }
        
    }
}
