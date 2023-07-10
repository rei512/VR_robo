using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts;
using XCharts.Runtime;

public class ChartManager : MonoBehaviour
{
    /// <summary>
    /// �Q�[���I�u�W�F�N�g�E�R���|�[�l���g
    /// -----------------------------------------
    /// </summary>

    //�p�u���b�N
    [Header("LineChart�{��")]
    public GameObject LineChart;       //LineChart�{��
    public GameObject Head;

    //�v���C�x�[�g
    private LineChart linechart;       //LineChart�R���|�[�l���g



    /// <summary>
    /// ���\�b�h
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