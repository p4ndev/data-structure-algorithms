
Console.WriteLine(PageCount(6, 2)); // Expected: 1
Console.WriteLine(PageCount(5, 4)); // Expected: 0

// 23 minutes to understand
//  7 minutes to code

static int PageCount(int n, int p){

    int totalFlip = (n / 2);
    (int Left, int Right) op = (0, 0);
    int[] possibilities = new int[2] { 0, 0 };
    bool[] found = new bool[2] { false, false };

    for (int i = 0, j = totalFlip; i < j; i++, j--) {

        #region Front to Back
        if (!found[0]){
            op = (i * 2, 0);
            op.Right = op.Left + 1;
            if (!p.Equals(op.Left) && !p.Equals(op.Right))
                possibilities[0]++;
            else
                found[0] = true;
        }
        #endregion

        #region Back to Front
        if (!found[1]) {
            op = (j * 2, 0);
            op.Right = op.Left + 1;
            if (!p.Equals(op.Left) && !p.Equals(op.Right))
                possibilities[1]++;
            else
                found[1] = true;
        }
        #endregion

        if (found[0] || found[1]) break;

    }

    int idx = (possibilities[0] > possibilities[1] ? 1 : 0);
    return (possibilities[idx]);

}