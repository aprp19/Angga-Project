using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerConnect : MonoBehaviour
{
    public string versionName = "0.1";
    public GameObject sectionView1, sectionView2, sectionView3;

    public void ConnectToPhoton()
    {
        PhotonNetwork.ConnectUsingSettings(versionName);
        Debug.Log("Connecting to photon . . .");
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected To Master !");
    }

    private void OnJoinedLobby()
    {
        sectionView1.SetActive(false);
        sectionView2.SetActive(true);

        if (sectionView3.active)
            sectionView3.SetActive(false);

        Debug.Log("On Joined Lobby");
    }

    private void OnDisconnectedFromPhoton()
    {
        if (sectionView1.active)
            sectionView1.SetActive(false);
        if (sectionView2.active)
            sectionView2.SetActive(false);

        sectionView3.SetActive(true);
        Debug.Log("Disconnected");
    }
}
