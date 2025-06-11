using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image Img_Bg; //배경
    [SerializeField] Image[] Img_Character; //배경
    [SerializeField] TextMeshProUGUI txt_Name; // 캐릭터 이름
    [SerializeField] TextMeshProUGUI txt_NameTitle; // 타이틀
    [SerializeField] TextMeshProUGUI txt_Dialogue; // 대사

        //txt_Name.text = "세리아";
        //txt_NameTitle.text = "공주";
        //txt_Dialogue.text = SData.GetDialogueData(1).Dialogue;

        int id = 1;

        void Start()
        {
            RefreshUI();
        }

public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character; // 대사 테이블의 1번 ID의 캐릭터 ID 컬럼을 가지고 온다.
        txt_Name.text = SData.GetCharacterData(characterID).Name; // 캐릭터 테이블에서 캐릭터 ID에 해당하는 이름을 가지고 온다.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // 캐릭터 테이블에서 캐릭터 ID에 타이틀을 가지고 온다.

        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

}



