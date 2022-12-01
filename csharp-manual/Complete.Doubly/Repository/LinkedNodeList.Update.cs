public partial class LinkedNodeList {

    public bool Update(int data, int newData) {
        foreach (var entry in MoveNext()) {
            if (entry.Data.Equals(data)){
                entry.Data = newData;
                return true;
            }
        }
        return false;
    }

}