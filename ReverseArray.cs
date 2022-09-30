public static List<int> reverseArray(List<int> a){
        int t, i, j;        
        for(i = 0, j = (a.Count - 1); i < j; i++, j--){
            t = a[i];
            a[i] = a[j];
            a[j] = t;
        }        
        return a;
    }