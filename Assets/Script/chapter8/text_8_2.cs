using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-2 -> 8-2-1

public class text_8_2 : MonoBehaviour
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
    //<search> option
    public static void search활성화(){
        Debug.Log("<search> is activated");
        GameObject search = GameObject.Find("search");
        Button searchB =search.GetComponent<Button>();
        Text searcht = GameObject.Find("searchText").GetComponent<Text>();
        searcht.text="▷ 2층 베란다를 살펴본다.";
        searchB.interactable=true;
        
    }
    public static void object활성화(){
        //choice 1 is clicked
        Debug.Log("choice1 is activated");
        //1. 2층 베란다를 살펴본다-> 활성화
        GameObject search = GameObject.Find("search");
        Button searchB =search.GetComponent<Button>();
        Text searcht = GameObject.Find("searchText").GetComponent<Text>();
        searcht.text="▶ 2층 베란다를 살펴본다.";
        searchB.interactable=false;
        searchB.onClick.AddListener(text_8_2.object활성화);

        //(1)안락의자 ; chair
        GameObject chair = GameObject.Find("chair");
        Button chairB =chair.GetComponent<Button>();
        Text chairt = GameObject.Find("chairText").GetComponent<Text>();
        chairt.text="◎ 안락의자";
        chairB.interactable=true;
        chairB.onClick.AddListener(text_8_2.chair활성화);
        
        //(2)탁자 ; table
        GameObject table = GameObject.Find("table");
        Button tableB =table.GetComponent<Button>();
        Text tablet = GameObject.Find("tableText").GetComponent<Text>();
        tablet.text="◎ 탁자";
        tableB.interactable=true;
        tableB.onClick.AddListener(text_8_2.table활성화);

    }

    public static void move(){
        SceneManager.LoadScene("8-2-1");
    }
    
    public static void chair활성화(){
        num=5;
        GameObject chair = GameObject.Find("chair");
        Button chairB =chair.GetComponent<Button>();
        Text chairt = GameObject.Find("chairText").GetComponent<Text>();
        chairt.text="● 안락의자";
        chairB.interactable=false;


    }
    public static void table활성화(){
        num=8;
        GameObject table = GameObject.Find("table");
        Button tableB =table.GetComponent<Button>();
        Text tablet = GameObject.Find("tableText").GetComponent<Text>();
        tablet.text="● 탁자";
        tableB.interactable=false;
    }
   

    //narration
    private static string text_1="2층 베란다로 들어왔다.";
    //(1)chair is activated
    private static string text_2= "푹신한 방석이 나를 유혹한다\n하지만 지금은 쉴 수 없어." ;
    //(2)table is activated
    private static string text_3="사내 드론 대회에 참가하겠다고 \n몇 년 전에 산 정찰용 드론을 \n발견했다.";
    private static string text_4="드론을 이용하면 1층에 직접 \n내려가지 않고도 무슨 일이 \n일어났는지 확인할 수 있을 \n것이다.";
    private static string text_5="창가 구석 상자 안에서 드론을 \n꺼내자 베란다 한가득 먼지가 \n휘날렸다. ";
    private static string text_6=" {드론과 드론 조종간을 획득했다.}";
   
    



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    //       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);       
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);

        //1. 2층 베란다를 살펴본다
        GameObject search = GameObject.Find("search");
        Button searchB =search.GetComponent<Button>();
        Text searcht = GameObject.Find("searchText").GetComponent<Text>();
        searcht.text=" ";
        searchB.interactable=false;
        searchB.onClick.AddListener(text_8_2.object활성화);

        //(1)안락의자 ; chair
        GameObject chair = GameObject.Find("chair");
        Button chairB =chair.GetComponent<Button>();
        Text chairt = GameObject.Find("chairText").GetComponent<Text>();
        chairt.text=" ";
        chairB.interactable=false;
        chairB.onClick.AddListener(text_8_2.chair활성화);
        
        //(2)탁자 ; table
        GameObject table = GameObject.Find("table");
        Button tableB =table.GetComponent<Button>();
        Text tablet = GameObject.Find("tableText").GetComponent<Text>();
        tablet.text=" ";
        tableB.interactable=false;
        tableB.onClick.AddListener(text_8_2.table활성화);

        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(num);
        if(num==2){
            search활성화();
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.onClick.AddListener(text_8_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
            스킵.interactable=false;
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
            
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.onClick.AddListener(text_8_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
            스킵.interactable=true;
        }
        if(num==11){
            StartCoroutine(coroutine3);
            Debug.Log("Dfdf");
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==17){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==20){
            move();
            Debug.Log("scene is changed");
            num++;
        }
        
       

    }
}
