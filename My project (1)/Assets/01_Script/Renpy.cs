using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image Img_Bg; //���
    [SerializeField] Image[] Img_Character; //���
    [SerializeField] TextMeshProUGUI txt_Name; // ĳ���� �̸�
    [SerializeField] TextMeshProUGUI txt_NameTitle; // Ÿ��Ʋ
    [SerializeField] TextMeshProUGUI txt_Dialogue; // ���

        //txt_Name.text = "������";
        //txt_NameTitle.text = "����";
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
        int characterID = SData.GetDialogueData(id).Character; // ��� ���̺��� 1�� ID�� ĳ���� ID �÷��� ������ �´�.
        txt_Name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.

        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

}



