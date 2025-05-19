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
        //删除原有文件
        string path = "Assets/UpdateData/SaveData/";
        string name = "Data1.txt";  //txt json
        DeleteFile(path+name);

        //赋值给到保存的数据
        //string data = null;


        //创建数据文件
    }

    public void DeleteFile(string path)
    {
        //path：基础路径+文件格式后缀
        File.Delete(path);
    }

    public void CreateOrOpenFile(string path, string name, string info) //路径，文件名，写入内容
    {
        //打开文件流
        StreamWriter sw;
        FileInfo fi = new(path + "//" + name);
        sw = fi.CreateText();  //直接重新写入
        sw.WriteLine(info);
        sw.Close();
        sw.Dispose();
    }

    //获取需要存档的数据
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
