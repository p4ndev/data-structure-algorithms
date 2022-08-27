using System.Collections;

// var exp = 2;
// var inp = new List<int>() { 7, 15, 12, 3 };

// var exp = 2;
// var inp = new List<int>() { 2, 5, 3, 1 };

var exp = 1;
var inp = new List<int>() { 2, 3, 1 };

var res = Result.lilysHomework_3(inp);
Console.ForegroundColor = res.Equals(exp) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine(res);

class Result{
    
    public static int lilysHomework(List<int> arr){

        int d = 0, s = 0;
        var bkp = new List<int>();
        
        bkp.AddRange(arr);
        arr.Sort();

        for (int i = 0; i < arr.Count; i++)
            if (!bkp[i].Equals(arr[i])) d++;

        s = (d / 2);
        if ((d % 2) != 0) s++;
        if ((arr.Count % 2) != 0) s--;
        return s;
        
    }
    
    public static int lilysHomework_2(List<int> arr){

        int steps = 0, data = 0 , index = 0;
        if (arr.Count <= 1) return 0;

        while (arr.Count > 1){
            
            data = arr[0];
            index = 0;
            
            for(int i = 1; i < arr.Count; i++)
                if (data > arr[i]){
                    data = arr[i];
                    index = i;
                }
                    
            if (index != 0) steps++;
            arr.RemoveAt(index);
            
        }
        
        return steps;
    }

    /* Completed and Valid (asc and desc) */
    public static int lilysHomework_3(List<int> arr){
        
        var valueIndex = new Hashtable();
        var desValueinde = new Hashtable();
        
        int[] ascList  = new int[arr.Count];
        int[] decList  = new int[arr.Count];
        int[] copyList = new int[arr.Count];
        
        arr.CopyTo(copyList);
        arr.CopyTo(ascList);
        Array.Sort(ascList);
        ascList.CopyTo(decList, 0);
        Array.Reverse(decList);
        
        int sola = 0;
        int sold = 0;
        
        for(int i=0;i<arr.Count;i++){
            valueIndex.Add(arr[i],i);
            desValueinde.Add(arr[i], i);
        }
        
        for (int i = 0; i < arr.Count; i++){
            if(arr[i]!=ascList[i]){
                
                sola++;
                
                int indexVal = (int)valueIndex[ascList[i]];
                int temp = arr[i];
                
                arr[i] = arr[indexVal];
                arr[indexVal] = temp;

                valueIndex[ascList[i]] = i;
                valueIndex[temp] = indexVal;

            }
        }
        
        for (int i = 0; i < arr.Count; i++){
            if (copyList[i] != decList[i]){
                
                sold++;
                
                int indexVal = (int)desValueinde[decList[i]];
                int temp = copyList[i];
                
                copyList[i] = copyList[indexVal];
                copyList[indexVal] = temp;

                desValueinde[decList[i]] = i;
                desValueinde[temp] = indexVal;

            }
        }
        
        Console.WriteLine(sola + "  " + sold);
        return ((sold > sola) ? sola : sold);
        
    }
    
}

