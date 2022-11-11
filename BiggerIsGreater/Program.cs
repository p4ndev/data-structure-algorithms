
Console.WriteLine(BiggerIsGreater("bb"));

static string BiggerIsGreater(string w){

    var sb = new System.Text.StringBuilder(w);
    var to = (sb.Length - 1);

    // Find longest non-increasing index (sulfix)
    int nonIncreasing = to;
    while (nonIncreasing > 0 && sb[nonIncreasing - 1] >= sb[nonIncreasing])
        nonIncreasing--;

    // Is last character already?
    if (nonIncreasing <= 0) return "no answer";

    // Find pivot
    int pivot = to;
    while (sb[pivot] <= sb[nonIncreasing - 1])
        pivot--;

    // Swap (NonIncreasing - 1) ^ Pivot
    char temp = sb[nonIncreasing - 1];
    sb[nonIncreasing - 1]   = sb[pivot];
    sb[pivot]               = temp;

    // Reverse the sulfix
    pivot = to;
    while (nonIncreasing < pivot) {

        temp                = sb[nonIncreasing];
        sb[nonIncreasing]   = sb[pivot];
        sb[pivot]           = temp;

        nonIncreasing++;
        pivot--;

    }

    return sb.ToString();

}