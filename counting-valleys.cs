
Console.WriteLine(CountingValleys(8, "UDDDUDUU"));

// ==================  Expected: 1 =========================

static int CountingValleys(int steps, string path){
    int l = 0, v = 0;
    for (int i = 0; i < path.Length; i++) {
        if (path[i].Equals('D')){            
            if (l.Equals(0)) v++;
            l--;
        }else
            l++;
    }
    return v;
}