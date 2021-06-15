using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_10_1: MonoBehaviour
{
    public static Button 스킵 ;
    
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
        Debug.Log("d");
    }
    //choice1activation
    // public static void a활성화(){
    //     SceneManager.LoadScene("8-3-3-a");
    //     // num=44;
    //     // //a. 안방으로 간다.-> 비활성화
    //     // GameObject a = GameObject.Find("a");
    //     // Button aB =a.GetComponent<Button>();
    //     // Text at = GameObject.Find("aText").GetComponent<Text>();
    //     // at.text=" ";
    //     // aB.interactable=false;

    //     // //b. 2층베란다로 간다. -> 비활성화
    //     // GameObject b = GameObject.Find("b");
    //     // Button bB =b.GetComponent<Button>();
    //     // Text bt = GameObject.Find("bText").GetComponent<Text>();
    //     // bt.text=" ";
    //     // bB.interactable=false;
    //     // bB.onClick.AddListener(text_8_3_2.b활성화);   
    // }
    // public static void b활성화(){
    //     SceneManager.LoadScene("8-3-3-b");
        // num=50;   
        //  //a. 안방으로 간다.-> 비활성화
        // GameObject a = GameObject.Find("a");
        // Button aB =a.GetComponent<Button>();
        // Text at = GameObject.Find("aText").GetComponent<Text>();
        // at.text=" ";
        // aB.interactable=false;

        // //b. 2층베란다로 간다. -> 비활성화
        // GameObject b = GameObject.Find("b");
        // Button bB =b.GetComponent<Button>();
        // Text bt = GameObject.Find("bText").GetComponent<Text>();
        // bt.text=" ";
        // bB.interactable=false;
        // bB.onClick.AddListener(text_8_3_2.b활성화);   
    
    //선택지활성화
    
    

    
    private static string text_1="\"2049년 11월 6일 15시 23분, \n서울시 서대문구 도시복합체 \n52동-(나)길 563호의 \n스마트홈 통제권은 모두 \n인공지능 호스트, ‘KM-468’에게 \n있습니다. \n현관 통제권을 되찾아오지 못하면 \n탈출 가능성이 현저히 낮습니다.”";
    private static string text_2= "\"분명히 방법이 있을 거야. \n스마트홈이 고장 나면 \n복구할 수 있는 \n매뉴얼이 있을 텐데.....\"" ;
    private static string text_3="\"긴급 탈출 매뉴얼이 존재하지만, \n호스트인 인공지능이 거주자에게 \n적대적인 경우는 처음입니다. \n혹시 저를 컴퓨터에 연결해서 \n권한을 되찾아 오는 건 \n어떨까요?\"";
    private static string text_4="\"그건 너무 위험해. \n아까 계산했을 땐 \n성공 가능성이 고작 6.45%라며. \n카라가 너를 버그로 인식해\n삭제하면 그땐 정말 방법이 없어\"";
    private static string text_5="\"제가 들어가는 건 확실히 \n위험한 일입니다. \n하지만 또 다른 제가 \n시도한다면...\"";
    private static string text_6="\"스마트홈 인공지능을 \n복제하는 건 쉬운 일이 아니야. \n게다가 지금 컴퓨터도 모두 \n카라의 손에 들어간 상태고";
    private static string text_7="\"저를 복제하자는 게 아닙니다. \n의수에 이미 복제된 \n이전 버전의 저를 \n이용하자는 의미입니다.\"";
    private static string text_8= "\"하지만 그것 역시 \n너의 일부야. \n복구할 수 없는 개체를 \n함부로 희생시키고 싶진 않아\"" ;
    private static string text_9="\"하지만 이 방법은 \n저를 희생시키지 않으면서 \n탈출 가능성을 높일 수 있는 \n유일한 선택지입니다.\"";
    private static string text_10_="인공지능은 바이러스와 같다.\n생물의 기본 요건을\n갖추지는 못했지만, \n그들은 분명히 살아있다. \n나는 차마 사라의 눈을 \n똑바로 바라보지 못하고 \n고개를 끄덕였다.";
    private static string text_11="\"그래, 사라. \n지금은 그 방법밖에 없겠지. \n코어를 가져올게. \n컴퓨터에 연결해보자\"";
    

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5=  Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);       
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10_);
    static IEnumerator coroutine10 = Typing(text_11);
   

     
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_10_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);

        

        
    }
    // Update is called once per frame
    void Update()
    
    {
        Debug.Log(num);
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
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
         if(num==17){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine6);
            num++;
        }
        if(num==20){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine7);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==26){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==29){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine10);
            num++;
        }
        if(num==32){
            SceneManager.LoadScene("10-2");
        }
        
        
    }
}
