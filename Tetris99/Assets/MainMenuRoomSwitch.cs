using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuRoomSwitch : MonoBehaviour {

    public void GoToOnline99() {
        SceneManager.LoadScene("Online99", LoadSceneMode.Single);
    }


    public void GoToOffline99() {
        SceneManager.LoadScene("Offline99", LoadSceneMode.Single);
    }


    public void GoToOfflineMarathon() {
        SceneManager.LoadScene("OfflineMarathon", LoadSceneMode.Single);
    }
}
