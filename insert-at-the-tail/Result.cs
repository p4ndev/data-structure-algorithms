﻿using static System.Console;

public class SinglyLinkedList{

    public SinglyLinkedListNode head;

    public SinglyLinkedList() => this.head = null;

}

public class SinglyLinkedListNode{

    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData){
        this.data = nodeData;
        this.next = null;
    }

}

public static class Result{

    public static SinglyLinkedListNode Process(SinglyLinkedListNode head, int data) {

        if (head is null)
            return new SinglyLinkedListNode(data);

        SinglyLinkedListNode tmp = head;

        while (tmp.next != null)
            tmp = tmp.next;

        tmp.next = new SinglyLinkedListNode(data);

        return head;

    }

}
