using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1_2 : MonoBehaviour
{// Start is called before the first frame update
   public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;
    //조사할 오브젝트
    public static GameObject desk;
    public static GameObject cushion;
    public static GameObject table;
    public static GameObject sidetable;
    public static GameObject bookshelves;
    public static GameObject secondfloor;
    public static GameObject another;

    public static Button desk_b;
    public static Button cushion_b;
    public static Button table_b;
    public static Button sidetable_b;
    public static Button bookshelves_b;
    public static Button secondfloor_b;
    public static Button another_b;
    public static Button 스킵;

    public static Text desk_t;
    public static Text cushion_t;
    public static Text table_t;
    public static Text sidetable_t;
    public static Text bookshelves_t;
    public static Text secondfloor_t;
    public static Text another_t;

    
    private static string text_1="책상 위를 훑어봤지만,\n구급상자는 보이지 않는다.";
    private static string text_2="구급상자가 여기 있을 리 없다.";
    private static string text_3="구급상자는 여기 없다.\n공연히 다이어리만 펼쳐봤다.";
    private static string text_4="{2049.07.19. 월 \n오늘 회사 인사팀에서 \n이상한 연락을 받았다.\n지난주 토요일 연구실에 \n출근한 기록이 있으니\n휴일 수당을 \n따로 청구하라는 내용이었다.}";
    private static string text_5="{나는 지난 주말 내내 \n도시복합체를 벗어난 적이 없다.\n교통 카드 사용 내역까지 \n살펴봤지만, \n출근을 위해 모노레일 \n이용 요금을 낸 기록은 없었다.}";
    private static string text_6="{나는 연구실 출입 태그가 \n도용되었을 가능성을 내비쳤지만\n총무팀에선 생체신호에 기반한 \n출입 카드가 복제되었을 가능성은 \n전혀 없다고 했다. \n나는 왼팔 소매에 \n멀쩡하게 부착된 근태 확인용 \n출입 태그를 바라보았다.}";
    private static string text_7="{도용된 것이 아니라면, \n지난 토요일 사무실에 출근한 사람은 \n도대체 누구란 말인가?\n내일은 경비실에 가서 \nCCTV를 확인해봐야겠다.}";
    private static string text_8="책장에 꽂힌 박스를\n꺼내서 살펴봤다.\n오래된 의수 부품만\n잔뜩 들어있다.";
    private static string text_9="구급상자를 둘 공간도 없고 \n저기 둘 이유도 없다.";
    private static string text_10="다른 곳도 둘러볼까?";
    private static string text_11="A.다른 곳을 둘러본다";
    private static string text_12="B.아니다, 더 찾아보자.";

    static IEnumerator coroutine1 =  Typing(text_1);
    static IEnumerator coroutine2 =  Typing(text_2);
    static IEnumerator coroutine3 =  Typing(text_3);
    static IEnumerator coroutine4 =  Typing(text_4);
    static IEnumerator coroutine5 =  Typing(text_5);
    static IEnumerator coroutine6 =  Typing(text_6);
    static IEnumerator coroutine7 =  Typing(text_7);
    static IEnumerator coroutine8 =  Typing(text_8);
    static IEnumerator coroutine9 =  Typing(text_9);
    static IEnumerator coroutine10 =  Typing(text_10);
    static IEnumerator coroutine11 =  Typing(text_11);
    static IEnumerator coroutine12 =  Typing(text_12);

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;

    }
    public void activate(){
        
        desk_b.interactable=true;
        cushion_b.interactable=true;
        table_b.interactable=true;
        sidetable_b.interactable=true;
        bookshelves_b.interactable=true;
        secondfloor_b.interactable=true;
        another_b.interactable=true;
        desk_t.text="(1) 책상";
        cushion_t.text="(2) 반려동물 방석";
        table_t.text="(3) 탁자";
        sidetable_t.text="(4) 사이드테이블";
        bookshelves_t.text="(5) 책장";
        secondfloor_t.text="(6) 2층 베란다";
        another_t.text="(7) 다른 장소로 가본다.";
    }
    public void inactivate(){
        
        desk_b.interactable=false;
        cushion_b.interactable=false;
        table_b.interactable=false;
        sidetable_b.interactable=false;
        bookshelves_b.interactable=false;
        secondfloor_b.interactable=false;
        another_b.interactable=false;
        desk_t.text=" ";
        cushion_t.text=" ";
        table_t.text=" ";
        sidetable_t.text=" ";
        bookshelves_t.text=" ";
        secondfloor_t.text=" ";
        another_t.text=" ";}

    public void click_desk(){
        스킵.interactable=false;
        num=2;
    }
    public void click_cushion(){
        스킵.interactable=false;
        num=5;
    }
    public void click_table(){
        스킵.interactable=false;
        num=8;
    }
    public void click_sidetable(){
        num=11;
        스킵.interactable=true;
    }
    public void click_bookshelves(){
        스킵.interactable=false;
        num=26;
    }
    public void click_secondfloor(){
        스킵.interactable=false;
        num=29;
    }
    public void click_another(){
        스킵.interactable=false;
        num=32;
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
    //button
    desk_b = GameObject.Find("desk").GetComponent<Button>();
    cushion_b = GameObject.Find("cushion").GetComponent<Button>();
    table_b = GameObject.Find("table").GetComponent<Button>();
    sidetable_b = GameObject.Find("sidetable").GetComponent<Button>();
    bookshelves_b = GameObject.Find("bookshelves").GetComponent<Button>();
    secondfloor_b = GameObject.Find("secondfloor").GetComponent<Button>();
    another_b = GameObject.Find("another").GetComponent<Button>();

    //text
    desk_t = GameObject.Find("desktext").GetComponent<Text>();
    cushion_t = GameObject.Find("cushiontext").GetComponent<Text>();
    table_t = GameObject.Find("tabletext").GetComponent<Text>();
    sidetable_t = GameObject.Find("sidetabletext").GetComponent<Text>();
    bookshelves_t = GameObject.Find("bookshelvestext").GetComponent<Text>();
    secondfloor_t = GameObject.Find("secondfloortext").GetComponent<Text>();
    another_t = GameObject.Find("anothertext").GetComponent<Text>();

    //onclick -> function
    desk_b.onClick.AddListener(click_desk);
    cushion_b.onClick.AddListener(click_cushion);
    table_b.onClick.AddListener(click_table);
    sidetable_b.onClick.AddListener(click_sidetable);
    bookshelves_b.onClick.AddListener(click_bookshelves);
    secondfloor_b.onClick.AddListener(click_secondfloor);
    another_b.onClick.AddListener(click_another);

  }
    // Start is called before the first frame update
   void Start()
    {
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;

       
        desk_b.interactable=true;
        cushion_b.interactable=true;
        table_b.interactable=true;
        sidetable_b.interactable=true;
        bookshelves_b.interactable=true;
        secondfloor_b.interactable=true;
        another_b.interactable=true;
        desk_t.text="(1) 책상";
        cushion_t.text="(2) 반려동물 방석";
        table_t.text="(3) 탁자";
        sidetable_t.text="(4) 사이드테이블";
        bookshelves_t.text="(5) 책장";
        secondfloor_t.text="(6) 2층 베란다";
        another_t.text="(7) 다른 장소로 가본다.";
        Debug.Log("coroutin is started! #6-1 num"+num);
        
        

    }

//     // Update is called once per frame
    void Update(){

        Debug.Log(num);
        if(num==2){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
            Invoke("activate",1.8f);
        }
        if(num==5){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            Invoke("activate",1f);
            
        }
        if(num==8){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
            Invoke("activate",1.8f);
            
        }
        if(num==11){
            inactivate();
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            
        }
        if(num==14){
            inactivate();
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        
        if(num==17){
            inactivate();
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==20){
            
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            
        }
        if(num==26){
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1.8f);
        }
        if(num==29){
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1.8f);
        }
        if(num==32){
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1.8f);
        }
        if(num==35){
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            Invoke("activate",1.8f);
        }
        // if(num==38){
        //     StartCoroutine(coroutine13);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==41){
        //     StartCoroutine(coroutine14);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==44){
        //     StartCoroutine(coroutine15);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==47){
        //     StartCoroutine(coroutine16);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==50){
        //     StartCoroutine(coroutine17);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==53){
        //     StartCoroutine(coroutine18);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==56){
        //     SceneManager.LoadScene("4-2");
        //     num++;//activate button
        // }


    }
}
