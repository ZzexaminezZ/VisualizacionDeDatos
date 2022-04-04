using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LecturaCsv : MonoBehaviour
{
    [SerializeField] private TextAsset data;
    [SerializeField] int csvColumns;
    [SerializeField] Players playersData;

    void Start()
    {
        readCsv();
    }

    private void readCsv()
    {
        string[] datas = data.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
        int tableSize = datas.Length / csvColumns - 1;
        Debug.Log(tableSize);
        playersData.PlayersArry = new PlayerData[tableSize];
        for (int i = 0; i < tableSize; i++)
        {
            playersData.PlayersArry[i] = new PlayerData();
            playersData.PlayersArry[i].Player = datas[csvColumns * (i + 1)];
            playersData.PlayersArry[i].Country = datas[csvColumns * (i + 1) + 1];
            playersData.PlayersArry[i].AustralianOpen = datas[csvColumns * (i + 1) + 2];
            playersData.PlayersArry[i].FrenchOpen = datas[csvColumns * (i + 1) + 3];
            playersData.PlayersArry[i].Wimbledon = datas[csvColumns * (i + 1) + 4];
            playersData.PlayersArry[i].UsOpen = datas[csvColumns * (i + 1) + 5];
            playersData.PlayersArry[i].TotalGrandSlams = datas[csvColumns * (i + 1) + 6];
            playersData.PlayersArry[i].AtpRank = datas[csvColumns * (i + 1) + 7];
            playersData.PlayersArry[i].AtpScore = datas[csvColumns * (i + 1) + 8];


        }
    }

    [Serializable]
    public class PlayerData
    {
        public string Player;
        public string Country;
        public string AustralianOpen;
        public string FrenchOpen;
        public string Wimb­ledon;
        public string UsOpen;
        public string TotalGrandSlams;
        public string AtpRank;
        public string AtpScore;
    }

    [Serializable]
    public class Players
    {
        public PlayerData[] PlayersArry;
    }


}
