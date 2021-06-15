using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-2 -> 8-2-1

public class text_8_2_2 : MonoBehaviour
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
    // public static void search활성화(){
    //     Debug.Log("<search> is activated");
    //     GameObject search = GameObject.Find("search");
    //     Button searchB =search.GetComponent<Button>();
    //     Text searcht = GameObject.Find("searchText").GetComponent<Text>();
    //     searcht.text="▷ 어디를 살펴볼까?";
    //     searchB.interactable=true;
        
    // }
    public static void object활성화(){
        //choice 1 is clicked
        Debug.Log("choice1 is activated");
        //1. 2층 베란다를 살펴본다-> 활성화

         //a.거실을 살펴본다.
        GameObject livingroom = GameObject.Find("livingroom");
        Button livingroomB =livingroom.GetComponent<Button>();
        Text livingroomt = GameObject.Find("livingroomText").GetComponent<Text>();
        livingroomt.text="▷ 거실을 살펴본다.";
        livingroomB.interactable=true;
        livingroomB.onClick.AddListener(text_8_2_2.livingroom활성화);
        
        //b.부엌을 살펴본다.
        GameObject kitchen = GameObject.Find("kitchen");
        Button kitchenB =kitchen.GetComponent<Button>();
        Text kitchent = GameObject.Find("kitchenText").GetComponent<Text>();
        kitchent.text="▷ 부엌을 살펴본다.";
        kitchenB.interactable=true;
        kitchenB.onClick.AddListener(text_8_2_2.kitchen활성화);

        //c.게스트룸을 살펴본다.
        GameObject guestroom = GameObject.Find("guestroom");
        Button guestroomB =guestroom.GetComponent<Button>();
        Text guestroomt = GameObject.Find("guestroomText").GetComponent<Text>();
        guestroomt.text="▷ 게스트룸을 살펴본다.";
        guestroomB.interactable=true;
        guestroomB.onClick.AddListener(text_8_2_2.guestroom활성화);

        //d.게스트룸화장실을 살펴본다.
        GameObject toilet = GameObject.Find("toilet");
        Button toiletB =toilet.GetComponent<Button>();
        Text toilett = GameObject.Find("toiletText").GetComponent<Text>();
        toilett.text="▷ 게스트룸 화장실을 살펴본다.";
        toiletB.interactable=true;
        toiletB.onClick.AddListener(text_8_2_2.toilet활성화);

         //e. 1층 베란다를 살펴본다
        GameObject balcony = GameObject.Find("balcony");
        Button balconyB =balcony.GetComponent<Button>();
        Text balconyt = GameObject.Find("balconyText").GetComponent<Text>();
        balconyt.text="▷ 1층 베란다를 살펴본다.";
        balconyB.interactable=true;
        balconyB.onClick.AddListener(text_8_2_2.balcony활성화);


    }

  
    
    public static void livingroom활성화(){
        SceneManager.LoadScene("8-2-2-1");
    }
    public static void kitchen활성화(){
        SceneManager.LoadScene("8-2-2-2");
    }
    public static void guestroom활성화(){
        SceneManager.LoadScene("8-2-2-3"); 
    }
    public static void toilet활성화(){
        SceneManager.LoadScene("8-2-2-4"); 
    }
     public static void balcony활성화(){
        SceneManager.LoadScene("8-2-2-5");
    }
   

    //narration
    private static string text_1="어디를 살펴볼까? ";
    //(1)livingroom is activated
   
    



    static IEnumerator coroutine =  Typing(text_1);
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_2_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);

        //1.어디를 살펴볼까
        // GameObject search = GameObject.Find("search");
        // Button searchB =search.GetComponent<Button>();
        // Text searcht = GameObject.Find("searchText").GetComponent<Text>();
        // searcht.text=" ";
        // searchB.interactable=false;
        // searchB.onClick.AddListener(text_8_2_2.object활성화);

        //a.거실을 살펴본다.
        GameObject livingroom = GameObject.Find("livingroom");
        Button livingroomB =livingroom.GetComponent<Button>();
        Text livingroomt = GameObject.Find("livingroomText").GetComponent<Text>();
        livingroomt.text=" ";
        livingroomB.interactable=false;
        livingroomB.onClick.AddListener(text_8_2_2.livingroom활성화);
        
        //b.부엌을 살펴본다.
        GameObject kitchen = GameObject.Find("kitchen");
        Button kitchenB =kitchen.GetComponent<Button>();
        Text kitchent = GameObject.Find("kitchenText").GetComponent<Text>();
        kitchent.text=" ";
        kitchenB.interactable=false;
        kitchenB.onClick.AddListener(text_8_2_2.kitchen활성화);

        //c.게스트룸을 살펴본다.
        GameObject guestroom = GameObject.Find("guestroom");
        Button guestroomB =guestroom.GetComponent<Button>();
        Text guestroomt = GameObject.Find("guestroomText").GetComponent<Text>();
        guestroomt.text=" ";
        guestroomB.interactable=false;
        guestroomB.onClick.AddListener(text_8_2_2.guestroom활성화);

        //d.게스트룸화장실을 살펴본다.
        GameObject toilet = GameObject.Find("toilet");
        Button toiletB =toilet.GetComponent<Button>();
        Text toilett = GameObject.Find("toiletText").GetComponent<Text>();
        toilett.text=" ";
        toiletB.interactable=false;
        toiletB.onClick.AddListener(text_8_2_2.toilet활성화);

         //e. 1층 베란다를 살펴본다
        GameObject balcony = GameObject.Find("balcony");
        Button balconyB =balcony.GetComponent<Button>();
        Text balconyt = GameObject.Find("balconyText").GetComponent<Text>();
        balconyt.text=" ";
        balconyB.interactable=false;
        balconyB.onClick.AddListener(text_8_2_2.balcony활성화);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(num);
        if(num==2){
            object활성화();
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.onClick.AddListener(text_8_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
            스킵.interactable=false;
            num++;
            //StartCoroutine(coroutine1);
        }
        

    }
}
