using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_8_3_3_a: MonoBehaviour
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
    public static void a활성화(){
        SceneManager.LoadScene("8-3-3-a");
        // num=44;
        // //a. 안방으로 간다.-> 비활성화
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
    }
    public static void b활성화(){
        SceneManager.LoadScene("8-3-3-b");
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
    }
    //선택지활성화
    public static void 선택지활성화(){
        //a. 안방으로 간다.
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="A. 안방으로 간다.";
        aB.interactable=true;

        //b. 2층베란다로 간다. 
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 2층 베란다로 간다.";
        bB.interactable=true;
        bB.onClick.AddListener(text_8_3_2.b활성화);
    }
    public static void 선택지활성화a(){
        //a. 안방으로 간다.
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;

        //b. 2층베란다로 간다. 
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 2층 베란다로 간다.";
        bB.interactable=true;
        
    }


    
    private static string text_9="시간이 없어!\n지금 안방에 가면 쓰러지기 \n전에 창문을 깰 수 없을 것이다. ";
    private static string text_10="어디로 갈까?";

    
    



    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);        
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_3_3_a.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine8);

        //a. 안방으로 간다
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text_8_3_3_a.a활성화);

        //b. 2층 베란다로 간다.
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text=" ";
        bB.interactable=false;
        bB.onClick.AddListener(text_8_3_3_a.b활성화);

        
    }
    // Update is called once per frame
    void Update()
    
    {
        Debug.Log(num);
        if(num==2){
           StartCoroutine(coroutine9);
           num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
           선택지활성화a();
        }  
        
        

    }
}
