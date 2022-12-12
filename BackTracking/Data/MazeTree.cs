namespace Maze;

public class MazeTree{

    private Tree _bt;

    public MazeTree() => _bt = new();

    private void Build_Root_0() {

        _bt.AddRoot(0);
        var root = _bt.Root;
        if (root is null) return;

        root.AddLeft(1);
        root.AddRight(3);

    }

    private void Build_Lvl_1() {

        if (_bt.Root is null) return;
        var one = _bt.Root.Left;

        if (one is null) return;
        one.AddRight(2);

    }

    private Node? Build_Lvl_2() {

        if (_bt.Root is null) return null;
        var three = _bt.Root.Right;

        if (three is null) return null;
        three.AddLeft(4);
        three.AddRight(6);

        return three;

    }

    private Node? Build_Lvl_3(Node? three) {

        if (three is null) return null;
        var four = three.Left;

        if (four is null) return null;
        four!.AddLeft(5);
        four!.AddRight(7);

        return four;

    }

    private void Build_Lvl_4(Node? four) {

        if (four is null) return;
        var seven = four!.Right;

        if (seven is null) return;
        seven.AddRight(8);

    }

    public Tree Build() {

        Build_Root_0();
        Build_Lvl_1();  
        
        var three   = Build_Lvl_2();
        var four    = Build_Lvl_3(three);

        Build_Lvl_4(four);

        return _bt;

    }

}
