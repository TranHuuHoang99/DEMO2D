using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    private Transform leaderBoardScroll;
    private Transform leaderBoardContainer;
    private Transform leaderBoardList;
    private Transform rank;
    public TextAsset player_database;
    

    private void Awake(){
        leaderBoardScroll = transform.Find("leaderboardScroll");
        leaderBoardContainer = leaderBoardScroll.Find("leaderboardContainer");
        leaderBoardList = leaderBoardContainer.Find("leaderboardList");
        rank = leaderBoardList.Find("rank");
        rank.gameObject.SetActive(false);

        //call back database array
        PlayerList playerList = JsonUtility.FromJson<PlayerList>(player_database.text);
        int i = 0;


        foreach(Player playerName in playerList.player){
            Transform playerRank = Instantiate(rank, leaderBoardList);
            playerRank.gameObject.SetActive(true);

            i++;
            int numberingOrder = i % 10;
            string stringOrder;
            switch(numberingOrder){
                case 1:
                    stringOrder = "ST";
                    break;
                case 2:
                    stringOrder = "ND";
                    break;
                case 3:
                    stringOrder = "RD";
                    break;
                default :
                    stringOrder = "TH";
                    break;
            }
            playerRank.Find("Pos").GetComponent<Text>().text = i.ToString() + stringOrder;
            playerRank.Find("Name").GetComponent<Text>().text = playerName.name;
            playerRank.Find("Score").GetComponent<Text>().text = playerName.score.ToString();
        }
    }
}


