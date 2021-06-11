using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1 : MonoBehaviour
{
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;

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
    public static void 어디서부터찾아볼까(){
        GameObject 어디서부터 = GameObject.Find("어디서부터");
        Button 어디서부터B =어디서부터.GetComponent<Button>();
        Text 어디서부터t = GameObject.Find("어디서부터Text").GetComponent<Text>();
        어디서부터t.text="▷ 어디부터 찾아볼까?";
        어디서부터B.interactable=true;

    }

    //어디서부터찾아볼까 클릭 후 이벤트
    public static void 어디서부터찾아볼까선택지활성화(){
        GameObject 어디서부터 = GameObject.Find("어디서부터");
        Button 어디서부터B =어디서부터.GetComponent<Button>();
        Text 어디서부터t = GameObject.Find("어디서부터Text").GetComponent<Text>();
        어디서부터t.text="▶ 어디부터 찾아볼까?";
        어디서부터B.interactable=false;

        Debug.Log("구급상자 탐색장소 목록 보여주기");
         //안방
        GameObject 안방 = GameObject.Find("안방");
        Button 안방B =안방.GetComponent<Button>();
        Text 안방t = GameObject.Find("안방Text").GetComponent<Text>();
        안방t.text="◎ 안방에 들어간다.";
        안방B.interactable=true;
        안방B.onClick.AddListener(text6_1.안방으로이동);

        //작업실
        GameObject 작업실 = GameObject.Find("작업실");
        Button 작업실B =작업실.GetComponent<Button>();
        Text 작업실t = GameObject.Find("작업실Text").GetComponent<Text>();
        작업실t.text="◎ 작업실에 들어간다.";
        작업실B.interactable=true;
        작업실B.onClick.AddListener(text6_1.작업실로이동);

        //거실
        GameObject 거실 = GameObject.Find("거실");
        Button 거실B =거실.GetComponent<Button>();
        Text 거실t = GameObject.Find("거실Text").GetComponent<Text>();
        거실t.text="◎ 거실에 들어간다.";
        거실B.interactable=true;
        거실B.onClick.AddListener(text6_1.거실로이동);

        //게스트룸
        GameObject 게스트룸 = GameObject.Find("게스트룸");
        Button 게스트룸B =게스트룸.GetComponent<Button>();
        Text 게스트룸t = GameObject.Find("게스트룸Text").GetComponent<Text>();
        게스트룸t.text="◎ 게스트룸에 들어간다.";
        게스트룸B.interactable=true;
        게스트룸B.onClick.AddListener(text6_1.게스트룸으로이동);



    }

    //안방으로 씬이동
    public static void 안방으로이동(){
        Debug.Log("안방으로 이동");
        SceneManager.LoadScene("6-1-1");
    }
    //작업실로 씬이동
    public static void 작업실로이동(){
        Debug.Log("작업실로 이동");
        SceneManager.LoadScene("6-1-2");
    }
    //안방으로 씬이동
    public static void 거실로이동(){
        Debug.Log("거실로 이동");
        SceneManager.LoadScene("6-1-3");
    }
    //안방으로 씬이동
    public static void 게스트룸으로이동(){
        Debug.Log("게스트룸으로 이동");
        SceneManager.LoadScene("6-1-4");
    }


    

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("어디서부터 찾아볼까 클릭");
        num++;
        Debug.Log("Scene 6-1 is started");
    //skipButton -> definition
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text6_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        

        //다음물엄 : 어디서부터찾아볼까?(구급상자탐색)
        GameObject 어디서부터 = GameObject.Find("어디서부터");
        Button 어디서부터B =어디서부터.GetComponent<Button>();
        Text 어디서부터t = GameObject.Find("어디서부터Text").GetComponent<Text>();
        어디서부터t.text="▷ 어디부터 찾아볼까?";
        어디서부터B.interactable=true;
        어디서부터B.onClick.AddListener(text6_1.어디서부터찾아볼까선택지활성화);

        //안방
        GameObject 안방 = GameObject.Find("안방");
        Button 안방B =안방.GetComponent<Button>();
        Text 안방t = GameObject.Find("안방Text").GetComponent<Text>();
        안방t.text=" ";
        안방B.interactable=false;
        안방B.onClick.AddListener(text6_1.안방으로이동);

        //작업실
        GameObject 작업실 = GameObject.Find("작업실");
        Button 작업실B =작업실.GetComponent<Button>();
        Text 작업실t = GameObject.Find("작업실Text").GetComponent<Text>();
        작업실t.text=" ";
        작업실B.interactable=false;
        작업실B.onClick.AddListener(text6_1.작업실로이동);

        //거실
        GameObject 거실 = GameObject.Find("거실");
        Button 거실B =거실.GetComponent<Button>();
        Text 거실t = GameObject.Find("거실Text").GetComponent<Text>();
        거실t.text=" ";
        거실B.interactable=false;
        거실B.onClick.AddListener(text6_1.거실로이동);

        //게스트룸
        GameObject 게스트룸 = GameObject.Find("게스트룸");
        Button 게스트룸B =게스트룸.GetComponent<Button>();
        Text 게스트룸t = GameObject.Find("게스트룸Text").GetComponent<Text>();
        게스트룸t.text=" ";
        게스트룸B.interactable=false;
        게스트룸B.onClick.AddListener(text6_1.게스트룸으로이동);


    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
