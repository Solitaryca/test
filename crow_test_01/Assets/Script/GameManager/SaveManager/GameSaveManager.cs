using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameSaveManager : MonoBehaviour
{
    public void SaveData1()
    {
        //ɾ��ԭ���ļ�
        string path = "Assets/UpdateData/SaveData/";
        string name = "Data1.txt";  //txt json
        DeleteFile(path+name);

        //��ֵ�������������
        //string data = null;


        //���������ļ�
    }

    public void DeleteFile(string path)
    {
        //path������·��+�ļ���ʽ��׺
        File.Delete(path);
    }

    public void CreateOrOpenFile(string path, string name, string info) //·�����ļ�����д������
    {
        //���ļ���
        StreamWriter sw;
        FileInfo fi = new(path + "//" + name);
        sw = fi.CreateText();  //ֱ������д��
        sw.WriteLine(info);
        sw.Close();
        sw.Dispose();
    }

    //��ȡ��Ҫ�浵������
    public string DataJson(string saveTime, string saveName)
    {
        if (saveTime is null)
        {
            throw new ArgumentNullException(nameof(saveTime));
        }

        if (saveName is null)
        {
            throw new ArgumentNullException(nameof(saveName));
        }

        string data = null;

        //PlayerController playerController = GameObject.FindGameObjectsWithTag("Player").CetComponent<PlayerController>();
        //DataForPlayer dataForPlayer = new DataForPlayer();
        //dataForPlayer.currentDigExp = playerController.currentDigExp;
        //data = JsonUtility.ToJson(dataForPlayer) + "\n\n";

        return data;
    }
}
