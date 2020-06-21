class Solution {
    public int maxArr(List<int> a) {
      int max1=a[0],min1=a[0],max2=a[0],min2=a[0];

    for(int i=1;i<a.Count;i++)
    
    {
        int x1=a[i]+i;
        
        int x2=a[i]-i;
        
        if(x1>max1)
        
            max1=x1;
        
        if(x1<min1)
        
            min1=x1;
        
        if(x2>max2)
        
            max2=x2;
        
        if(x2<min2)
        
            min2=x2;

    }

    return Math.Max(max1-min1,max2-min2);
        
        //return Math.Abs(maxVal - minVal) + Math.Abs(maxIndex - minIndex);
    }   
}
