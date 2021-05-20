using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text2_2 : MonoBehaviour
{
    public GameObject button_; //fadeout 용도
    //모든 선택지를 확인했는지 -> bool로 체크
    //Q bool 왜 안됨?okay


    static bool first_bool=false;
    static bool second_bool = false;
    static bool third_bool = false;

    //서랍장 조사 => 층별로 버튼 클릭 가능하게 구성
    public GameObject first_drawer;
    public GameObject second_drawer;
    public GameObject third_drawer;

    public int cnt = 0;
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;
    public Text typingText;

    //scenario text
    private static string m1="모던한 방 분위기와는\n어울리지 않는 서랍장이다.\n마음에 들지 않았지만,\n부모님이 골라주신 거라\n어쩔 수 없이\n침대 바로 옆에 뒀다."; 
    private static string m2="사용하는 서랍이라고는 \n믿을 수 없을 정도로 \n텅 비어있다."; 
    private static string m3="이 집으로 이사 올 때 \n안전을 위해서 사 둔 호신용품이다. \n다행히 아직 사용할 일이 없어서 \n서랍장에 넣어 두고 잊고 있었다"; 

    IEnumerator Typing(string message) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(0.05f); 
        } 
        yield break;//ㅅ시발 왜 두번 돌아가?
    }

    public void narr(){
        Debug.Log("narration_start");
        
        //generaltext.text=m_Message;
        StartCoroutine(Typing(m1));
        Debug.Log("coroutine is finished");
        Invoke("buttonsetactive",3);
    }
    // private void buttonactivating(){
    //     first_drawer.SetActive(true);
    //     second_drawer.SetActive(true);
    //     third_drawer.SetActive(true);
    // }
    public void buttonsetactive(){
        first_drawer.SetActive(true);
        second_drawer.SetActive(true);
        third_drawer.SetActive(true);
    }

    //the first_floor of drawer investigation
    public void first(){
        StartCoroutine(Typing(m2));
        text2_2.first_bool=true;
        //bool 변수 값 확인목적 디버그

    }
    //the second_floor of drawer investigation
    public void second(){ 
        StartCoroutine(Typing(m2));
        text2_2.second_bool = true;
        //bool&int 변수 값 확인목적 디버그
        // Debug.Log("1 :" +first_num+"  /  2 :"+second_num+"  /  3 :"+third_num);
        // Debug.Log("1 :" +first_bool+"  /  2 :"+second_bool+"  /  3 :"+third_bool);
    }
    //the third_floor of drawer investigation
    public void third(){
        StartCoroutine(Typing(m3));
        text2_2.third_bool = true;
        //bool 변수 값 확인목적 디버그
        // Debug.Log("1 :" +first_num+"  /  2 :"+second_num+"  /  3 :"+third_num);
        Debug.Log("1 :" +first_bool+"  /  2 :"+second_bool+"  /  3 :"+third_bool);
    }

    // Start is called before the first frame update
    void Start()
    {
        narr();
    }
    void activating(){
        button_.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("1 :" +first_bool+"  /  2 :"+second_bool+"  /  3 :"+third_bool);
        if(first_bool==true&&second_bool==true&&third_bool==true){
            Invoke("activating",3);
        }
        //bool값 변경 -> 다음 씬 연결 버튼 활성화(SetActive)
        // if(first_num!=0){
        //     first_bool=true;
        // }
        // if(second_num!=0){
        //     second_bool=true;
        // }
        // if(third_num!=0){
        //     third_bool=true;
        // }
        
    }
}
