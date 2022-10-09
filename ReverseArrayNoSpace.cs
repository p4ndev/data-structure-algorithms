

public static List<int> reverseArray(List<int> a){

    for(int i = 0, t = 0; i < (a.Count / 2); i++){
            
        t = (a.Count - 1 - i);
        if(i >= t) continue;
            
        a[i] += a[t];
        a[t]  = a[i] - a[t];
        a[i] -= a[t];
            
    }

    return a;

}