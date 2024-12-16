using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 引用場景管理函式庫

public class TransformScene : MonoBehaviour // 修正繼承的類型為 MonoBehaviour
{
    // 公開函式，對應第一個按鈕，用於切換到場景 "Scene1"
    public void LoadScene1()
    {
        SceneManager.LoadScene("chapter"); // 切換至專案中的場景 "Scene1"
    }

    // 公開函式，對應第二個按鈕，用於切換到場景 "Scene2"
    public void LoadScene2()
    {
        SceneManager.LoadScene("mainscene"); // 切換至專案中的場景 "Scene2"
    }
}
