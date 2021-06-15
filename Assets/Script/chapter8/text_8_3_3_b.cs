using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_8_3_3_b: MonoBehaviour
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
    
    

    
    private static string text_1="밧줄을 다시 한번 단단히 베란다 \n창살에 걸었다. \n몇 번 세게 당겼지만 꿈쩍하지 \n않는다.";
    private static string text_2= "\"매듭이 풀릴 일은 없겠네\"" ;
    private static string text_3="\"운동화 매듭이 고민이신가요? \n드라이브에 \n‘절대 풀리지 않는 매듭을 \n묶는 101가지 방법’\n이라는 기사가 저장되어 있습니다. \n읽어드릴까요?\"";
    private static string text_4="\"사라!\"";
    private static string text_5="\"부르셨나요? IA-0210님\"";
    private static string text_6="횡설수설하는 사라를 보며 \n나는 한숨을 쉬고 대답 대신 \n커튼을 붙잡고 조심히 베란다를 \n내려가기 시작했다. .";
  



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_3_3_b.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
            SceneManager.LoadScene("8-4");
        }
        
        

    }
}
