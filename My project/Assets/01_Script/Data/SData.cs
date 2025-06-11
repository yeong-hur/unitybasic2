using UnityEngine;

public class SData : SingletonBehabiour<SData>
{
    [SerializeField] Test testDatas; // DataTable�� ������ �� Name
    public static TestData[] TestData { get { return Instance.testDatas.dataArray; } } // ������ �� Name + Data
    public static TestData GetTestData(int _id)
    {
        for (int i = 0; i < TestData.Length; i++)
            if (TestData[i].ID_I == _id)
                return TestData[i];
        return null;
    }

}
