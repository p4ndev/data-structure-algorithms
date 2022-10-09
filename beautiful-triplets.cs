
int out_e, inp_d;
int inp_a = new List<int>();

// ==========================================================================================

inp_d = 1;                                          // Interval between numbers
inp_a = new List<int>(){ 2,2,3,4,5 };               // Numbers
out_e = 3;                                          // Output
Console.WriteLine("Result: {0} Expected: {1}", BeautifulTriplets(inp_d, inp_a), out_e);

// ==========================================================================================

inp_d = 3;                                          // Interval between numbers
inp_a = new List<int>(){ 1, 2, 4, 5, 6, 8, 10 };    // Numbers
out_e = 3;                                          // Output
Console.WriteLine("Result: {0} Expected: {1}", BeautifulTriplets(inp_d, inp_a), out_e);

// ==========================================================================================

static int BeautifulTriplets(int d, List<int> arr){

    int result = 0;

    for (int i = 0; i < arr.Count; i++){

        int remainder = (arr[i] + d);
        int counter = 1;

        for (int j = (i + 1); j < arr.Count; j++){

            if (arr[j].Equals(remainder)){
                counter++;
                remainder = (arr[j] + d);
            }

            if (counter >= 3){
                result++;
                break;
            }

        }

    }

    return result;

}