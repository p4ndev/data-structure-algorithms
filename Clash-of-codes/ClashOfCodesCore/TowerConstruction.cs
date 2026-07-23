namespace Problems;

/*

I want to construct a tower of height H by stacking blocks in a straight line going upwards.

However, I only have two types of blocks (P and Q).

What is the maximum amount of blocks that can be used to construct the tower?

If it is not possible to construct, the output should be 0.

Constraints
    1 lte H lte 1000
    1 lte P lte Q lte 1000

*/

public partial class ClashOfCodeCore
{
    public int TowerConstruction(int h, int p, int q)
    {
        if (q < p)              return 0;
        if ((h % p).Equals(0))  return (h / p);
        if ((h % q).Equals(0))  return (h / q);

        int o = 0, c = (p + q);

        while((h >= p) || (h >= q))
        {
            switch (h) {

                case var s when s >= c:
                    o += 2;
                    h -= c;
                    break;
                
                case var s when s.Equals(p):
                    o++;
                    h -= p;
                    break;
                
                case var s when s.Equals(q):
                    o++;
                    h -= q;
                    break;
                
                case var s when s > p:
                    o++;
                    h -= p;
                    break;
                
                case var s when s > q:
                    o++;
                    h -= q;
                    break;
            }
        }

        return (h.Equals(0) ? o : 0);
    }
}
