Console.WriteLine(
    String.Join(',',
        ClimbingLeaderboard(
            new List<int>() { 100, 90, 90, 80,  75, 60 },
            new List<int>() {  50, 65, 77, 90, 102 }
        )
    )
); // 6, 5, 4, 2, 1

// No extra space with 8 tested passed
// Unfortunatel 4 test failed by time exceeded

static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player){

    int j, max, min, position = 1;

    for (int i = 0; i < (ranked.Count - 1); i++) {

        max = ranked[i];            min = ranked[i + 1];
        if (max.Equals(min))        continue;

        for (j = 0; j < player.Count; j++) {

            int t = player[j];
            if (t < 0)              continue;

            if (t >= max)           player[j] = (position * -1);
            else if (t >= min)      player[j] = (position + 1) * -1;

        }

        position++;

    }

    position++;

    for (j = 0; j < player.Count; j++)
        player[j] = (player[j] < 0 ? (player[j] * -1) : position);

    return player;

}




































Console.WriteLine(
    String.Join(',',
        ClimbingLeaderboard(
            new List<int>() { 100, 90, 90, 80,  75, 60 },
            new List<int>() {  50, 65, 77, 90, 102 }
        )
    )
); // 6, 5, 4, 2, 1

static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player){

    // 4 time limit exceeded, and 8 passed
    // Extra space to distinct and save iteration steps
    var leaderboard = ranked.Distinct();
    
    // Confirm each point with leaderboad position
    for (int p, i = (player.Count - 1); i >= 0; i--) {

        for(p = 0; p < leaderboard.Count(); p++)
            if (player[i] >= leaderboard.ElementAt(p))
                break; // exit exactly where I found (if any)

        player[i] = (p + 1);

    }

    // We switched values to positions
    return player;

}





















































// 40 mins | 2 error | 4 timeout | 6 passed | Medium
// Ordenação e processamento de coisas não usadas .Distinct .ToList
// Tentei usar o mesmo espaço de maneira efetiva, mas o tempo não foi bem feito
// Necessidade de utilizar DATA STRUCTURE
// O ranked veio de forma DESC, e o player de forma ASC
	// se invertido um dos dois processamento seria reduzido

Console.WriteLine(
    String.Join(',',
        ClimbingLeaderboard(
            new List<int>() { 100, 90, 90, 80,  75, 60  },
            new List<int>() {  50, 65, 77, 90, 102      }
        )
    )
); // 6, 5, 4, 2, 1

Console.WriteLine(
    String.Join(',',
        ClimbingLeaderboard(
            new List<int>() { 100, 100, 50, 40, 40, 20, 10 },
            new List<int>() { 5, 25, 50, 120 }
        )
    )
); // 6, 4, 2, 1

static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player){

    bool found = false;
    ranked = ranked.Distinct().ToList();
    int len = (ranked.Count - 1), min, max, tmp;
    
    for (int p = 0; p < player.Count; p++) {

        #region MAX
        max = ranked[0];
        tmp = player[p];
        
        if (tmp > max) {
            player[p] = 1;
            continue;
        }
        #endregion

        #region INNER
        for (int r = 0; r < len; r++) {
            max = ranked[r];
            min = ranked[r + 1];
            if (max >= tmp && tmp >= min) {
                found = true;
                player[p] = (r + 2);
                break;
            }
        }

        if (found) {
            found = false;
            continue;
        }
        #endregion

        #region MIN
        min = ranked[len];
        if (tmp < min)
            player[p] = (len + 2);
        #endregion

    }

    return player;

}

























































// Everything's fine but isn't my solution

Console.WriteLine(
    String.Join(',',
        ClimbingLeaderboard(
            new List<int>() { 100, 90, 90, 80,  75, 60 },
            new List<int>() {  50, 65, 77, 90, 102 }
        )
    )
); // 6, 5, 4, 2, 1

static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player){

    var leaderboard = new Stack<int>();
    var place = 1;
    var j = 0;

    for (var p = (player.Count - 1); p >= 0; p--){

        while ((j < ranked.Count) && (ranked[j] > player[p])){

            if (++j == ranked.Count){
                place++;
                break;
            }

            if (ranked[j - 1] > ranked[j])
                place++;

        }

        leaderboard.Push(place);

    }

    return leaderboard.ToList();

}
