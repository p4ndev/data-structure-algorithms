namespace Problems;

/*
37ms Runtime    17.39% Beats            63.88Mb Memory      56.52% Beats
https://leetcode.com/problems/design-ride-sharing-system/submissions/2066712513
*/

public class LC3829
{
    private readonly HashSet<int> _matches;
    private readonly Queue<int> _drivers;
    private Queue<int> _riders;

    public LC3829()
    {
        _matches = new();
        _drivers = new();
        _riders = new();
    }

    public void AddRider(int riderId)
    {
        if (riderId <= 0)
            return;

        _riders.Enqueue(riderId);
    }

    public void AddDriver(int driverId)
    {
        if (driverId <= 0)
            return;

        _drivers.Enqueue(driverId);
    }

    public int[] MatchDriverWithRider()
    {
        int[] output = [-1, -1];

        if (_drivers.Count <= 0 || _riders.Count <= 0)
            return output;

        output[0] = _drivers.Dequeue();
        output[1] = _riders.Dequeue();
        _matches.Add(output[1]);

        return output;
    }

    public void CancelRider(int riderId)
    {
        if (_matches.Contains(riderId))
            return;

        Queue<int> tmp = new();

        while (_riders.TryDequeue(out int id))
            if(!riderId.Equals(id))
                tmp.Enqueue(id);

        _riders = tmp;
    }
}

/*
Outro approach que podemos aplicar nesse problema é:
- Em CancelRider, manter um HashSet com o id envolvido
- E dentro do MatchDriverWithRider, junto a atribuição do output[1]
    -- Efetuar o dequeue do _rider até o riderId não estiver disponível HashSet
*/