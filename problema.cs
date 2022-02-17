using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problema : MonoBehaviour
{
    // Start is called before the first frame update
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int tempvalue = getVALUE(i, nums[i], nums);
            res[i] = tempvalue;
        }
        return res;

    }
    private int getVALUE(int id, int value, int[] nums)
    {
        int tempnum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != id && nums[i] < value)
            {
                tempnum++;
            }
        }
        return tempnum;
    }
}
