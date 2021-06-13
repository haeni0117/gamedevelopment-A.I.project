using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-1-2

public class text_8_1_2 : MonoBehaviour
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
    public static void choice1활성화(){
        Debug.Log("choice1 is activated");
        GameObject choice1 = GameObject.Find("choice1");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text="▷ 작업실을 다시 한번 살펴보자";
        choice1B.interactable=true;
        
    }
    public static void 선택지활성화(){
        //choice 1 is clicked
        Debug.Log("choice1 is activated");
        GameObject choice1 = GameObject.Find("choice1");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text="▶ 작업실을 다시 한번 살펴보자";
        choice1B.interactable=false;

        //objects are showed
        //(1)책상 ; desk
        GameObject desk = GameObject.Find("desk");
        Button deskB =desk.GetComponent<Button>();
        Text deskt = GameObject.Find("deskText").GetComponent<Text>();
        deskt.text="◎ 책상";
        deskB.interactable=true;
        choice1B.onClick.AddListener(text_8_1_2.desk활성화);
        
        //(2)반려동물 방석 ; cushion
        GameObject cushion = GameObject.Find("cushion");
        Button cushionB =cushion.GetComponent<Button>();
        Text cushiont = GameObject.Find("cushionText").GetComponent<Text>();
        cushiont.text="◎ 반려동물 방석";
        cushionB.interactable=true;
        cushionB.onClick.AddListener(text_8_1_2.cushion활성화);

        //(3)책장 ; bookselves
        GameObject bookshelves = GameObject.Find("bookshelves");
        Button bookshelvesB =bookshelves.GetComponent<Button>();
        Text bookshelvest = GameObject.Find("bookshelvesText").GetComponent<Text>();
        bookshelvest.text="◎ 책장";
        bookshelvesB.interactable=true;
        bookshelvesB.onClick.AddListener(text_8_1_2.bookshelves활성화);

        //(4)2층 베란다 ; balcony
        GameObject balcony = GameObject.Find("balcony");
        Button balconyB =balcony.GetComponent<Button>();
        Text balconyt = GameObject.Find("balconyText").GetComponent<Text>();
        balconyt.text="◎ 2층 베란다";
        balconyB.interactable=true;
        balconyB.onClick.AddListener(text_8_1_2.balcony활성화);   
    }

    public static void move(){
        SceneManager.LoadScene("8-2");
    }
    
    public static void desk활성화(){
        num=11;
        GameObject desk = GameObject.Find("desk");
        Button deskB =desk.GetComponent<Button>();
        Text deskt = GameObject.Find("deskText").GetComponent<Text>();
        deskt.text="● 책상";
        deskB.interactable=false;


    }
    public static void cushion활성화(){
        num=14;
        GameObject cushion = GameObject.Find("cushion");
        Button cushionB =cushion.GetComponent<Button>();
        Text cushiont = GameObject.Find("cushionText").GetComponent<Text>();
        cushiont.text="● 반려동물 방석";
        cushionB.interactable=false;

    }
    public static void bookshelves활성화(){
        num=17;
        GameObject bookshelves = GameObject.Find("bookshelves");
        Button bookshelvesB =bookshelves.GetComponent<Button>();
        Text bookshelvest = GameObject.Find("bookshelvesText").GetComponent<Text>();
        bookshelvest.text="● 책장";
        bookshelvesB.interactable=false;

    }
    public static void balcony활성화(){
        num=20;
        GameObject balcony = GameObject.Find("balcony");
        Button balconyB =balcony.GetComponent<Button>();
        Text balconyt = GameObject.Find("balconyText").GetComponent<Text>();
        balconyt.text="● 2층 베란다";
        balconyB.interactable=false;

        //2층베란다로 이동 -> scenechange
        GameObject move = GameObject.Find("move");
        Button moveB =move.GetComponent<Button>();
        Text movet = GameObject.Find("moveText").GetComponent<Text>();
        movet.text="▷ 2층 베란다로 이동한다.";
        moveB.interactable=true;

    }


    private static string text_1="뭔가 이상해......\n분명히 아까 집 안의 모든 \n통신이 다 끊긴 걸 확인했는데 \n갑자기 전화가 온다니?";
    private static string text_2= "계단 앞에서 시루가 날카롭게 \n울기 시작했다.\n마치 내려가지 말라고 나를 \n말리는 것처럼." ;
    private static string text_3="도대체 무슨 냄새일까?\n보지 않더라도 \n1층을 살펴볼 수 있으면 좋을 텐데…. ";
    //narration end!
    //1. 작업실을 다시 한 번 살펴보자

    //(1)desk is activated
    private static string text_4="책상 위에는 쓸 만한 것이 없다.";
    //(2)cushion is activated
    private static string text_5="1층에 방석이라도 던져 볼까....?";
    //(3)bookshelves are activated
    private static string text_6="책과 의수 부품뿐이다. \n이걸로는 아무것도 할 수 없어.";
    //(4)balcony is activated
    private static string text_7= "시루를 구하느라 정신이 없어서 \n베란다를 살펴보지 않았다. \n쓸만한 것이 있으려나?" ;
    



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);       
    static IEnumerator coroutine6 = Typing(text_7);
    
    
    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_1_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);

        //1. 작업실을 다시 한 번 살펴보자
        GameObject choice1 = GameObject.Find("choice1");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text=" ";
        choice1B.interactable=false;
        choice1B.onClick.AddListener(text_8_1_2.선택지활성화);

        //(1)책상 ; desk
        GameObject desk = GameObject.Find("desk");
        Button deskB =desk.GetComponent<Button>();
        Text deskt = GameObject.Find("deskText").GetComponent<Text>();
        deskt.text=" ";
        deskB.interactable=false;
        deskB.onClick.AddListener(text_8_1_2.desk활성화);
        
        //(2)반려동물 방석 ; cushion
        GameObject cushion = GameObject.Find("cushion");
        Button cushionB =cushion.GetComponent<Button>();
        Text cushiont = GameObject.Find("cushionText").GetComponent<Text>();
        cushiont.text=" ";
        cushionB.interactable=false;
        cushionB.onClick.AddListener(text_8_1_2.cushion활성화);

        //(3)책장 ; bookselves
        GameObject bookshelves = GameObject.Find("bookshelves");
        Button bookshelvesB =bookshelves.GetComponent<Button>();
        Text bookshelvest = GameObject.Find("bookshelvesText").GetComponent<Text>();
        bookshelvest.text=" ";
        bookshelvesB.interactable=false;
        bookshelvesB.onClick.AddListener(text_8_1_2.bookshelves활성화);

        //(4)2층 베란다 ; balcony
        GameObject balcony = GameObject.Find("balcony");
        Button balconyB =balcony.GetComponent<Button>();
        Text balconyt = GameObject.Find("balconyText").GetComponent<Text>();
        balconyt.text=" ";
        balconyB.interactable=false;
        balconyB.onClick.AddListener(text_8_1_2.balcony활성화);
        
        //move
        GameObject move = GameObject.Find("move");
        Button moveB =move.GetComponent<Button>();
        Text movet = GameObject.Find("moveText").GetComponent<Text>();
        movet.text=" ";
        moveB.interactable=false;
        moveB.onClick.AddListener(text_8_1_2.move);

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
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            choice1활성화();
            num++;
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.onClick.AddListener(text_8_1_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
            스킵.interactable=false;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==17){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine6);
            num++;
        }
        
       

    }
}
