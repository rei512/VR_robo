using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts;
using XCharts.Runtime;

public class ChartManager : MonoBehaviour
{
    /// <summary>
    /// ゲームオブジェクト・コンポーネント
    /// -----------------------------------------
    /// </summary>

    //パブリック
    [Header("LineChart本体")]
    public GameObject LineChart;       //LineChart本体
    public GameObject Head;

    //プライベート
    private LineChart linechart;       //LineChartコンポーネント



    /// <summary>
    /// メソッド
    /// -----------------------------------------
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        linechart = LineChart.GetComponent<LineChart>();
        linechart.RemoveData();
        linechart.AddSerie<Line>("Head");

        InvokeRepeating("getHeadAng", 0.1f, 0.1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void getHeadAng()
    {
        linechart.AddData("Head", (int)(Head.transform.rotation.y*180));
    }
}