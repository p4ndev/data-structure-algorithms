namespace hacker_rank;

public static class AlgorithmImplementation{

    public static string BiggerIsGreater(string w){

        string? _w      = null;
        var _i          = w.ToCharArray();
        int? pivot      = FindPivot(_i);
        bool hasPivot   = !(pivot is null);

        if (!hasPivot) {
            _w = NoPivot_CornerCases(_i, _w);
            _w = NoPivot_NoCornerCases(_i, _w);
        } else {            
            var successor = FindSuccessor(_i, _i[pivot!.Value]);
            if (successor.HasValue){
                _w = Pivot_Neighbors(_i, _w, pivot!.Value, successor!.Value);
                _w = Pivot_NotNeighbors(_i, _w, pivot!.Value, successor!.Value);
            }
        }
        
        return (String.IsNullOrEmpty(_w) ? "no answer" : _w);

    }

    // ================================== Algorithm I =========================================

    public static string? NoPivot_CornerCases(char[] w, string? o) {
        if (w.LastOrDefault().Equals('a'))
            return "";
        return null;
    }
    
    public static string? NoPivot_NoCornerCases(char[] w, string? o) {
        if (o is not null) return o;

        var idx = FindSuccessor(w, w[0]);

        if (idx.HasValue){
            w.Swap(0, idx.Value);
            w.Sort(1);
            return w.Merge();
        }

        return null;
    }

    // ================================= Algorithm II =========================================

    public static string? Pivot_Neighbors(char[] w, string? o, int p, int s) {

        if ((s - p).Equals(1)) {
            w.Swap(p, s);
            return w.Merge();            
        }

        return null;

    }
    
    public static string? Pivot_NotNeighbors(char[] w, string? o, int p, int s) {

        if (o is not null) return o;

        if (!(s - p).Equals(1)){

            if (s > p){
                w.Swap(p, s);
                w.Reverse(p + 1);
            }else {
                w.Swap(p, p + 1);
            }

            return w.Merge();
        }

        return null;

    }

    // ====================================== Utils ==========================================

    public static int? FindPivot(char[] input) {

        var idx = (input.Length - 1);
        var val = input[idx];

        while (idx >= 1) {

            if (input[idx - 1] < val)
                return (idx - 1);

            idx--;
        }

        return null;

    }

    public static int? FindSuccessor(char[] input, char letter) {

        int i;
        int? idx        = null;
        char? nextValue = null;
        int total       = input.Length;

        if (input.Length <= 1) return idx;

        var _input = new char[total];
        Array.Copy(input, _input, total);
        Array.Sort(_input);

        for (i = 0; i < total; i++) {
            if (_input[i].Equals(letter)) {
                idx = i;
                break;
            }
        }

        if (!idx.HasValue || idx.Equals(total - 1))
            return null;

        do {
            
            idx++;

            if (idx.Value >= total)
                break;

            nextValue = _input[idx.Value];

            if (!nextValue.Equals(letter))
                break;

        } while(idx < total);

        if (nextValue.Equals(letter))
            return null;

        for (i = 0; i < total; i++) {
            if (input[i].Equals(nextValue))
                idx = i;
        }

        return idx;

    }

    // =================================== Extension =========================================

    public static void Swap(this char[] input, int left, int right){
        var t = input[left];
        input[left] = input[right];
        input[right] = t;
    }

    public static void Reverse(this char[] input, int after)
        => Array.Reverse(input, after, (input.Length - after));

    public static void Sort(this char[] input, int after)
        => Array.Sort(input, after, (input.Length - after));

    public static string Merge(this char[] input){
        var s = new System.Text.StringBuilder();
        foreach (var l in input) s.Append(l);
        return s.ToString();
    }

}
