using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BackEnd;

public class GetDataFromServer : MonoBehaviour
{
 

    void getDataOfPlayerCharGrid()
    {
        var bro = Backend.GameData.Get("GridOfPlayersChar", new Where());
        string inDate = bro.GetInDate();
        Debug.Log(Backend.GameData.GetMyData("GridOfPlayersChar", inDate));
    }
}
