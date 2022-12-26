using HackerRank;

int pairs           = 1;
int[]   arr         = { 1, 3, -1, -3, 5, 3, 6, 7 };

var     swMin       = new SlidingWindow<MinPairs>(arr, pairs);
int[]   minPairs    = swMin.Get;

var     swMax       = new SlidingWindow<MaxPairs>(arr, pairs);
int[]   maxPairs    = swMax.Get;

Console.WriteLine("Done...");