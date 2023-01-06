namespace Easy;

/// <summary>
/// Write a method to find the longest common prefix string among an array of strings.
/// <para>All given inputs are in lowercase letters a-z</para>
/// <list type="bullet">
///    <item>I/P: ["flower", "flow", "flight"]<para>O/P: "fl"</para></item>
///    <item>I/P: ["dog", "racecar", "car"]<para>O/P: ""</para></item>
///    <item>I/P: ["carry", "careful", "car"]<para>O/P: "car"</para></item>
/// </list>
/// </summary>
public class LongestCommonPrefix : IProblem{
    
    public void EntryPoint(){
        
        List<string> input = new() { "dog", "racecar", "car" };
        string output = Find(input);

        Display.Out(String.Join(",", input));
        Display.Out(output, "".Equals(output));

    }

    private void Slice(int index, ref List<string> arr) {
        
        string tmp = arr[index];
        tmp = tmp.Substring(1);

        if (String.IsNullOrEmpty(tmp))
            arr.RemoveAt(index);
        else
            arr[index] = tmp;

    }

    public string Find(List<string> arr) {

        if (arr.Count <= 0) return "";
        string pre = string.Empty, tmp;

        for (int i = 0; i < arr.Count; i++) {

            tmp = arr[i];

            if (String.IsNullOrEmpty(pre)) {
                pre = tmp.Substring(0, 1);
                Slice(i, ref arr);
                continue;
            }

            if (!pre.Equals(tmp.Substring(0, 1)))
                return "";

            Slice(i, ref arr);

        }

        return pre + Find(arr);

    }

}
