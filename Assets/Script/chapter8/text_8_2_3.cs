using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-1-2

public class text_8_2_3: MonoBehaviour
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
        at.text="A. 시간이 없다.\n겨우 한 층 높이니 뛰어내려 보자.";
        aB.interactable=true;
        aB.onClick.AddListener(text_8_2_3.a활성화);
        
        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 목이 매캐하고 점점 숨쉬기가 힘들다. \n그래도 뛰어내리는 건 너무 위험해.";
        bB.interactable=true;
        bB.onClick.AddListener(text_8_2_3.b활성화);
    }

    
    
    public static void a활성화(){
        SceneManager.LoadScene("8-2-3-1");
    }
    public static void b활성화(){
       SceneManager.LoadScene("8-2-3-2");
    }
  


    private static string text_1="나는 급한 대로 1층으로 \n내려가는 문을 닫았다.\n시루도 이상한 기운을 느꼈는지 \n날카로운 울음소리를 냈다. ";
    private static string text_2= "생각을 하자......생각을.." ;
    private static string text_3="1층은 내려갈 수 없고 \n2층 창문은 모두 \n스마트 락이 걸려 있다.";
    private static string text_4="게다가 이곳은 고층이라 \n단열 및 안전을 위해 모든 \n창문이 3중 유리거나 2중창이다.\n하나를 깨는 데 성공한다고 해도 \n가스를 제거할 수 없다.";
    private static string text_5="그때 2층 베란다 밑으로 \n1층 베란다가 보였다. \n유일하게 1층 베란다 창문은 \n바로 외부와 연결되어있다.\n그래도 두꺼운 \n유리 방벽이기는 하지만....\n한 장이라면 시도해볼 만하다.\n1층 베란다 창문을 깰 수만 \n있다면 가스를 모두 뺄 수 \n있을 것이다. ";
    private static string text_6="그런데 계단을 통하지 않고 어떻게 1층 베란다로 내려가지?.";
    
    



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);       
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_2_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);

        // //1. 작업실을 다시 한 번 살펴보자
        // GameObject choice1 = GameObject.Find("choice1");
        // Button choice1B =choice1.GetComponent<Button>();
        // Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        // choice1t.text=" ";
        // choice1B.interactable=false;
        // choice1B.onClick.AddListener(text_8_1_2.선택지활성화);

       //a
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text_8_2_3.a활성화);
        
        //b
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text=" ";
        bB.interactable=false;
        bB.onClick.AddListener(text_8_2_3.b활성화);
    
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
            num++;
        }
        if(num==17){
           선택지활성화();
            num++;
        }

       
        
       

    }
}
