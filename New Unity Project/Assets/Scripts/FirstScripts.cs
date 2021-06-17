using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScripts : MonoBehaviour
{
    public string cityName; //�������� ��������� ����������
    private int cityPopulation = 486000; //�������� ��������� ���������� � ���������������� 
    [SerializeField] private int cityYearofCreate;
    [SerializeField] private float citySquare;
    private float thickness;
    private int populationoftheRegion = 1119862;
    [SerializeField] private bool isContactWithSea = true;
    [Range(0f, 100f)] [SerializeField] private float partofUcrainian;

    [SerializeField] private Vector2 position = new Vector2(10.02f, 150.74f);
    


    void Start()
    {
        print(position);
        print("X:" + position.x + "Y: " + position.y);





        float cityAge;
        cityAge = 2021 - cityYearofCreate;
        print("������" + cityAge + "���");

        thickness = citySquare / cityPopulation;

        Debug.Log("���������� � ������" + cityName);
        Debug.LogError("��� ���������" + cityYearofCreate);
        print("������� ���������:" + thickness + "���/��.�");
        print("��������� �������:" + (populationoftheRegion - cityPopulation));
        print("��������� �������:" + (populationoftheRegion / cityPopulation * 100));
    }
}
